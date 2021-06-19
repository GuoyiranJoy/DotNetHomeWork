
namespace _10._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.startUrlBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.successCrawlBox = new System.Windows.Forms.TextBox();
            this.failedCrawlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "配置初始URL：";
            // 
            // startUrlBox
            // 
            this.startUrlBox.Font = new System.Drawing.Font("宋体", 13F);
            this.startUrlBox.Location = new System.Drawing.Point(292, 67);
            this.startUrlBox.Name = "startUrlBox";
            this.startUrlBox.Size = new System.Drawing.Size(432, 47);
            this.startUrlBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "启动爬虫";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 211);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.successCrawlBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.failedCrawlBox);
            this.splitContainer1.Size = new System.Drawing.Size(1299, 541);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 4;
            // 
            // successCrawlBox
            // 
            this.successCrawlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.successCrawlBox.Location = new System.Drawing.Point(0, 0);
            this.successCrawlBox.Multiline = true;
            this.successCrawlBox.Name = "successCrawlBox";
            this.successCrawlBox.Size = new System.Drawing.Size(659, 541);
            this.successCrawlBox.TabIndex = 0;
            // 
            // failedCrawlBox
            // 
            this.failedCrawlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.failedCrawlBox.Location = new System.Drawing.Point(0, 0);
            this.failedCrawlBox.Multiline = true;
            this.failedCrawlBox.Name = "failedCrawlBox";
            this.failedCrawlBox.Size = new System.Drawing.Size(636, 541);
            this.failedCrawlBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "成功页面";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "失败页面";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 752);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startUrlBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox startUrlBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox successCrawlBox;
        public System.Windows.Forms.TextBox failedCrawlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

