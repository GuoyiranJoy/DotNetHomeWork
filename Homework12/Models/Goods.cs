using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12.Models
{
    public class Goods
    {
        public double price { set; get; }
        public string name { set; get; }
        public int GoodsId { set; get; }

        public Goods()
        {
        }

        public Goods( int goodsID, string name,double price)
        {
            this.price = price;
            this.name = name;
            this.GoodsId = goodsID;
        }

        public override string ToString()
        {
            return name;
        }
    }
}