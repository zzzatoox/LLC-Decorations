using llc_decorations.View;
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

namespace llc_decorations
{
    public partial class LogInForm : Form
    {
        private int loginAttempts = 0;

        public LogInForm()
        {
            InitializeComponent();
            CheckCredentials();
        }

        private void CheckCredentials()
        {
            if (File.Exists("credentials.txt"))
            {
                try
                {
                    string data = File.ReadAllText("credentials.txt");
                    string[] credentials = data.Split(',');

                    if (credentials.Length == 2)
                    {
                        string login = credentials[0];
                        string password = credentials[1];

                        tbLogIn.Text = login;
                        tbPassword.Text = password;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось заполнить учетные данные.");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbLogIn.Text.Trim().Length == 0 || tbPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string login = tbLogIn.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "CheckLogin";
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Connection = connection;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            UserData.Id = reader.GetInt32(0);
                            UserData.Surname = reader.GetString(1);
                            UserData.Name = reader.GetString(2);
                            UserData.Patronymic = reader.GetString(3);
                            UserData.RoleID = reader.GetInt32(6);

                            if (cbRememberMe.Checked)
                            {
                                try
                                {
                                    string data = $"{login},{password}";
                                    File.WriteAllText("credentials.txt", data);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Не удалось запомнить учетные данные.");
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            this.Hide();
                            ProductListForm productListForm = new ProductListForm();
                            productListForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Пользователя с таким логином и паролем не существует.");
                            loginAttempts++;
                            if (loginAttempts > 0)
                            {
                                CaptchForm captchForm = new CaptchForm();
                                captchForm.ShowDialog();

                                if (captchForm.isAnswerCorrect == false)
                                {
                                    MessageBox.Show("Возможность входа заблокирована на 10 сек.");

                                    DisableUserInput();
                                    await Task.Delay(10000);
                                    EnableUserInput();
                                }
                            }
                        }

                        reader.Close();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных.");
                Console.WriteLine(ex.Message);
            }
        }

        private void EnableUserInput()
        {
            tbLogIn.Enabled = true;
            tbPassword.Enabled = true;
            btnLogIn.Enabled = true;
        }

        private void DisableUserInput()
        {
            tbLogIn.Enabled = false;
            tbPassword.Enabled = false;
            btnLogIn.Enabled = false;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            UserData.RoleID = 4;
            this.Hide();
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
