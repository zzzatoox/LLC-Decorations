namespace llc_decorations.View
{
    partial class ProductListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pbProductPhoto = new System.Windows.Forms.PictureBox();
            this.tpnlProductInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductMaker = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDescribe = new System.Windows.Forms.Label();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductManufacturer = new System.Windows.Forms.TextBox();
            this.tbProductCost = new System.Windows.Forms.TextBox();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.mtbDiscount = new System.Windows.Forms.MaskedTextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountProducts = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.lblSearchProducts = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКЗаказуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).BeginInit();
            this.tpnlProductInfo.SuspendLayout();
            this.pnlDiscount.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlBottom.ColumnCount = 3;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.52347F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.47653F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.pnlBottom.Controls.Add(this.pbProductPhoto, 0, 0);
            this.pnlBottom.Controls.Add(this.tpnlProductInfo, 1, 0);
            this.pnlBottom.Controls.Add(this.pnlDiscount, 2, 0);
            this.pnlBottom.Location = new System.Drawing.Point(1, 480);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.Size = new System.Drawing.Size(934, 163);
            this.pnlBottom.TabIndex = 0;
            // 
            // pbProductPhoto
            // 
            this.pbProductPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbProductPhoto.Image")));
            this.pbProductPhoto.Location = new System.Drawing.Point(3, 3);
            this.pbProductPhoto.Name = "pbProductPhoto";
            this.pbProductPhoto.Size = new System.Drawing.Size(307, 157);
            this.pbProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductPhoto.TabIndex = 0;
            this.pbProductPhoto.TabStop = false;
            // 
            // tpnlProductInfo
            // 
            this.tpnlProductInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tpnlProductInfo.ColumnCount = 2;
            this.tpnlProductInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlProductInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tpnlProductInfo.Controls.Add(this.lblProductName, 0, 0);
            this.tpnlProductInfo.Controls.Add(this.lblProductMaker, 0, 2);
            this.tpnlProductInfo.Controls.Add(this.lblProductPrice, 0, 3);
            this.tpnlProductInfo.Controls.Add(this.lblProductDescribe, 0, 1);
            this.tpnlProductInfo.Controls.Add(this.tbProductDescription, 1, 1);
            this.tpnlProductInfo.Controls.Add(this.tbProductName, 1, 0);
            this.tpnlProductInfo.Controls.Add(this.tbProductManufacturer, 1, 2);
            this.tpnlProductInfo.Controls.Add(this.tbProductCost, 1, 3);
            this.tpnlProductInfo.Location = new System.Drawing.Point(316, 3);
            this.tpnlProductInfo.Name = "tpnlProductInfo";
            this.tpnlProductInfo.RowCount = 4;
            this.tpnlProductInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tpnlProductInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tpnlProductInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpnlProductInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tpnlProductInfo.Size = new System.Drawing.Size(384, 157);
            this.tpnlProductInfo.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(5, 2);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(108, 38);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Наименование товара";
            // 
            // lblProductMaker
            // 
            this.lblProductMaker.AutoSize = true;
            this.lblProductMaker.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductMaker.Location = new System.Drawing.Point(5, 88);
            this.lblProductMaker.Name = "lblProductMaker";
            this.lblProductMaker.Size = new System.Drawing.Size(111, 18);
            this.lblProductMaker.TabIndex = 2;
            this.lblProductMaker.Text = "Производитель:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductPrice.Location = new System.Drawing.Point(5, 123);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(43, 18);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Цена:";
            // 
            // lblProductDescribe
            // 
            this.lblProductDescribe.AutoSize = true;
            this.lblProductDescribe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductDescribe.Location = new System.Drawing.Point(5, 42);
            this.lblProductDescribe.Name = "lblProductDescribe";
            this.lblProductDescribe.Size = new System.Drawing.Size(116, 18);
            this.lblProductDescribe.TabIndex = 1;
            this.lblProductDescribe.Text = "Описание товара";
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(137, 45);
            this.tbProductDescription.Multiline = true;
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.ReadOnly = true;
            this.tbProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProductDescription.Size = new System.Drawing.Size(214, 38);
            this.tbProductDescription.TabIndex = 5;
            this.tbProductDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(137, 5);
            this.tbProductName.Multiline = true;
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(214, 32);
            this.tbProductName.TabIndex = 4;
            this.tbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
            // 
            // tbProductManufacturer
            // 
            this.tbProductManufacturer.Location = new System.Drawing.Point(137, 91);
            this.tbProductManufacturer.Name = "tbProductManufacturer";
            this.tbProductManufacturer.ReadOnly = true;
            this.tbProductManufacturer.Size = new System.Drawing.Size(214, 23);
            this.tbProductManufacturer.TabIndex = 8;
            this.tbProductManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
            // 
            // tbProductCost
            // 
            this.tbProductCost.Location = new System.Drawing.Point(137, 126);
            this.tbProductCost.Name = "tbProductCost";
            this.tbProductCost.ReadOnly = true;
            this.tbProductCost.Size = new System.Drawing.Size(214, 23);
            this.tbProductCost.TabIndex = 7;
            this.tbProductCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiscount.Controls.Add(this.mtbDiscount);
            this.pnlDiscount.Controls.Add(this.lblPercent);
            this.pnlDiscount.Location = new System.Drawing.Point(706, 3);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(225, 157);
            this.pnlDiscount.TabIndex = 2;
            // 
            // mtbDiscount
            // 
            this.mtbDiscount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbDiscount.Location = new System.Drawing.Point(90, 55);
            this.mtbDiscount.Mask = "00";
            this.mtbDiscount.Name = "mtbDiscount";
            this.mtbDiscount.Size = new System.Drawing.Size(35, 37);
            this.mtbDiscount.TabIndex = 1;
            this.mtbDiscount.ValidatingType = typeof(int);
            this.mtbDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercent.Location = new System.Drawing.Point(121, 60);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(30, 29);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "%";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9%",
            "10-14%",
            "15% и более "});
            this.cbFilter.Location = new System.Drawing.Point(462, 33);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 23);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(228, 23);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(662, 76);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(258, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "12345678912345678912345678912345678";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountProducts
            // 
            this.lblCountProducts.AutoSize = true;
            this.lblCountProducts.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountProducts.Location = new System.Drawing.Point(149, 73);
            this.lblCountProducts.Name = "lblCountProducts";
            this.lblCountProducts.Size = new System.Drawing.Size(92, 18);
            this.lblCountProducts.TabIndex = 4;
            this.lblCountProducts.Text = "Товаров \" / \"";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterBy.Location = new System.Drawing.Point(459, 9);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 18);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Фильтрация";
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Location = new System.Drawing.Point(293, 37);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(115, 19);
            this.rbAscending.TabIndex = 6;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "По возрастанию";
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(293, 62);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(101, 19);
            this.rbDescending.TabIndex = 7;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "По убыванию";
            this.rbDescending.UseVisualStyleBackColor = true;
            this.rbDescending.CheckedChanged += new System.EventHandler(this.rbDescending_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnCheckOrder);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblSortBy);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.lblFilterBy);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.rbDescending);
            this.panel1.Controls.Add(this.lblSearchProducts);
            this.panel1.Controls.Add(this.rbAscending);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.lblCountProducts);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 135);
            this.panel1.TabIndex = 8;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAdd.Location = new System.Drawing.Point(365, 104);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(154, 23);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "ДОБАВИТЬ ТОВАР";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Location = new System.Drawing.Point(685, 104);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(154, 23);
            this.btnOrders.TabIndex = 11;
            this.btnOrders.Text = "ПЕРЕЙТИ К ЗАКАЗАМ";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCheckOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOrder.Location = new System.Drawing.Point(525, 104);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(154, 23);
            this.btnCheckOrder.TabIndex = 10;
            this.btnCheckOrder.Text = "ПРОСМОТР КОРЗИНЫ";
            this.btnCheckOrder.UseVisualStyleBackColor = false;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(845, 104);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortBy.Location = new System.Drawing.Point(290, 9);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(139, 18);
            this.lblSortBy.TabIndex = 8;
            this.lblSortBy.Text = "Сортировать по цене";
            // 
            // lblSearchProducts
            // 
            this.lblSearchProducts.AutoSize = true;
            this.lblSearchProducts.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchProducts.Location = new System.Drawing.Point(11, 9);
            this.lblSearchProducts.Name = "lblSearchProducts";
            this.lblSearchProducts.Size = new System.Drawing.Size(103, 18);
            this.lblSearchProducts.TabIndex = 6;
            this.lblSearchProducts.Text = "Поиск товаров";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(859, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(1, 135);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(931, 347);
            this.dgvMain.TabIndex = 9;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКЗаказуToolStripMenuItem,
            this.удалитьТоварToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            // 
            // добавитьКЗаказуToolStripMenuItem
            // 
            this.добавитьКЗаказуToolStripMenuItem.Name = "добавитьКЗаказуToolStripMenuItem";
            this.добавитьКЗаказуToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.добавитьКЗаказуToolStripMenuItem.Text = "Добавить к заказу";
            this.добавитьКЗаказуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКЗаказуToolStripMenuItem_Click);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 644);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductListForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).EndInit();
            this.tpnlProductInfo.ResumeLayout(false);
            this.tpnlProductInfo.PerformLayout();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlDiscount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private System.Windows.Forms.PictureBox pbProductPhoto;
        private System.Windows.Forms.TableLayoutPanel tpnlProductInfo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductMaker;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDescribe;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountProducts;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Label lblSearchProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox tbProductCost;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductManufacturer;
        private System.Windows.Forms.MaskedTextBox mtbDiscount;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКЗаказуToolStripMenuItem;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.ToolStripMenuItem удалитьТоварToolStripMenuItem;
    }
}