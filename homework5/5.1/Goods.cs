using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Goods
    {
        public int price { set; get; }
        public string name { set; get; }
        public int goodsID { set; get; }


        public Goods(int price, string name, int goodsID)
        {
            this.price = price;
            this.name = name;
            this.goodsID = goodsID;
        }

        public override string ToString()
        {
            return "Goods' name is:" + name + "\nID is:" + goodsID
                + "\nprice is :" + price;
        }
    }
}
