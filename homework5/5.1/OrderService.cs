using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class OrderService
    {
        public List<Order> Orders { set; get; } = new List<Order>();
        //对订单的操作
        //增
        public void addOrder(Order o)
        {
            if (!Orders.Contains(o))
            {
                Orders.Add(o);
            }
                
        }
        //删
        public void removeOrder(Order o)
        {
            if (Orders.Contains(o))
            {
                Orders.Remove(o);
            }
            else
            {
                throw new OrderDoNotExistException("该订单不存在！");
            }
        }
        //改:改订单的客户、商品、以及商品明细
        public void changeOrder(Order o,Client latestClient,OrderDetail wantedOD, OrderDetail unwantedOD)
        {
            if (Orders.Contains(o))
            {
                addOD(o, wantedOD);
            removeOD(o, unwantedOD);
            o.Purchaser = latestClient;
            o.TotalPrice = o.calPrice();
            }
            else
            {
                throw new OrderDoNotExistException("该订单不存在！");
            }
            
        }
        //对商品明细list中的操作
        //向List＜OD＞中加OD
        public void addOD(Order o,OrderDetail od)
        {
            if (!o.Details.Contains(od))
            {
                o.Details.Add(od);
            }
        }
        //向向List＜OD＞中删OD
        public void removeOD(Order o, OrderDetail od)
        {
            if (o.Details.Contains(od))
            {
                o.Details.Remove(od);
            }
            else
            {
                throw new OrderDetailDoNotExistException("该订单明细不存在！");
            }
            
        }
        //按照订单号进行查询
        public void selectbyID(int id)
        {
            var selectedOrder = from s in Orders
                                where s.OrderID == id
                                orderby s.TotalPrice
                                select s;
            Console.WriteLine("select by id:"+id);
            Console.WriteLine((Order)selectedOrder);
            Console.WriteLine();
        }
        //按照商品名称进行查询
        public void selectbyName(string name)
        {

            var query = Orders.Where(o => o.Details.Where(d => d.goods.name == name).Count() > 0).OrderBy(s => s.TotalPrice);
            Console.WriteLine("select by name: " + name);
            foreach(Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
        }
        //按照客户进行查询
        public void selectbyClient(Client c)
        {
            var query = Orders.Where(s => s.Purchaser == c).OrderBy(s => s.TotalPrice);
            Console.WriteLine("select by client:" + c);
            foreach (Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
        }
        //按照订单金额进行查询
        public void selectbyPrice(int price)
        {
            var query = Orders.Where(s => s.TotalPrice == price);
            Console.WriteLine("select by price:" + price);
            foreach (Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
        }
        //对订单进行排序
        public void sortOrders()
        {
            Orders.Sort((o1, o2) => o1.OrderID - o2.OrderID);
        }
        //display orders
        public void displayOrders()
        {
            sortOrders();
            Console.WriteLine("现有的订单有：");
            foreach(Order o in Orders)
            {
Console.WriteLine(o);
                Console.WriteLine();
            }
            
        }


        class OrderDoNotExistException : ApplicationException
        {
           
            public OrderDoNotExistException(string message) : base(message)
            {
            }
        }
        class OrderDetailDoNotExistException : ApplicationException
        {
            public OrderDetailDoNotExistException(string message) : base(message)
            {
            }
        }
    }

}