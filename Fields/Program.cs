using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer=new Customers(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //if we call the method Promote because it will initialise orders again all data will be lost
            //customers.Orders.count will be 0
            Console.WriteLine(customer.Orders.Count);
            Console.ReadLine();

        }
    }
}
