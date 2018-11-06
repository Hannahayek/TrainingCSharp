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
            {//will user draw from rectancle or circle depends on the shape
              shape.Draw();
            }

        }

    }
}
