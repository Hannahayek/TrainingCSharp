using System.Collections.Generic;

namespace Fields
{
    public class Customers
    {
        public int Id;
        public string Name;
        //public List<Order> Orders; can be initialzed as below both works
        public readonly List<Order> Orders=new List<Order>();
   

        public Customers(int id)
        {
            this.Id = id;
        }

        public Customers(string name,int id)
            :this(id) //instead of initiliaze id we call customer(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            ////..../with read only  below will not be compiled
            //Orders=new List<Order>();
        }
    }
}