using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {//in general abstract will force the implementation for override main class method 
        //in case not added the override method, they program will not compile
        static void Main(string[] args)
        {   // we cant initiate the main abstract class when using abstract,can be used as common behaviour
           // var shape = new Shape();



            var circle=new Circle();
            circle.Draw();


            var rectangle=new Rectangle();

            rectangle.Draw();

            //before the abstract, because we didnt override the draw method in rectangle , it will not compile 
        }
    }
}
