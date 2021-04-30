
namespace _8._1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmId_btn = new System.Windows.Forms.Button();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.removeOD_btn = new System.Windows.Forms.Button();
            this.addOD_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmId_btn);
            this.groupBox1.Controls.Add(this.IdInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clientBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // confirmId_btn
            // 
            this.confirmId_btn.Location = new System.Drawing.Point(324, 54);
            this.confirmId_btn.Name = "confirmId_btn";
            this.confirmId_btn.Size = new System.Drawing.Size(89, 48);
            this.confirmId_btn.TabIndex = 4;
            this.confirmId_btn.Text = "确定";
            this.confirmId_btn.UseVisualStyleBackColor = true;
            this.confirmId_btn.Click += new System.EventHandler(this.confirm_btn);
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(209, 60);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(63, 35);
            this.IdInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户";
            // 
            // clientBox
            // 
            this.clientBox.FormattingEnabled = true;
            this.clientBox.ItemHeight = 24;
            this.clientBox.Items.AddRange(new object[] {
            "Joy",
            "JJ"});
            this.clientBox.Location = new System.Drawing.Point(209, 118);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(120, 28);
            this.clientBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.save_btn);
            this.groupBox2.Controls.Add(this.removeOD_btn);
            this.groupBox2.Controls.Add(this.addOD_btn);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 635);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(1032, 554);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(138, 39);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "保存订单";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // removeOD_btn
            // 
            this.removeOD_btn.Location = new System.Drawing.Point(253, 554);
            this.removeOD_btn.Name = "removeOD_btn";
            this.removeOD_btn.Size = new System.Drawing.Size(133, 39);
            this.removeOD_btn.TabIndex = 2;
            this.removeOD_btn.Text = "删除明细";
            this.removeOD_btn.UseVisualStyleBackColor = true;
            // 
            // addOD_btn
            // 
            this.addOD_btn.Location = new System.Drawing.Point(53, 554);
            this.addOD_btn.Name = "addOD_btn";
            this.addOD_btn.Size = new System.Drawing.Size(137, 39);
            this.addOD_btn.TabIndex = 1;
            this.addOD_btn.Text = "添加明细";
            this.addOD_btn.UseVisualStyleBackColor = true;
            this.addOD_btn.Click += new System.EventHandler(this.addOD_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goods,
            this.Remark,
            this.Specification,
            this.Count,
            this.TotalPrice});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Goods
            // 
            this.Goods.HeaderText = "Goods";
            this.Goods.MinimumWidth = 10;
            this.Goods.Name = "Goods";
            this.Goods.Width = 200;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.MinimumWidth = 10;
            this.Remark.Name = "Remark";
            this.Remark.Width = 200;
            // 
            // Specification
            // 
            this.Specification.HeaderText = "Specification";
            this.Specification.MinimumWidth = 10;
            this.Specification.Name = "Specification";
            this.Specification.Width = 200;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 10;
            this.Count.Name = "Count";
            this.Count.Width = 200;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 10;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 200;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 847);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "添加/修改订单";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox clientBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button removeOD_btn;
        private System.Windows.Forms.Button addOD_btn;
        private System.Windows.Forms.Button confirmId_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}