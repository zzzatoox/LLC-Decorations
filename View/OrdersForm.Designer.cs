namespace llc_decorations.View
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilterReset = new System.Windows.Forms.Button();
            this.btnCheckProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подробноОЗаказеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnChangeDeliviryDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(0, 104);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(934, 419);
            this.dgvMain.TabIndex = 11;
            this.dgvMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnFilterReset);
            this.panel1.Controls.Add(this.btnCheckProducts);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblSortBy);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.lblFilterBy);
            this.panel1.Controls.Add(this.rbDescending);
            this.panel1.Controls.Add(this.rbAscending);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 111);
            this.panel1.TabIndex = 10;
            // 
            // btnFilterReset
            // 
            this.btnFilterReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnFilterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterReset.Location = new System.Drawing.Point(184, 72);
            this.btnFilterReset.Name = "btnFilterReset";
            this.btnFilterReset.Size = new System.Drawing.Size(140, 23);
            this.btnFilterReset.TabIndex = 11;
            this.btnFilterReset.Text = "СБРОСИТЬ ФИЛЬТРЫ";
            this.btnFilterReset.UseVisualStyleBackColor = false;
            this.btnFilterReset.Click += new System.EventHandler(this.btnFilterReset_Click);
            // 
            // btnCheckProducts
            // 
            this.btnCheckProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCheckProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckProducts.Location = new System.Drawing.Point(684, 76);
            this.btnCheckProducts.Name = "btnCheckProducts";
            this.btnCheckProducts.Size = new System.Drawing.Size(154, 23);
            this.btnCheckProducts.TabIndex = 10;
            this.btnCheckProducts.Text = "ПРОСМОТР ТОВАРОВ";
            this.btnCheckProducts.UseVisualStyleBackColor = false;
            this.btnCheckProducts.Click += new System.EventHandler(this.btnCheckProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(844, 76);
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
            this.lblSortBy.Location = new System.Drawing.Point(12, 19);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(139, 18);
            this.lblSortBy.TabIndex = 8;
            this.lblSortBy.Text = "Сортировать по цене";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более "});
            this.cbFilter.Location = new System.Drawing.Point(184, 43);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 23);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterBy.Location = new System.Drawing.Point(181, 19);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 18);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Фильтрация";
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(15, 72);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(101, 19);
            this.rbDescending.TabIndex = 7;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "По убыванию";
            this.rbDescending.UseVisualStyleBackColor = true;
            this.rbDescending.CheckedChanged += new System.EventHandler(this.rbDescending_CheckedChanged);
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Location = new System.Drawing.Point(15, 47);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(115, 19);
            this.rbAscending.TabIndex = 6;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "По возрастанию";
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подробноОЗаказеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 26);
            // 
            // подробноОЗаказеToolStripMenuItem
            // 
            this.подробноОЗаказеToolStripMenuItem.Name = "подробноОЗаказеToolStripMenuItem";
            this.подробноОЗаказеToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.подробноОЗаказеToolStripMenuItem.Text = "Подробно о заказе";
            this.подробноОЗаказеToolStripMenuItem.Click += new System.EventHandler(this.подробноОЗаказеToolStripMenuItem_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Location = new System.Drawing.Point(765, 529);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(156, 50);
            this.btnChangeStatus.TabIndex = 11;
            this.btnChangeStatus.Text = "ИЗМЕНИТЬ СТАТУС ЗАКАЗА";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnChangeDeliviryDate
            // 
            this.btnChangeDeliviryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnChangeDeliviryDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDeliviryDate.Location = new System.Drawing.Point(603, 529);
            this.btnChangeDeliviryDate.Name = "btnChangeDeliviryDate";
            this.btnChangeDeliviryDate.Size = new System.Drawing.Size(156, 50);
            this.btnChangeDeliviryDate.TabIndex = 12;
            this.btnChangeDeliviryDate.Text = "ИЗМЕНИТЬ ДАТУ ДОСТАВКИ";
            this.btnChangeDeliviryDate.UseVisualStyleBackColor = false;
            this.btnChangeDeliviryDate.Click += new System.EventHandler(this.btnChangeDeliviryDate_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnChangeDeliviryDate);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подробноОЗаказеToolStripMenuItem;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnChangeDeliviryDate;
        private System.Windows.Forms.Button btnFilterReset;
    }
}