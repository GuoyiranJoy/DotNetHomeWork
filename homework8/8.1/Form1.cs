using _5._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1
{
    public partial class Form1 : Form
    {
        OrderService service = new OrderService();
        
        public Client JJ{
            get;
            set;}
        public Client Joy
        {
            get;
            set;
        }
        public OrderService Service
        {
            get => service;
            set
            {
                service = value;
            }
        }
        
        public string input { get; set; }
        public Form1()
        {
            InitializeComponent();

            //第一个订单，里面有红黑笔
            Joy = new Client("Joy", 18601967669, "whu");
            Goods pen = new Goods(1, "pen", 10);
            OrderDetail blackPen = new OrderDetail(1,pen, "", "black", 4);
            OrderDetail redPen = new OrderDetail(2,pen, "", "red", 3);
            Order pens = new Order(Joy, 1);
            pens.addOD(redPen);
            pens.addOD(blackPen);

            //第二个订单，里面有专辑和笔

            JJ = new Client("JJ", 888888, "TaiPei");
            Order cds = new Order(JJ, 2);
            Goods cd = new Goods(2, "cd", 50);
            OrderDetail cd1 = new OrderDetail(3,cd, "with signature", "幸存者", 1);
            OrderDetail cd2 = new OrderDetail(4,cd, "with signature", "like you do", 2);
            cds.addOD(cd1);
            cds.addOD(cd2);
            cds.addOD(blackPen);
            //将cds和pens两个订单加到service的Orders里面
            service.addOrder(cds);
            service.addOrder(pens);
            bdsOrders.DataSource = service.orders;
            queryInput.DataBindings.Add("Text", this, "input");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input == null || input == "")
            {
                bdsOrders.DataSource = service.orders;
                bdsDetails.DataSource = bdsOrders;
                bdsDetails.DataMember = "Details";
            }
            else
            {
                switch (searchListBox.SelectedIndex)
                {
                    case 0:
                        int intID=Convert.ToInt32(input);
                        bdsOrders.DataSource =service.selectbyID(intID);
                        break;
                    case 1:
                        bdsOrders.DataSource = service.selectbyGoodsName(input);
                        break;
                    case 2:
                        bdsOrders.DataSource = service.selectbyClient(input);
                        break;
                    case 3:
                        float price = Convert.ToSingle(input);
                        bdsOrders.DataSource = service.selectbyPrice(price);
                        break;
                }
                
            }
        }
        public void QueryAll()
        {
            bdsOrders.DataSource = service.orders;
            bdsOrders.ResetBindings(false);
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2(new Order(),Service,false);
            addForm.ShowDialog();
            QueryAll();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void change_btn_Click(object sender, EventArgs e)//修改订单
        {
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            Form2 editForm = new Form2(order, service, true);
            editForm.ShowDialog();
            QueryAll();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除！");
                return;
            }

            service.removeOrder(order.OrderID);
            QueryAll();
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                Service.Export(fileName);
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                Service.import(fileName);

            }
            QueryAll();
        }
    }
}
