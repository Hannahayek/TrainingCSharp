using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
   public class Canvas
    {

        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes )
            {
                switch (shape.Type)
                {

                    case ShapeType.Circle:
                        Console.WriteLine("draw a circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("draw rectangle");
                        break;
 
                }
            }

        }

    }
}
