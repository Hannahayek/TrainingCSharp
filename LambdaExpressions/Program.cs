using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda for square method
            //args => expression
            //number => number*number;
            //() =>
            //x =>
            // (x,y,z)=>
            Func<int, int> square = number => number * number;

            Console.WriteLine("method output "+Square(5));
            Console.WriteLine("Lamdamethod " + square(5));

            //make a method takes number and multiply by factor
            const int factor = 5;

            Func<int, int> multupler = n => n * factor;
            var result = multupler(10);
            Console.WriteLine("multiper ="+result);


            Console.ReadLine();
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
