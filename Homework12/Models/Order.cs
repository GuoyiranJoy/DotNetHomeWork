using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12.Models
{
[Serializable]
public class Order : IComparable//实体类和业务逻辑类要分开
{
    public Client Client { set; get; }
    public string ClientId { set; get; }
    public int OrderId { set; get; }
    public List<OrderDetail> Details { set; get; } = new List<OrderDetail>();
    //private float _totalPrice;
    public double TotalPrice
    {

        // get
        // {
        //     double price = 0;
        //     foreach (OrderDetail d in Details)
        //     {
        //         price += d.Goods.price * d.Count;
        //     }
        //     return price;
        // }
        get => Details.Sum(item => item.Goods.price*item.Count);
    }

    public Order(Client purchaser, int orderID)
    {
        this.Client = purchaser;
        this.OrderId = orderID;
        this.ClientId=Client.Id;
    }
    public Order() { }


    public override bool Equals(object obj)
    {//有可能传null或另外类
        var order = obj as Order;
        return order != null && OrderId == order.OrderId;
    }

    public override int GetHashCode()
    {
        int hashCode = 1634732298;
        hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(Client);
        hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(Details);
        return hashCode;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (OrderDetail detail in Details)
        {

            sb.Append(detail);
        }
        return "orderID:" + OrderId + "\npurchaser:" + Client +
            "\norder details:" + sb + "\ntotal price is: " + TotalPrice;
    }

    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }


    //对商品明细list中的操作
    //向List＜OD＞中加OD
    public void addOD(OrderDetail od)
    {
        if (!Details.Contains(od))
        {
            Details.Add(od);
        }
        else
        {
            throw new OrderDetailExistException("该订单明细已经存在！");
        }
    }
    //向List＜OD＞中删OD
    public void removeOD(OrderDetail od)
    {
        if (Details.Contains(od))
        {
            Details.Remove(od);
        }
        else
        {
            throw new OrderDetailDoNotExistException("该订单明细不存在！");
        }

    }
    class OrderDetailDoNotExistException : ApplicationException
    {
        public OrderDetailDoNotExistException(string message) : base(message)
        {
        }
    }
    class OrderDetailExistException : ApplicationException
    {
        public OrderDetailExistException(string message) : base(message)
        {
        }
    }
}
}