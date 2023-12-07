namespace llc_decorations.View.Optional
{
    partial class CouponForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponForm));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblSumWithDiscount = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblPickUpPoint = new System.Windows.Forms.Label();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnTop.Controls.Add(this.lblName);
            this.pnTop.Controls.Add(this.pbLogo);
            this.pnTop.Location = new System.Drawing.Point(0, -3);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(331, 89);
            this.pnTop.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 26);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Талон:";
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
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(5, 106);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(85, 18);
            this.lblOrderDate.TabIndex = 11;
            this.lblOrderDate.Text = "Дата заказа:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNumber.Location = new System.Drawing.Point(5, 131);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(97, 18);
            this.lblOrderNumber.TabIndex = 12;
            this.lblOrderNumber.Text = "Номер заказа:";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrders.Location = new System.Drawing.Point(5, 155);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(98, 18);
            this.lblOrders.TabIndex = 13;
            this.lblOrders.Text = "Cостав заказа:";
            // 
            // lblSumWithDiscount
            // 
            this.lblSumWithDiscount.AutoSize = true;
            this.lblSumWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumWithDiscount.Location = new System.Drawing.Point(5, 285);
            this.lblSumWithDiscount.Name = "lblSumWithDiscount";
            this.lblSumWithDiscount.Size = new System.Drawing.Size(97, 18);
            this.lblSumWithDiscount.TabIndex = 14;
            this.lblSumWithDiscount.Text = "Сумма заказа:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(5, 309);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(101, 18);
            this.lblDiscountAmount.TabIndex = 15;
            this.lblDiscountAmount.Text = "Сумма скидки:";
            // 
            // lblPickUpPoint
            // 
            this.lblPickUpPoint.AutoSize = true;
            this.lblPickUpPoint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPickUpPoint.Location = new System.Drawing.Point(5, 335);
            this.lblPickUpPoint.Name = "lblPickUpPoint";
            this.lblPickUpPoint.Size = new System.Drawing.Size(101, 18);
            this.lblPickUpPoint.TabIndex = 16;
            this.lblPickUpPoint.Text = "Пункт выдачи:";
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderCode.Location = new System.Drawing.Point(4, 385);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(169, 23);
            this.lblOrderCode.TabIndex = 17;
            this.lblOrderCode.Text = "Код для получения:";
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.HorizontalScrollbar = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Location = new System.Drawing.Point(8, 173);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(316, 109);
            this.lbOrders.TabIndex = 18;
            // 
            // CouponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 417);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lblOrderCode);
            this.Controls.Add(this.lblPickUpPoint);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblSumWithDiscount);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CouponForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Талон";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblSumWithDiscount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblPickUpPoint;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.ListBox lbOrders;
    }
}