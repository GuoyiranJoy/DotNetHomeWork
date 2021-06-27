using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12.Models
{
public class OrderDetail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } //序号
    public Goods Goods { set; get; }//一个订单明细只能有一份货物
    public int GoodsId { set; get; }
    public string Remark { set; get; }//订单备注
    public string Specification { set; get; }//商品规格
    public int Count { set; get; }
    public int OrderId{set;get;}
    public OrderDetail()
    {
        Id = Guid.NewGuid().ToString();

    }

    public OrderDetail(string Index, Goods goods, string remark, string specification, int count)
    {
        this.Id = Index;
        this.Goods = goods;
        this.Remark = remark;
        this.Specification = specification;
        this.Count = count;
    }


    public override bool Equals(object obj)
    {
        return obj is OrderDetail detail &&
               EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods) &&
               Remark == detail.Remark &&
               Specification == detail.Specification &&
               Count == detail.Count;
    }

    public override int GetHashCode()
    {
        int hashCode = -1940719184;
        hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Remark);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Specification);
        hashCode = hashCode * -1521134295 + Count.GetHashCode();
        return hashCode;
    }

    public override string ToString()
    {
        return "\n" + Id + "\r" + Goods + "\nspecification: " + Specification + "\nremark:" + Remark + "\ncount:" + Count;
    }

}
}