using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Models
{
    public class OrderService
    {//foreach只读，不能修改数据

        //readonly public List<Order> orders= new List<Order>();
        //对订单的操作
        //增
        OrderContext dbContext;

        public OrderService(OrderContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Order> getAllOrders()
        {
            return dbContext.Orders.Include(o => o.Details).ThenInclude(d => d.Goods).Include("Client").
              ToList<Order>();
        }

        public void addOrder(Order o)
        {

            FixOrder(o);
            dbContext.Entry(o).State = EntityState.Added;
            dbContext.SaveChanges();


        }
        //删:通过ID

        public void removeOrder(int id)
        {
            var order = dbContext.Orders.Include("Details").SingleOrDefault(o => o.OrderId == id);
            if (order == null) return;
            dbContext.OrderDetails.RemoveRange(order.Details);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();

        }
        //改:改订单
        public void changeOrder(Order o)
        {
            removeOrder(o.OrderId);//把旧的订单删去（订单号不变），再加入这个改过的订单
            addOrder(o);


        }

        //查询一定要返回结果！！！！！！！不要打印
        //按照订单号进行查询
        public Order selectbyID(int id)
        {
            return dbContext.Orders.Include(o => o.Details).ThenInclude(d => d.Goods).Include("Client")
              .SingleOrDefault(o => o.OrderId == id);


        }
        //按照商品名称进行查询
        public List<Order> selectbyGoodsName(string name)
        {

            var query = dbContext.Orders.Include(o => o.Details).ThenInclude(d => d.Goods).Include("Client")
                .Where(order => order.Details.Any(item => item.Goods.name == name));
            return query.ToList();

        }
        //按照客户进行查询
        public List<Order> selectbyClient(string cname)
        {

            return dbContext.Orders.Include(o => o.Details).ThenInclude(d => d.Goods).Include("Client")
      .Where(order => order.Client.name == cname).ToList();
            //.OrderBy(o => o.TotalPrice)

        }
        //按照订单金额进行查询
        public IEnumerable<Order> selectbyPrice(float price)
        {

            return dbContext.Orders.Include(o => o.Details).ThenInclude(d => d.Goods).Include("Client")
            .Where(order => order.Details.Sum(d => d.Count * d.Goods.price) > price)
            .ToList();

        }

        //将所有订单序列化为XML文档
        public void Export(string name)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(name + ".xml", FileMode.Create))
            {
                xs.Serialize(fs, getAllOrders());
            }
        }
        //从XML文件中导入订单
        public void import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fs);
                temp.ForEach(order =>
                {
                    if (dbContext.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
                    {
                            //FixOrder(order);
                            dbContext.Orders.Add(order);
                    }
                });
                dbContext.SaveChanges();

            }
        }
        private static void FixOrder(Order newOrder)
        {
            newOrder.ClientId = newOrder.Client.Id;
            newOrder.Client = null;
            newOrder.Details.ForEach(d =>
            {
                d.GoodsId = d.Goods.GoodsId;
                // d.Goods = null;
            });
        }

        // class OrderDoNotExistException : ApplicationException
        // {

        //     public OrderDoNotExistException(string message) : base(message)
        //     {
        //     }
        // }

        class NullOrderException : ApplicationException
        {
            public NullOrderException(string message) : base(message)
            {
            }
        }
    }

}