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
            Goods pen = new Goods(10, "pen", 01);
            OrderDetail blackPen = new OrderDetail(pen, "", "black", 4);
            OrderDetail redPen = new OrderDetail(pen, "", "red", 3);
            Order pens = new Order(Joy, 001);
            pens.addOD(redPen);
            pens.addOD(blackPen);

            //第二个订单，里面有专辑和笔

            JJ = new Client("JJ", 888888, "TaiPei");
            Order cds = new Order(JJ, 002);
            Goods cd = new Goods(50, "cd", 02);
            OrderDetail cd1 = new OrderDetail(cd, "with signature", "幸存者", 1);
            OrderDetail cd2 = new OrderDetail(cd, "with signature", "like you do", 2);
            cds.addOD(cd1);
            cds.addOD(cd2);
            cds.addOD(blackPen);
            //将cds和pens两个订单加到service的Orders里面
            service.addOrder(cds);
            service.addOrder(pens);
            OrderbindingSource1.DataSource = service.orders;
            queryInput.DataBindings.Add("Text", this, "input");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input == null || input == "")
            {
                OrderbindingSource1.DataSource = service.orders;
                orderDetailbindingSource1.DataSource = OrderbindingSource1;
                orderDetailbindingSource1.DataMember = "Details";
            }
            else
            {
                switch (searchListBox.SelectedIndex)
                {
                    case 0:
                        int intID=Convert.ToInt32(input);
                        OrderbindingSource1.DataSource =service.selectbyID(intID);
                        break;
                    case 1:
                        OrderbindingSource1.DataSource = service.selectbyGoodsName(input);
                        break;
                    case 2:
                        OrderbindingSource1.DataSource = service.selectbyClient(input);
                        break;
                    case 3:
                        float price = Convert.ToSingle(input);
                        OrderbindingSource1.DataSource = service.selectbyPrice(price);
                        break;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
        }
    }
}
