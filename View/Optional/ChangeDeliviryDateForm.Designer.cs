namespace llc_decorations.View.Optional
{
    partial class ChangeDeliviryDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDeliviryDateForm));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dtpDeliviryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliviryDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnTop.Controls.Add(this.lblName);
            this.pnTop.Controls.Add(this.pbLogo);
            this.pnTop.Location = new System.Drawing.Point(1, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(331, 89);
            this.pnTop.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(213, 26);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Смена даты доставки:";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(257, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(67, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // dtpDeliviryDate
            // 
            this.dtpDeliviryDate.CustomFormat = "";
            this.dtpDeliviryDate.Location = new System.Drawing.Point(12, 123);
            this.dtpDeliviryDate.MinDate = new System.DateTime(2023, 11, 25, 15, 53, 28, 0);
            this.dtpDeliviryDate.Name = "dtpDeliviryDate";
            this.dtpDeliviryDate.Size = new System.Drawing.Size(313, 23);
            this.dtpDeliviryDate.TabIndex = 29;
            this.dtpDeliviryDate.Value = new System.DateTime(2023, 11, 25, 15, 53, 28, 0);
            // 
            // lblDeliviryDate
            // 
            this.lblDeliviryDate.AutoSize = true;
            this.lblDeliviryDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeliviryDate.Location = new System.Drawing.Point(12, 102);
            this.lblDeliviryDate.Name = "lblDeliviryDate";
            this.lblDeliviryDate.Size = new System.Drawing.Size(165, 18);
            this.lblDeliviryDate.TabIndex = 30;
            this.lblDeliviryDate.Text = "Выберите дату доставки:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(171, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(9, 188);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(154, 23);
            this.btnChange.TabIndex = 32;
            this.btnChange.Text = "СМЕНИТЬ";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangeDeliviryDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDeliviryDate);
            this.Controls.Add(this.dtpDeliviryDate);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ChangeDeliviryDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена даты доставки";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DateTimePicker dtpDeliviryDate;
        private System.Windows.Forms.Label lblDeliviryDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
    }
}