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
        public Order CurrentOrder { get; set; }
        public OrderService OrderService { set; get; }
        bool isModify { set; get; }
        Form1 f1 = new Form1();

        public Form2(Order f2order, OrderService orderService, bool model)
        {
            this.CurrentOrder = f2order;
            OrderService = orderService;
            isModify = model; 
            InitializeComponent();

            //IdInput.DataBindings.Add("Text", this, "id");
            IdInput.Enabled = !isModify;
            bindingSource_client.Add(f1.JJ);
            bindingSource_client.Add(f1.Joy);

            bdsOrders.DataSource = CurrentOrder;
            IdInput.Enabled = !model;//新建则有OrderId编辑框
            //如果是新建的话,绑定一下新选择的client
            if (!model)
            {
                CurrentOrder.Purchaser = (Client)bindingSource_client.Current;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        //private void confirm_btn(object sender, EventArgs e)
        //{
        //    if (id != null && id != "")
        //    {
        //        bool isNum = Int32.TryParse(id, out int idNum);
        //        if (!isNum)
        //        {
        //            throw new InputNotNumException("请输入正确的订单号");
        //        }
        //        Client c=new Client();
        //        if (clientBox.SelectedIndex == 0)
        //        {
        //            c = f1.Joy;
        //        }
        //        if (clientBox.SelectedIndex == 1)
        //        {
        //            c = f1.JJ;
        //        }
        //        CurrentOrder = new Order(c, idNum);//按照输入创建订单
        //        if(f1.Service.orders.Where(s => s.OrderID == idNum).Any())//修改已有的订单
        //        {
        //            f1.Service.changeOrder(CurrentOrder);
        //            bindingSource1.DataSource= f1.Service.selectbyID(idNum);//显示已有的OD
        //        }
        //        else//创建新订单
        //        {
        //            f1.Service.addOrder(CurrentOrder);
        //        }
        //    }
        //}

        private void addOD_btn_Click(object sender, EventArgs e)
        {
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {//当关闭了对话框时
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItemEdit.Detail.Index = index;
                    CurrentOrder.addOD(formItemEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //TODO 加上订单合法性验证
            try
            {
                if (this.isModify)
                {
                    OrderService.changeOrder(CurrentOrder);
                }
                else
                {
                    OrderService.addOrder(CurrentOrder);
                }
               
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

        private void removeOD_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail od = bdsDetails.Current as OrderDetail;
                if (od == null)
                {
                    MessageBox.Show("请选择一个订单项进行删除");
                    return;
                }
                CurrentOrder.removeOD(od);
                bdsDetails.ResetBindings(false);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail od = bdsDetails.Current as OrderDetail;
            if (od == null)
            {
                MessageBox.Show("请选择一个订单项进行修改！");
                return;
            }
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
        //当关闭了对话框时
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    bdsDetails.ResetBindings(false);
                }
            
        }
    }
}
