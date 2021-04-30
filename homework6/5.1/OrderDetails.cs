using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    public class OrderDetail
    {
        public Goods goods { set; get; }//一个订单明细只能有一份货物
        public string remark { set; get; }//订单备注
        public string specification { set; get; }//商品规格
        public int count { set; get; }

        public OrderDetail(Goods goods, string remark, string specification, int count)
        {
            this.goods = goods;
            this.remark = remark;
            this.specification = specification;
            this.count = count;
        }

        public OrderDetail()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Goods>.Default.Equals(goods, detail.goods) &&
                   remark == detail.remark &&
                   specification == detail.specification &&
                   count == detail.count;
        }

        public override int GetHashCode()
        {
            int hashCode = -1940719184;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(remark);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(specification);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "\n"+goods + "\nspecification: " + specification + "\nremark:" + remark+"\ncount:"+count;
        }
    }
}
