using llc_decorations.View.Optional;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View
{
    public partial class CartForm : Form
    {
        List<Order> orders;

        double sumWithDiscount = 0;
        int sumDiscountAmount = 0;
        public CartForm(List<Order> orders1)
        {
            orders = orders1;
            InitializeComponent();

            if (UserData.RoleID == 4)
            {
                lblName.Text = "ФИО: Гость";
            }
            else
            {
                lblName.Text = $"ФИО: {UserData.Surname} {UserData.Name} {UserData.Patronymic}";
            }

            FillListBox();
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = "SELECT * FROM PickUpPoints";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                cbPickUpPoints.DataSource = dt;
                cbPickUpPoints.DisplayMember = "PickUpPoint";
                cbPickUpPoints.ValueMember = "PickUpPointId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить пункты выдачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        //пофиксить отображение когда удаляется не первый товар из корзины
        private void FillListBox()
        {
            try
            {
                lbOrders.DataSource = null;

                lbOrders.DisplayMember = "";
                lbOrders.DisplayMember = "ProductNameInListBox";

                lbOrders.DataSource = orders;

                if (orders.Count != 0)
                {
                    lbOrders.SelectedIndex = 0;
                }

                CountSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось заполнить корзину товарами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void CountSum()
        {
            double sumWithDiscount1 = 0;
            int sumDiscountAmount1 = 0;

            foreach (Order order in orders)
            {
                sumWithDiscount1 += Convert.ToDouble(order.ProductCostWithDiscount);
                sumDiscountAmount1 += Convert.ToInt32(order.ProductDiscountAmount);
            }

            sumDiscountAmount = sumDiscountAmount1;
            sumWithDiscount = sumWithDiscount1;

            lblSumWithDiscount.Text = $"Итоговая сумма со скидкой: {sumWithDiscount}";
            lblSumDiscountAmount.Text = $"Итоговая сумма без скидкой: {sumDiscountAmount}";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count != 0)
            {
                int selectedIndex = lbOrders.SelectedIndex;
                orders.RemoveAt(selectedIndex);

                FillListBox();
            }
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedItem != null)
            {
                Order selectedOrder = (Order)lbOrders.SelectedItem;
                string photoPath = selectedOrder.photoPath;
                pbPhoto.ImageLocation = photoPath;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count == 0)
            {
                MessageBox.Show("Корзина пустая.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbPickUpPoints.SelectedValue != null)
            {
                //LINQ запрос
                var query = orders.GroupBy(o => o.ProductArticleNumber)
                      .Select(g => new { ProductArticleNumber = g.Key, Count = g.Count() });

                //обновляю количество на складе
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    foreach (var item in query)
                    {
                        string query2 = "UPDATE Products SET ProductQuantityInStock = CASE WHEN ProductQuantityInStock > 0 THEN ProductQuantityInStock - @Count ELSE ProductQuantityInStock END WHERE ProductArticleNumber = @ProductArticleNumber";

                        using (SqlCommand command = new SqlCommand(query2, connection))
                        {
                            command.Parameters.AddWithValue("@Count", item.Count);
                            command.Parameters.AddWithValue("@ProductArticleNumber", item.ProductArticleNumber);

                            command.ExecuteNonQuery();
                        }
                    }
                }

                //вставляю запись о заказе
                int selectedPickUpPointId = (int)cbPickUpPoints.SelectedValue;
                string selectedPickUpPointName = cbPickUpPoints.Text;

                DateTime orderDate = DateTime.Now;

                // Вычисление срока доставки
                bool countDays = true;

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    foreach (var item in query)
                    {
                        string query2 = "SELECT ProductQuantityInStock FROM Products WHERE ProductArticleNumber = @ProductArticleNumber";

                        string productArticleNumber = item.ProductArticleNumber;

                        using (SqlCommand command = new SqlCommand(query2, connection))
                        {
                            command.Parameters.AddWithValue("@ProductArticleNumber", productArticleNumber);

                            int count = (int)command.ExecuteScalar();
                            if (count < 3)
                            {
                                countDays = false;
                            }
                        }
                    }
                }


                DateTime orderDeliveryDate = orderDate.AddDays(countDays ? 3 : 6);

                // Получение последнего кода заказа
                int lastOrderCode = GetLastOrderCode();
                int orderCode = lastOrderCode + 1;

                int orderId;

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query2 = "INSERT INTO Orders(OrderDate, OrderDeliveryDate, OrderPickupPoint, OrderClient, OrderCode, OrderStatus) OUTPUT INSERTED.OrderID VALUES (@OrderDate, @OrderDeliveryDate, @OrderPickupPoint, @OrderClient, @OrderCode, 'Новый')";
                    
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@OrderDeliveryDate", orderDeliveryDate);
                        command.Parameters.AddWithValue("@OrderPickupPoint", selectedPickUpPointId);

                        if (UserData.RoleID == 4)
                        {
                            command.Parameters.AddWithValue("@OrderClient", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@OrderClient", UserData.Id);
                        }

                        command.Parameters.AddWithValue("@OrderCode", orderCode);

                        orderId = (int)command.ExecuteScalar();
                    }
                }

                //вставляю записи в OrderProduct
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    foreach (var item in query)
                    {
                        string query2 = "INSERT INTO OrderProduct (OrderId, ProductAtricle, OrderQuantity) VALUES (@OrderId, @ProductArticle, @OrderQuantity)";
                        using (SqlCommand command = new SqlCommand(query2, connection))
                        {
                            command.Parameters.AddWithValue("@OrderId", orderId);
                            command.Parameters.AddWithValue("@ProductArticle", item.ProductArticleNumber);
                            command.Parameters.AddWithValue("@OrderQuantity", item.Count);

                            command.ExecuteNonQuery();
                        }
                    }
                }

                CouponForm couponForm = new CouponForm(orders, orderDate, orderId, sumWithDiscount, sumDiscountAmount, selectedPickUpPointName, orderCode);
                couponForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите пункт выдачи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private int GetLastOrderCode()
        {
            string query = "SELECT MAX(OrderCode) FROM Orders";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        //private bool QuantityInStockGreaterThen3()
        //{
        //    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
        //    {
        //        connection.Open();

        //        var query = orders.GroupBy(o => o.ProductArticleNumber)
        //              .Select(g => new { ProductArticleNumber = g.Key, Count = g.Count() });

        //        foreach (var item in query)
        //        {
        //            string query2 = "SELECT ProductQuantityInStock FROM Products WHERE ProductQuantityInStock = @ProductAtricleNumber";
                    
        //            using (SqlCommand command = new SqlCommand(query2, connection))
        //            {
        //                command.Parameters.AddWithValue("@ProductAtricleNumber", item.ProductArticleNumber);

        //                int count = (int)command.ExecuteScalar();
        //                if (count < 3)
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
