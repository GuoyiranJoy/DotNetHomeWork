using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)//输入输出放这里
        {
            OrderService service = new OrderService();
            //第一个订单，里面有红黑笔
            Client Joy = new Client("Joy", 18601967669, "whu");
            Goods pen = new Goods(10, "pen", 01);
            OrderDetail blackPen = new OrderDetail(pen, "", "black", 4);
            OrderDetail redPen = new OrderDetail(pen, "", "red", 3);
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            orderDetails1.Add(redPen);
            orderDetails1.Add(blackPen);

            Order pens = new Order(Joy, 001, orderDetails1);

            //第二个订单，里面有专辑和笔
            Client JJ = new Client("JJ", 888888, "TaiPei");
            Goods cd = new Goods(50, "cd", 02);
            OrderDetail cd1 = new OrderDetail(cd, "with signature", "幸存者", 1);
            OrderDetail cd2 = new OrderDetail(cd, "with signature", "like you do", 2);
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            orderDetails2.Add(cd1);
            orderDetails2.Add(cd2);
            orderDetails2.Add(blackPen);
            Order cds = new Order(JJ, 002, orderDetails2);

            ////add空订单
            //service.addOrder(null);

            //将cds和pens两个订单加到service的Orders里面
            service.addOrder(cds);
            service.addOrder(pens);

            //根据商品名来查询订单
            service.selectbyName("pen");
            service.selectbyClient(JJ);
            service.selectbyPrice(190);
            //重复添加订单
            service.addOrder(cds);
            service.displayOrders();
            //删除OrderDetail
            service.removeOD(pens, redPen);
            service.displayOrders();
            ////删除订单
            //service.removeOrder(cds);
            //service.displayOrders();
            //错误删除订单
            //service.removeOrder(cds);

            //序列化为XML
            //service.Export("Orders1");
            //Console.WriteLine("\nDeserialized from Orders1.xml");
            //Console.WriteLine(File.ReadAllText("Orders1.xml"));
            //从XML中导入订单
            //service.import("Orders2");
            //Console.WriteLine(File.ReadAllText("Orders2.xml"));
            //service.displayOrders();
        }
    }
}
