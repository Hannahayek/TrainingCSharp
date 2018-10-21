using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   public class Point
    {
        public int X;
        public int Y;

        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x,int y)
        {

            this.X = x;
            this.Y = y;
        }

        public void Move(Point newlocation)
        {
            //this.X = newlocation.X;
            //this.Y = newlocation.Y;
            //instead of above we can do as below

            if (newlocation == null)
                throw new ArgumentNullException("location");
            
            Move(newlocation.X, newlocation.Y);

        }
    }
}
