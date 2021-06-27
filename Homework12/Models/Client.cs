using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework12.Models
{

    public class Client
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { set; get; }
        public string name { set; get; }
        public long telephone { set; get; }
        public string address { set; get; }
        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   name == client.name &&
                   telephone == client.telephone &&
                   address == client.address;
        }

        public override int GetHashCode()
        {
            int hashCode = 173051432;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + telephone.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            return hashCode;
        }

        public Client()
        {   
            //Id = Guid.NewGuid().ToString();
        }

        public Client(string Id,string name, long telephone, string address)
        {
            this.Id = Id;
            this.name = name;
            this.telephone = telephone;
            this.address = address;
        }
    }
}