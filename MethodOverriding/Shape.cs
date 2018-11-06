using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }


    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw rectangle");
        }
    }


    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw triangle");
        }
    }



    public class Shape
    {

        public int Witdh { get; set; }
        public int Height { get; set; }

        public Position Position { get; set; }

      


        //we user virtual word to enable overiding and using in other classes
        public virtual void  Draw()
        {


        }

    }
}
