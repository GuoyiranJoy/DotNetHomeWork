using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    public class Client
    {
        public string name { set; get; }
        public long telephone { set; get; }
        public string address { set; get; }
        public override string ToString()
        {
            return "Client's name is " + name + "\ntelephone number is "
                + telephone + "\naddress is " + address;
        }

        public Client()
        {
        }

        public Client(string name, long telephone, string address)
        {
            this.name = name;
            this.telephone = telephone;
            this.address = address;
        }
    }
}
