using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _5._1
{
    public class OrderService
    {//foreach只读，不能修改数据

       readonly public List<Order> orders= new List<Order>();
        //public List<Order> Orders { set; get; } = new List<Order>();
        //对订单的操作
        //增
        public void addOrder(Order o)
        {
            if (o == null)
            {
                throw new NullOrderException("请勿传入空对象");
            }
            if (!orders.Contains(o))
            {
                orders.Add(o);
            }
                
        }
        //删:通过ID
      
        public void removeOrder(int id)
        {
            if (orders.Any(o=>o.OrderID==id))
            {
                orders.RemoveAll(o => o.OrderID == id);
            }
            else
            {
                throw new OrderDoNotExistException("该订单不存在！");
            }
        }
        //改:改订单
        public void changeOrder(Order o)
        {
            if (orders.Contains(o))
            {
                removeOrder(o.OrderID);
                addOrder(o);
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
        //查询一定要返回结果！！！！！！！不要打印
        //按照订单号进行查询
        public Order selectbyID(int id)
        {
            var selectedOrder = orders.Where(s => s.OrderID == id).FirstOrDefault();
                //from s in orders
                //                where s.OrderID == id
                //                orderby s.TotalPrice
                //                select s;
            Console.WriteLine("select by id:"+id);
            Console.WriteLine(selectedOrder);
            Console.WriteLine();
            return selectedOrder;
        }
        //按照商品名称进行查询
        public IOrderedEnumerable<Order> selectbyName(string name)
        {
            //也可以用Exists()或Any()
            var query = orders.Where(o => o.Details.Where(d => d.goods.name == name).Count() > 0).OrderBy(s => s.TotalPrice);
            var query1 = orders.Where(o => o.Details.Any(d => d.goods.name == name));
            Console.WriteLine("select by name: " + name);
            foreach(Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            return query;
        }
        //按照客户进行查询
        public IOrderedEnumerable<Order> selectbyClient(Client c)
        {
            var query = orders.Where(s => s.Purchaser == c).OrderBy(s => s.TotalPrice);
            Console.WriteLine("select by client:" + c);
            foreach (Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            return query;
        }
        //按照订单金额进行查询
        public IEnumerable<Order> selectbyPrice(int price)
        {
            var query = orders.Where(s => s.TotalPrice == price);
            Console.WriteLine("select by price:" + price);
            foreach (Order o in query)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            return query;
        }
        //对订单进行排序
        public void sortOrders()
        {
            orders.Sort((o1, o2) => o1.OrderID - o2.OrderID);
        }
        //display orders
        public void displayOrders()
        {
            sortOrders();
            Console.WriteLine("现有的订单有：");
            foreach(Order o in orders)
            {
                Console.WriteLine(o);
                Console.WriteLine();
            }
            
        }
        //将所有订单序列化为XML文档
        public void Export(string name)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(name + ".xml", FileMode.Create))
            {
                xs.Serialize(fs, this.orders);
            }
        }
        //从XML文件中导入订单
        public void import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Open))
            {
                List<Order> newOrders = (List<Order>)xmlSerializer.Deserialize(fs);
                //orders.Union(newOrders);不知道为什么这个没用
                foreach (Order o in newOrders)
                {
                    orders.Add(o);
                }
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
        class NullOrderException : ApplicationException
        {
            public NullOrderException(string message) : base(message)
            {
            }
        }
    }

}