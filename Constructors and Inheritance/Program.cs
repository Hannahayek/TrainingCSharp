using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_and_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car=new Car(); //will execute the construcor of car and vheicle
            var car=new Car("baba");
            Console.ReadLine();
        }
    }
}
