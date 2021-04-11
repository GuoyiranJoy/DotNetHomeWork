using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.Tests
{
    [TestClass()]

    public class OrderServiceTests
    {
        OrderService service = new OrderService();
        Order order1;
        Order order2;
        Client Joy;
        Client JJ;
        OrderDetail redPen;

        [TestInitialize()]
        public void init()
        {
            //第一个订单，里面有红黑笔
            Joy = new Client("Joy", 18601967669, "whu");
            Goods pen = new Goods(10, "pen", 01);
            OrderDetail blackPen = new OrderDetail(pen, "", "black", 4);
            redPen = new OrderDetail(pen, "", "red", 3);
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            orderDetails1.Add(redPen);
            orderDetails1.Add(blackPen);
            order1 = new Order(Joy, 001, orderDetails1);
            service.addOrder(order1);

            //第二个订单，里面有专辑和笔
            JJ = new Client("JJ", 888888, "TaiPei");
            Goods cd = new Goods(50, "cd", 02);
            OrderDetail cd1 = new OrderDetail(cd, "with signature", "幸存者", 1);
            OrderDetail cd2 = new OrderDetail(cd, "with signature", "like you do", 2);
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            orderDetails2.Add(cd1);
            orderDetails2.Add(cd2);
            orderDetails2.Add(blackPen);
            order2 = new Order(JJ, 002, orderDetails2);

        }
        [TestMethod()]
        public void addOrderTest()
        {
            
            service.addOrder(order2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void removeOrderTest()
        {
            service.removeOrder(1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void changeOrderTest()
        {
            Goods pencil = new Goods(1, "pencil", 3);
            OrderDetail od1 = new OrderDetail(pencil, "", "black", 2);
            List<OrderDetail> od1s = new List<OrderDetail>();
            od1s.Add(od1);
            Order newOrder1 = new Order(Joy, 1, od1s);
            service.changeOrder(newOrder1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void addODTest()
        {
            Goods pencil = new Goods(1, "pencil", 3);
            OrderDetail od1 = new OrderDetail(pencil, "", "black", 2);
            service.addOD(order1, od1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void removeODTest()
        {
            service.removeOD(order1, redPen);
            //Assert.Fail();
        }

        [TestMethod()]
        public void selectbyIDTest()
        {
            service.addOrder(order2);
            Assert.AreEqual(order1,service.selectbyID(1));
        }

        [TestMethod()]
        public void selectbyNameTest()
        {
            service.addOrder(order2);
            Assert.IsTrue(service.selectbyName("cd").ElementAt(0) == order2);
            
            
            
        }

        [TestMethod()]
        public void selectbyClientTest()
        {
            service.addOrder(order2);
            Assert.IsTrue(service.selectbyClient(JJ).ElementAt(0) == order2);
        }

        [TestMethod()]
        public void selectbyPriceTest()
        {
            service.addOrder(order2);
            Assert.IsTrue(service.selectbyPrice(70).ElementAt(0) == order1);
        }

        [TestMethod()]
        public void sortOrdersTest()
        {
            service.addOrder(order2);
            service.sortOrders();

            Assert.AreEqual(order1, service.orders[0]);
        }

        [TestMethod()]
        public void displayOrdersTest()
        {
            service.addOrder(order2);
            service.displayOrders();
        }

        [TestMethod()]
        public void ExportTest()
        {
            service.Export("Orders1");
        }

        [TestMethod()]
        public void importTest()
        {
            service.import("Orders2");
        }
    }
}