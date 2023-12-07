namespace llc_decorations.View
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbPickUpPoints = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblPickUpPoint = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblSumDiscountAmount = new System.Windows.Forms.Label();
            this.lblSumWithDiscount = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlLeft.Controls.Add(this.pbLogo);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(115, 462);
            this.pnlLeft.TabIndex = 9;
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
            // cbPickUpPoints
            // 
            this.cbPickUpPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPickUpPoints.FormattingEnabled = true;
            this.cbPickUpPoints.Location = new System.Drawing.Point(126, 376);
            this.cbPickUpPoints.Name = "cbPickUpPoints";
            this.cbPickUpPoints.Size = new System.Drawing.Size(280, 23);
            this.cbPickUpPoints.TabIndex = 10;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnOrder.Location = new System.Drawing.Point(721, 414);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(217, 36);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "ОФОРМИТЬ ЗАКАЗ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Location = new System.Drawing.Point(126, 74);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(492, 199);
            this.lbOrders.TabIndex = 12;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblName.Location = new System.Drawing.Point(121, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 26);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "ФИО:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblCart.Location = new System.Drawing.Point(121, 45);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(169, 26);
            this.lblCart.TabIndex = 14;
            this.lblCart.Text = "Корзина товаров:";
            // 
            // lblPickUpPoint
            // 
            this.lblPickUpPoint.AutoSize = true;
            this.lblPickUpPoint.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblPickUpPoint.Location = new System.Drawing.Point(121, 347);
            this.lblPickUpPoint.Name = "lblPickUpPoint";
            this.lblPickUpPoint.Size = new System.Drawing.Size(237, 26);
            this.lblPickUpPoint.TabIndex = 15;
            this.lblPickUpPoint.Text = "Выберите пункт выдачи:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(479, 283);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(139, 27);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "УБРАТЬ ТОВАР";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblPhoto.Location = new System.Drawing.Point(628, 45);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(193, 26);
            this.lblPhoto.TabIndex = 17;
            this.lblPhoto.Text = "Фотография товара:";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(633, 74);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(305, 199);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 18;
            this.pbPhoto.TabStop = false;
            // 
            // lblSumDiscountAmount
            // 
            this.lblSumDiscountAmount.AutoSize = true;
            this.lblSumDiscountAmount.Location = new System.Drawing.Point(123, 308);
            this.lblSumDiscountAmount.Name = "lblSumDiscountAmount";
            this.lblSumDiscountAmount.Size = new System.Drawing.Size(85, 15);
            this.lblSumDiscountAmount.TabIndex = 19;
            this.lblSumDiscountAmount.Text = "Сумма скидки:";
            // 
            // lblSumWithDiscount
            // 
            this.lblSumWithDiscount.AutoSize = true;
            this.lblSumWithDiscount.Location = new System.Drawing.Point(123, 283);
            this.lblSumWithDiscount.Name = "lblSumWithDiscount";
            this.lblSumWithDiscount.Size = new System.Drawing.Size(97, 15);
            this.lblSumWithDiscount.TabIndex = 19;
            this.lblSumWithDiscount.Text = "Итоговая сумма:";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 462);
            this.Controls.Add(this.lblSumWithDiscount);
            this.Controls.Add(this.lblSumDiscountAmount);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.lblPickUpPoint);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbPickUpPoints);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbPickUpPoints;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblPickUpPoint;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblSumDiscountAmount;
        private System.Windows.Forms.Label lblSumWithDiscount;
    }
}