using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosntructoers
{
   public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer() //default are others overload

        {
            //the list should be always initialzed 
            Orders = new List<Order>();
        }
        public Customer(int id)
            :this() //this will call the constructor that has no parameter, already iniitialed the list order
        {
            this.Id = id;
        }
        public Customer(int id,string name)
             :this(id) //this wil call the constructor with the id
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
