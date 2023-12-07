using llc_decorations.View.Optional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace llc_decorations.View
{
    public partial class ProductListForm : Form
    {
        private static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        DataTable dt;
        List<Order> orders;
        public ProductListForm()
        {
            InitializeComponent();

            cbFilter.SelectedIndex = 0;

            btnCheckOrder.Visible = false;
            btnOrders.Visible = false;
            btnProductAdd.Visible = false;

            contextMenuStrip1.Items[1].Visible = false;

            if (UserData.RoleID == 2)
            {
                btnOrders.Visible = true;
            }

            if (UserData.RoleID == 3)
            {
                tbProductName.ReadOnly = false;
                tbProductDescription.ReadOnly = false;
                tbProductManufacturer.ReadOnly = false;
                tbProductCost.ReadOnly = false;

                mtbDiscount.ReadOnly = false;

                dgvMain.ReadOnly = false;

                btnOrders.Visible = true;
                btnProductAdd.Visible = true;

                contextMenuStrip1.Items[1].Visible = true;
            }
            else { mtbDiscount.ReadOnly = true; }

            if (UserData.RoleID == 4)
            {
                lblName.Text = "";
            }
            else
            {
                lblName.Text = $"{UserData.Surname} {UserData.Name} {UserData.Patronymic}";
            }
        }

        private void FillProductsTable()
        {
            try
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductDiscountAmount BETWEEN 0 and 9";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 2)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductDiscountAmount BETWEEN 10 and 14";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 3)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductDiscountAmount >= 15";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products ";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }

                PaintTable();

                // вывод кол-ва товаров
                int getAllProducts = 0;
                int countProducts = dgvMain.RowCount - 1;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Products";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        getAllProducts = (int)command.ExecuteScalar();
                    }
                }
                lblCountProducts.Text = $"Товаров '{countProducts}/{getAllProducts}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить товары.");
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void PaintTable()
        {
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) > 15)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#20b2aa");
                }
            }

            foreach (DataGridViewColumn col in dgvMain.Columns)
            {
                col.ReadOnly = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbProductName.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                tbProductDescription.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
                tbProductManufacturer.Text = dgvMain.CurrentRow.Cells[3].Value.ToString();
                tbProductCost.Text = dgvMain.CurrentRow.Cells[6].Value.ToString();

                mtbDiscount.Text = dgvMain.CurrentRow.Cells[7].Value.ToString();

                string productPhoto = dgvMain.CurrentRow.Cells[0].Value.ToString();
                string photoPath = Path.Combine(projectDirectory, $"Resources\\ProductPhoto\\{productPhoto}.jpg");

                if (File.Exists(photoPath))
                {
                    pbProductPhoto.ImageLocation = Path.Combine(projectDirectory, $"Resources\\ProductPhoto\\{productPhoto}.jpg");
                }
                else
                {
                    try
                    {
                        pbProductPhoto.ImageLocation = Path.Combine(projectDirectory, $"Resources\\picture.png");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось загрузить фотографию");
                        Console.WriteLine($"Error: {ex}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборе товара в таблице.");
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns["Цена без скидки"], ListSortDirection.Ascending);
            PaintTable();
        }

        private void rbDescending_CheckedChanged(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns["Цена без скидки"], ListSortDirection.Descending);
            PaintTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                try
                {
                    FillProductsTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось получить товары из базы данных.");
                    Console.WriteLine(ex.Message);
                }
                return;
            }

            try
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductName LIKE '%" + tbSearch.Text + "%'";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductName LIKE '%" + tbSearch.Text + "%' and ProductDiscountAmount BETWEEN 0 and 9";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 2)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductName LIKE '%" + tbSearch.Text + "%' and ProductDiscountAmount BETWEEN 10 and 14";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }
                else if (cbFilter.SelectedIndex == 3)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string select =
                            "SELECT " +
                                "ProductArticleNumber as Артикул, " +
                                "ProductName as Название, " +
                                "ProductDescription as [Описание товара], " +
                                "ProductManufacturer as Производитель, " +
                                "ProductCategory as Категория, " +
                                "ProductCost as [Цена без скидки] , " +
                                "ProductCost - ((ProductCost / 100) * ProductDiscountAmount) as [Цена со скидкой], " +
                                "ProductDiscountAmount as Скидка, " +
                                "ProductQuantityInStock as Количество " +
                            "FROM " +
                                "Products " +
                                "WHERE ProductName LIKE '%" + tbSearch.Text + "%' and ProductDiscountAmount >= 15";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = select;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        dt = new DataTable("Products");
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;

                        dgvMain.RowHeadersVisible = false;

                        connection.Close();
                    }
                }

                int getAllProducts = 0;
                int countProducts = dgvMain.RowCount - 1;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Products";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        getAllProducts = (int)command.ExecuteScalar();
                    }
                }
                lblCountProducts.Text = $"Товаров '{countProducts}/{getAllProducts}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить товары из базы данных.");
                Console.WriteLine(ex.Message);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbAscending.Checked = false;
            rbDescending.Checked = false;

            FillProductsTable();
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentRow = e.RowIndex;
                int currentColumn = e.ColumnIndex;

                if (currentRow >= 0)
                {
                    dgvMain.Rows[currentRow].Selected = true;

                    Point point = dgvMain.PointToClient(Cursor.Position);

                    contextMenuStrip1.Show(dgvMain, point);
                }
            }
        }

        private void добавитьКЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOrder.Visible = true;

            string productArticleNumber = dgvMain.CurrentRow.Cells[0].Value.ToString();
            string productName = dgvMain.CurrentRow.Cells[1].Value.ToString();
            string productDescription = dgvMain.CurrentRow.Cells[2].Value.ToString();
            string productManufacturer = dgvMain.CurrentRow.Cells[3].Value.ToString();
            string productCategory = dgvMain.CurrentRow.Cells[4].Value.ToString();
            string productCostWithoutDiscount = dgvMain.CurrentRow.Cells[5].Value.ToString();
            string productCostWithDiscount = dgvMain.CurrentRow.Cells[6].Value.ToString();
            string productDiscountAmount = dgvMain.CurrentRow.Cells[7].Value.ToString();

            string productPhoto = dgvMain.CurrentRow.Cells[0].Value.ToString();
            string photoPath = Path.Combine(projectDirectory, $"Resources\\ProductPhoto\\{productPhoto}.jpg");

            if (!File.Exists(photoPath))
            {
                photoPath = Path.Combine(projectDirectory, $"Resources\\picture.png");
            }

            Order order = new Order
            {
                photoPath = photoPath,
                ProductArticleNumber = productArticleNumber,
                ProductName = productName,
                ProductDescription = productDescription,
                ProductManufacturer = productManufacturer,
                ProductCategory = productCategory,
                ProductCostWithoutDiscount = productCostWithoutDiscount,
                ProductCostWithDiscount = productCostWithDiscount,
                ProductDiscountAmount = productDiscountAmount
            };

            if (orders == null)
            {
                orders = new List<Order>();
            }

            orders.Add(order);

            contextMenuStrip1.Hide();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(orders);
            cartForm.ShowDialog();

            if (orders.Count == 0)
            {
                btnCheckOrder.Visible = false;
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void tbProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string productArticle = dgvMain.CurrentRow.Cells[0].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = "UPDATE Products SET [ProductName ]= @ProductName, ProductDescription = @ProductDescription, ProductManufacturer = @ProductManufacturer, ProductCost = @ProductCost, [ProductDiscountAmount ] = @Discount WHERE ProductArticleNumber = @ProductArticle";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductName", tbProductName.Text);
                            command.Parameters.AddWithValue("@ProductDescription", tbProductDescription.Text);
                            command.Parameters.AddWithValue("@ProductManufacturer", tbProductManufacturer.Text);
                            command.Parameters.AddWithValue("@ProductCost", Convert.ToSingle(tbProductCost.Text));
                            command.Parameters.AddWithValue("@Discount", Convert.ToInt32(mtbDiscount.Text));
                            command.Parameters.AddWithValue("@ProductArticle", productArticle);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Информация о товаре успешно изменена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillProductsTable();
                    PaintTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось обновить информацию товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
            FillProductsTable();
            PaintTable();
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string productArticle = dgvMain.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить товар?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = "DELETE FROM Products WHERE ProductArticleNumber = @ProductArticleNumber";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductArticleNumber", productArticle);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Товар успешно удален из списка продуктов.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillProductsTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить товар.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            FillProductsTable();
            PaintTable();
        }

        private void ProductListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
