namespace llc_decorations
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.tbLogIn = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlOptionalBG = new System.Windows.Forms.Panel();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlOptionalBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogIn
            // 
            this.tbLogIn.Location = new System.Drawing.Point(182, 164);
            this.tbLogIn.Name = "tbLogIn";
            this.tbLogIn.Size = new System.Drawing.Size(100, 23);
            this.tbLogIn.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(182, 234);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(131, 324);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(200, 36);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "ВОЙТИ";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.White;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuest.Location = new System.Drawing.Point(131, 366);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(200, 36);
            this.btnGuest.TabIndex = 3;
            this.btnGuest.Text = "ВОЙТИ КАК ГОСТЬ";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogIn.Location = new System.Drawing.Point(185, 135);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(88, 26);
            this.lblLogIn.TabIndex = 4;
            this.lblLogIn.Text = "ЛОГИН:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(185, 205);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 26);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "ПАРОЛЬ:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeading.Location = new System.Drawing.Point(152, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(154, 26);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "АВТОРИЗАЦИЯ";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(88, 89);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // pnlOptionalBG
            // 
            this.pnlOptionalBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlOptionalBG.Controls.Add(this.pbLogo);
            this.pnlOptionalBG.Location = new System.Drawing.Point(0, -1);
            this.pnlOptionalBG.Name = "pnlOptionalBG";
            this.pnlOptionalBG.Size = new System.Drawing.Size(115, 429);
            this.pnlOptionalBG.TabIndex = 8;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRememberMe.Location = new System.Drawing.Point(157, 263);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(155, 27);
            this.cbRememberMe.TabIndex = 9;
            this.cbRememberMe.Text = "Запомнить меня";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 424);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogIn);
            this.Controls.Add(this.pnlOptionalBG);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Украшения\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlOptionalBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlOptionalBG;
        private System.Windows.Forms.CheckBox cbRememberMe;
    }
}

