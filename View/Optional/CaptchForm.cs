using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View.Optional
{
    public partial class CaptchForm : Form
    {
        public bool isAnswerCorrect {  get; set; }

        string[] images;
        string captchAnswer;
        public CaptchForm()
        {
            InitializeComponent();
            DownloadCaptch();
            ShowCaptcha();
        }

        private void DownloadCaptch()
        {
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                images = Directory.GetFiles(Path.Combine(projectDirectory, "Resources\\Captch\\"), "*.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти папку Captch.");
                Console.WriteLine($"Error : {ex}");
            }
        }

        private void ShowCaptcha()
        {
            try
            {
                var rand = new Random();
                captchAnswer = images[rand.Next(images.Length)];
                pbImage.ImageLocation = captchAnswer;

                captchAnswer = Path.GetFileNameWithoutExtension(captchAnswer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отобразить каптчу.");
                Console.WriteLine($"Error : {ex}");
            }
        }

        private void btnCaptch_Click(object sender, EventArgs e)
        {
            if (tbCaptch.Text.Trim().Length < 0)
            {
                MessageBox.Show("Введите каптчу.");
                return;
            }

            if (tbCaptch.Text.Trim() == captchAnswer)
            {
                MessageBox.Show("Каптча успешно пройдена.");
                isAnswerCorrect = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Каптча введена неверно.");
                isAnswerCorrect = false;
                this.Close();
            }
        }
    }
}
