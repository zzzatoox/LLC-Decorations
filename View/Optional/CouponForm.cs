using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View.Optional
{
    public partial class CouponForm : Form
    {
        List<Order> orders;
        DateTime orderDate;
        int orderId;
        double sumWithDiscount;
        int sumDiscountAmount;
        string selectedPickUpPointName;
        int orderCode;

        public CouponForm(List<Order> order1, DateTime orderDate1, int orderId1, double sumWithDiscount1, int sumDiscountAmount1, string selectedPickUpPointName1, int orderCode1)
        {
            orders = order1;
            orderDate = orderDate1;
            orderId = orderId1;
            sumWithDiscount = sumWithDiscount1;
            sumDiscountAmount = sumDiscountAmount1;
            selectedPickUpPointName = selectedPickUpPointName1;
            orderCode = orderCode1;

            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            try
            {
                lbOrders.DisplayMember = "ProductNameInListBox";

                lbOrders.DataSource = orders;

                FillLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось заполнить корзину товаров", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.Message);
            }
        }

        private void FillLabels()
        {
            lblOrderDate.Text = "Дата заказа: " + orderDate.ToString();
            lblOrderNumber.Text = "Номер заказа: " + orderId.ToString();
            lblSumWithDiscount.Text = "Сумма заказа: " + sumWithDiscount.ToString();
            lblDiscountAmount.Text = "Сумма скидки: " + sumDiscountAmount.ToString();
            lblPickUpPoint.Text = "Пункт выдачи: " + selectedPickUpPointName;
            lblOrderCode.Text = "Код для получения: " + orderCode.ToString();
        }
    }
}
