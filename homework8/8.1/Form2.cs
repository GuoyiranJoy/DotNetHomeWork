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
    public partial class Form2 : Form
    {
        public string id { get; set; }
        public Order f2order { get; set; }
        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();

            IdInput.DataBindings.Add("Text", this, "id");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void confirm_btn(object sender, EventArgs e)
        {
            if (id != null && id != "")
            {
                bool isNum = Int32.TryParse(id, out int idNum);
                if (!isNum)
                {
                    throw new InputNotNumException("请输入正确的订单号");
                }
                Client c=new Client();
                if (clientBox.SelectedIndex == 0)
                {
                    c = f1.Joy;
                }
                if (clientBox.SelectedIndex == 1)
                {
                    c = f1.JJ;
                }
                f2order = new Order(c, idNum);//按照输入创建订单
                if(f1.Service.orders.Where(s => s.OrderID == idNum).Any())//修改已有的订单
                {
                    f1.Service.changeOrder(f2order);
                    bindingSource1.DataSource= f1.Service.selectbyID(idNum);//显示已有的OD
                }
                else//创建新订单
                {
                    f1.Service.addOrder(f2order);
                }
            }
        }

        private void addOD_btn_Click(object sender, EventArgs e)
        {
            //dataGridView1.
            //OrderDetail od = new OrderDetail()
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
