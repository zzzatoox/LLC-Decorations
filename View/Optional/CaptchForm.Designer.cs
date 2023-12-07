namespace llc_decorations.View.Optional
{
    partial class CaptchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnCaptch = new System.Windows.Forms.Button();
            this.tbCaptch = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlTop.Controls.Add(this.lblText);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(419, 81);
            this.pnlTop.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(132, 17);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(152, 26);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Введите каптчу";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(78, 46);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(267, 209);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // btnCaptch
            // 
            this.btnCaptch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCaptch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCaptch.Location = new System.Drawing.Point(119, 309);
            this.btnCaptch.Name = "btnCaptch";
            this.btnCaptch.Size = new System.Drawing.Size(200, 36);
            this.btnCaptch.TabIndex = 3;
            this.btnCaptch.Text = "Подтвердить";
            this.btnCaptch.UseVisualStyleBackColor = false;
            this.btnCaptch.Click += new System.EventHandler(this.btnCaptch_Click);
            // 
            // tbCaptch
            // 
            this.tbCaptch.Location = new System.Drawing.Point(119, 271);
            this.tbCaptch.Name = "tbCaptch";
            this.tbCaptch.Size = new System.Drawing.Size(200, 23);
            this.tbCaptch.TabIndex = 4;
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 357);
            this.Controls.Add(this.tbCaptch);
            this.Controls.Add(this.btnCaptch);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каптча";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnCaptch;
        private System.Windows.Forms.TextBox tbCaptch;
    }
}