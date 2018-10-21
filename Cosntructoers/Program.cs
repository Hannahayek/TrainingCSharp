using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosntructoers
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Hanna");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
    }
}
