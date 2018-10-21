using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

       
        static void Main(string[] args)
        {//below will crash
         //  var number = int.Parse("abc");
         //how to do with out modifier
            int number;
            var result=int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");

            Console.ReadLine();
        }


        static void UseParams()
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.ReadLine();
        }
        static void usePoint()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(null);

                Console.WriteLine("Point is at {0},{1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0},{1} after calling second move method", point.X, point.Y);
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("An Expected error happened");
                Console.ReadLine();
            }
        }
    }
}
