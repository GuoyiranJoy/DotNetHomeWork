using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    [Serializable]
    public class Order :IComparable//实体类和业务逻辑类要分开
    {
        public Client Purchaser{ set; get; }
        public int OrderID { set; get; }
        public List<OrderDetail> Details { set; get; } = new List<OrderDetail>();
        //private float _totalPrice;
        public float TotalPrice
        {
           
            get
            {
                float price = 0;
                foreach (OrderDetail d in Details)
                            {
                    price += d.goods.price * d.count;
                            }
                            return price;
               //Details.Sum()
            }
        }
        //public int calPrice()
        //{
            
        //}

        public Order(Client purchaser, int orderID, List<OrderDetail> details)
        {
            this.Purchaser = purchaser;
            this.OrderID = orderID;
            this.Details = details;
        }
        public Order() { }
        
        
        public override bool Equals(object obj)
        {//有可能传null或另外类
            var order = obj as Order;
            return order!=null &&OrderID == order.OrderID ;
        }

        public override int GetHashCode()
        {
            int hashCode = 1634732298;
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(Purchaser);
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(Details);
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(OrderDetail detail in Details)
            {
                
                sb.Append(detail);
            }
            return "orderID:" + OrderID  + "\npurchaser:" + Purchaser +
                "\norder details:" + sb+"\ntotal price is: "+TotalPrice;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
