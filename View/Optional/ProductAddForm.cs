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
using System.Web;
using System.Windows.Forms;

namespace llc_decorations.View.Optional
{
    public partial class ProductAddForm : Form
    {
        string photoPath;
        string photoName;
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private bool HasArticle(string article)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                {
                    connection.Open();

                    string query = "SELECT ProductArticleNumber FROM Products WHERE ProductArticleNumber = @ProductArticleNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductArticleNumber", article);

                        var result = command.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Товар с таким артикулом уже существует в базе данных.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось проверить наличие артикула в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (!HasArticle(tbProductArticle.Text.Trim()))
            {
                try
                {
                    string productArticleNumber = tbProductArticle.Text.Trim();
                    string productName = tbProductName.Text.Trim();
                    string productUnitOfMeasurement = tbProductUnitOfMesurement.Text.Trim();
                    string productDescription = tbProductDescription.Text.Trim();
                    string productCategory = tbProductCategory.Text.Trim();
                    string productPhoto = photoName;
                    string productManufacturer = tbProductManufacturer.Text.Trim();
                    string productSupplier = tbProductSupplier.Text.Trim();

                    double productCost;
                    int productDiscountAmount;
                    int productMaxDiscountAmount;
                    int productQuantityInStock;

                    if (!double.TryParse(tbProductCost.Text, out productCost))
                    {
                        MessageBox.Show("Не удалось корректно получить цену товара.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(mtbProductDiscountAmount.Text, out productDiscountAmount))
                    {
                        MessageBox.Show("Не удалось корректно получить скидку товара.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(mtbProductMaxDiscountAmount.Text, out productMaxDiscountAmount))
                    {
                        MessageBox.Show("Не удалось корректно получить максимальную скидку товара.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(mtbProductQuantityInStock.Text, out productQuantityInStock))
                    {
                        MessageBox.Show("Не удалось корректно получить количество товара на складе.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString1))
                    {
                        connection.Open();

                        string query = @"
                        INSERT INTO Products(ProductArticleNumber, [ProductName ], ProductUnitOfMeasurement, ProductDescription, ProductCategory, ProductPhoto, ProductManufacturer, ProductSupplier, ProductCost, [ProductDiscountAmount ], ProductMaxDiscountAmount, ProductQuantityInStock)
                        VALUES (@ProductArticleNumber, @ProductName, @ProductUnitOfMeasurement, @ProductDescription, @ProductCategory, @ProductPhoto, @ProductManufacturer, @ProductSupplier, @ProductCost, @ProductDiscountAmount, @ProductMaxDiscountAmount, @ProductQuantityInStock)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductArticleNumber", productArticleNumber);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@ProductUnitOfMeasurement", productUnitOfMeasurement);
                            command.Parameters.AddWithValue("@ProductDescription", productDescription);
                            command.Parameters.AddWithValue("@ProductCategory", productCategory);

                            if (string.IsNullOrWhiteSpace(photoName))
                            {
                                command.Parameters.AddWithValue("@ProductPhoto", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@ProductPhoto", productPhoto);
                            }

                            command.Parameters.AddWithValue("@ProductManufacturer", productManufacturer);
                            command.Parameters.AddWithValue("@ProductSupplier", productSupplier);
                            command.Parameters.AddWithValue("@ProductCost", productCost);
                            command.Parameters.AddWithValue("@ProductDiscountAmount", productDiscountAmount);
                            command.Parameters.AddWithValue("@ProductMaxDiscountAmount", productMaxDiscountAmount);
                            command.Parameters.AddWithValue("@ProductQuantityInStock", productQuantityInStock);

                            command.ExecuteNonQuery();
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(photoName))
                    {
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        string folderPhotoesPath = System.IO.Path.Combine(projectDirectory, "Resources\\ProductPhoto\\");
                        string destinationPhotoFile = System.IO.Path.Combine(folderPhotoesPath, System.IO.Path.GetFileName(photoName));

                        File.Copy(photoName, destinationPhotoFile, true);
                    }

                    MessageBox.Show("Товар успешно добавлен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить товар.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDialog.FileName;
                pbProductPhoto.Image = Image.FromFile(photoPath);
                photoName = Path.GetFileName(photoPath);
            }
        }
    }
}
