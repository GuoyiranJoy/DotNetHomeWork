using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5._1;

namespace _8._1
{
    public partial class FormDetailEdit : Form
    {
        public OrderDetail Detail { get; set; }
        public FormDetailEdit()
        {
            InitializeComponent();
        }
        //构造方法
        public FormDetailEdit(OrderDetail detail) : this()
        {
            this.Detail = detail;
            this.bdsDetails.DataSource = detail;
            bdsGoods.Add(new Goods(1, "apple", 100.0));
            bdsGoods.Add(new Goods(2, "egg", 200.0));
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
