using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
  
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1984, 12, 6));
            //this will be not compiled when add private set age
            //person.Birthdate=new DateTime(1984, 12, 6);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    }
}
