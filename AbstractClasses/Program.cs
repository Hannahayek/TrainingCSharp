using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {


    }
    
    class Program
    {
        static void Main(string[] args)
        {

            var circle=new Circle();
            circle.Draw();


            var rectangle=new Rectangle();

            rectangle.Draw();

            //before the abstract, because we didnt override the draw method in rectangle , it will not compile 
        }
    }
}
