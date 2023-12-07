using llc_decorations.View.Optional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View
{
    public partial class OrdersForm : Form
    {
        DataTable dt;
        public OrdersForm()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
            
        }

        private void PaintTable()
        {
            // крашу фон строки в dgvMain
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                int orderId = Convert.ToInt32(row.Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = @"
                            SELECT
	                            SUM(CASE
		                            WHEN P.ProductQuantityInStock < 3 THEN 1
		                            ELSE 0
	                            END) AS [Присутствует на складе]
                            FROM
	                            OrderProduct AS OP
                            JOIN
	                            Products AS P ON OP.ProductAtricle = P.ProductArticleNumber
                            WHERE
	                            OP.OrderId = @OrderID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        object result = command.ExecuteScalar();

                        if (result == null || Convert.IsDBNull(result))
                        {
                        }
                        else
                        {
                            int sum = (int)result;

                            if (sum == 0)
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(byte)(255)), ((int)(byte)(140)), ((int)(byte)(0)));
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#20b2aa");
                            }
                        }
                    }
                }
            }
        }

        private void FillTable()
        {
            try
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = @"
                            SELECT
                                O.OrderID,
                                O.OrderDate AS [Дата заказа],
                                O.OrderDeliveryDate AS [Дата доставки],
                                (SUM(P.ProductCost * OP.OrderQuantity) - SUM(P.[ProductDiscountAmount ])) AS [Общая стоимость заказа с учетом скидки],
                                SUM(P.[ProductDiscountAmount ]) AS [Суммарная скидка],
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END AS [Клиент],
	                            O.OrderStatus AS [Статус]
                            FROM
                                Orders AS O
                            LEFT JOIN
                                Users AS U ON O.OrderClient = U.UserId
                            LEFT JOIN
                                OrderProduct AS OP ON O.OrderID = OP.OrderId
                            LEFT JOIN
                                Products AS P ON OP.ProductAtricle = P.ProductArticleNumber
                            GROUP BY
                                O.OrderID,
                                O.OrderDate,
                                O.OrderDeliveryDate,
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END,
	                            O.OrderStatus";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                dt = new DataTable();

                                adapter.Fill(dt);

                                dgvMain.DataSource = dt;

                                dgvMain.RowHeadersVisible = false;
                            }
                        }
                    }
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = @"
                            SELECT
                                O.OrderID,
                                O.OrderDate AS [Дата заказа],
                                O.OrderDeliveryDate AS [Дата доставки],
                                (SUM(P.ProductCost * OP.OrderQuantity) - SUM(P.[ProductDiscountAmount ])) AS [Общая стоимость заказа с учетом скидки],
                                SUM(P.[ProductDiscountAmount ]) AS [Суммарная скидка],
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END AS [Клиент],
	                            O.OrderStatus AS [Статус]
                            FROM
                                Orders AS O
                            LEFT JOIN
                                Users AS U ON O.OrderClient = U.UserId
                            LEFT JOIN
                                OrderProduct AS OP ON O.OrderID = OP.OrderId
                            LEFT JOIN
                                Products AS P ON OP.ProductAtricle = P.ProductArticleNumber
                            GROUP BY
                                O.OrderID,
                                O.OrderDate,
                                O.OrderDeliveryDate,
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END,
	                            O.OrderStatus
                            HAVING
	                            SUM(P.[ProductDiscountAmount ]) BETWEEN 0 AND 10";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                dt = new DataTable();

                                adapter.Fill(dt);

                                dgvMain.DataSource = dt;

                                dgvMain.RowHeadersVisible = false;
                            }
                        }
                    }
                }
                else if (cbFilter.SelectedIndex == 2)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = @"
                            SELECT
                                O.OrderID,
                                O.OrderDate AS [Дата заказа],
                                O.OrderDeliveryDate AS [Дата доставки],
                                (SUM(P.ProductCost * OP.OrderQuantity) - SUM(P.[ProductDiscountAmount ])) AS [Общая стоимость заказа с учетом скидки],
                                SUM(P.[ProductDiscountAmount ]) AS [Суммарная скидка],
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END AS [Клиент],
	                            O.OrderStatus AS [Статус]
                            FROM
                                Orders AS O
                            LEFT JOIN
                                Users AS U ON O.OrderClient = U.UserId
                            LEFT JOIN
                                OrderProduct AS OP ON O.OrderID = OP.OrderId
                            LEFT JOIN
                                Products AS P ON OP.ProductAtricle = P.ProductArticleNumber
                            GROUP BY
                                O.OrderID,
                                O.OrderDate,
                                O.OrderDeliveryDate,
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END,
	                            O.OrderStatus
                            HAVING
	                            SUM(P.[ProductDiscountAmount ]) BETWEEN 11 AND 14";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                dt = new DataTable();

                                adapter.Fill(dt);

                                dgvMain.DataSource = dt;

                                dgvMain.RowHeadersVisible = false;
                            }
                        }
                    }
                }
                else if (cbFilter.SelectedIndex == 3)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = @"
                            SELECT
                                O.OrderID,
                                O.OrderDate AS [Дата заказа],
                                O.OrderDeliveryDate AS [Дата доставки],
                                (SUM(P.ProductCost * OP.OrderQuantity) - SUM(P.[ProductDiscountAmount ])) AS [Общая стоимость заказа с учетом скидки],
                                SUM(P.[ProductDiscountAmount ]) AS [Суммарная скидка],
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END AS [Клиент],
	                            O.OrderStatus AS [Статус]
                            FROM
                                Orders AS O
                            LEFT JOIN
                                Users AS U ON O.OrderClient = U.UserId
                            LEFT JOIN
                                OrderProduct AS OP ON O.OrderID = OP.OrderId
                            LEFT JOIN
                                Products AS P ON OP.ProductAtricle = P.ProductArticleNumber
                            GROUP BY
                                O.OrderID,
                                O.OrderDate,
                                O.OrderDeliveryDate,
                                CASE
                                    WHEN O.OrderClient is NULL THEN 'Неавторизованный пользователь'
                                    ELSE U.UserSurname + ' ' + U.UserName + ' ' + U.UserPatronymic
                                END,
	                            O.OrderStatus
                            HAVING
	                            SUM(P.[ProductDiscountAmount ]) >= 15";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                dt = new DataTable();

                                adapter.Fill(dt);

                                dgvMain.DataSource = dt;

                                dgvMain.RowHeadersVisible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось поулчить список заказов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns["Общая стоимость заказа с учетом скидки"], ListSortDirection.Ascending);
            PaintTable();
        }

        private void rbDescending_CheckedChanged(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns["Общая стоимость заказа с учетом скидки"], ListSortDirection.Descending);
            PaintTable();
        }

        private void подробноОЗаказеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value);

            OrderInfoForm orderInfoForm = new OrderInfoForm(orderId);
            orderInfoForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void btnCheckProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow.Cells[6].Value.ToString() == "Завершен")
            {
                MessageBox.Show("Можно изменить только заказ со статусом 'Новый'.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Вы точно хотите изменить статус выбранного заказа на 'Завершен'?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int orderId = Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value);
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = "UPDATE Orders SET OrderStatus = 'Завершен' WHERE OrderID = @OrderID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Статус выбранного заказа успешно сменен на 'Завершен'", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillTable();
                    PaintTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сменить статус выбранного заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnChangeDeliviryDate_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow.Cells[0].Value != null)
            {
                if (dgvMain.CurrentRow.Cells[6].Value.ToString() != "Завершен")
                {
                    ChangeDeliviryDateForm dateForm = new ChangeDeliviryDateForm();

                    try
                    {
                        if (dateForm.ShowDialog() == DialogResult.OK)
                        {
                            DateTime selectedDate = dateForm.date;
                            int orderId = Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value);

                            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                            {
                                connection.Open();

                                string query = "UPDATE Orders SET OrderDeliveryDate = @OrderDeliviryDate WHERE OrderID = @OrderID";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@OrderDeliviryDate", selectedDate);
                                    command.Parameters.AddWithValue("@OrderID", orderId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Дата доставки выбранного заказа успешно изменена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FillTable();
                            PaintTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось изменить дату доставки выбранного заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите заказ со статусом 'Новый'.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;

            rbAscending.Checked = false;
            rbDescending.Checked = false;

            FillTable();
            PaintTable();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbAscending.Checked = false;
            rbDescending.Checked = false;

            FillTable();
            PaintTable();
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

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            FillTable();
            PaintTable();
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
