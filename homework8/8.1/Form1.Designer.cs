
namespace _8._1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.change_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.query_btn = new System.Windows.Forms.Button();
            this.queryInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsOrders = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.change_btn);
            this.panel1.Controls.Add(this.import_btn);
            this.panel1.Controls.Add(this.export_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.searchListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.query_btn);
            this.panel1.Controls.Add(this.queryInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1642, 183);
            this.panel1.TabIndex = 0;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(220, 93);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(119, 63);
            this.change_btn.TabIndex = 10;
            this.change_btn.Text = "修改订单";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(811, 93);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(130, 63);
            this.import_btn.TabIndex = 9;
            this.import_btn.Text = "导入订单";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(609, 93);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(130, 63);
            this.export_btn.TabIndex = 8;
            this.export_btn.Text = "导出订单";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(407, 93);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(130, 63);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "删除订单";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 24;
            this.searchListBox.Items.AddRange(new object[] {
            "订单号",
            "商品名",
            "客户名",
            "总金额"});
            this.searchListBox.Location = new System.Drawing.Point(89, 33);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(120, 28);
            this.searchListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "按";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(37, 93);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(119, 63);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "添加订单";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // query_btn
            // 
            this.query_btn.Location = new System.Drawing.Point(452, 23);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(75, 44);
            this.query_btn.TabIndex = 2;
            this.query_btn.Text = "查询";
            this.query_btn.UseVisualStyleBackColor = true;
            this.query_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // queryInput
            // 
            this.queryInput.Location = new System.Drawing.Point(304, 30);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(132, 35);
            this.queryInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询：";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 769);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1642, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1642, 586);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.goodsDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bdsDetails;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(1059, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(583, 586);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.purchaserDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bdsOrders;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdsDetails
            // 
            this.bdsDetails.DataMember = "Details";
            this.bdsDetails.DataSource = this.bdsOrders;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // bdsOrders
            // 
            this.bdsOrders.DataSource = typeof(_5._1.Order);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 200;
            // 
            // purchaserDataGridViewTextBoxColumn1
            // 
            this.purchaserDataGridViewTextBoxColumn1.DataPropertyName = "Purchaser";
            this.purchaserDataGridViewTextBoxColumn1.HeaderText = "Purchaser";
            this.purchaserDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.purchaserDataGridViewTextBoxColumn1.Name = "purchaserDataGridViewTextBoxColumn1";
            this.purchaserDataGridViewTextBoxColumn1.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 200;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(_5._1.Order);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(_5._1.Order);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 10;
            this.Index.Name = "Index";
            this.Index.Width = 200;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 200;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 200;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.Width = 200;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 869);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button query_btn;
        private System.Windows.Forms.TextBox queryInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsOrders;
        private System.Windows.Forms.BindingSource bdsDetails;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}

