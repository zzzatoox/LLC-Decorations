    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View.Optional
{
    public partial class OrderInfoForm : Form
    {
        int orderId;
        public OrderInfoForm(int orderId1)
        {
            orderId = orderId1;
            InitializeComponent();

            FillListBox();
        }

        private void FillListBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = "SELECT P.ProductDescription, OP.OrderQuantity FROM OrderProduct AS OP JOIN Products AS P ON OP.ProductAtricle =  P.ProductArticleNumber WHERE OP.OrderId = @OrderID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                lbOrders.Items.Add(row["ProductDescription"].ToString() + " - " + row["OrderQuantity"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить состав заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
