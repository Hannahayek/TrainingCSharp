using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Excersices
{


    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            stopwatch.Start();
            Thread.Sleep(2000);

            stopwatch.Stop();

            stopwatch.Start();
            Thread.Sleep(3000);

            stopwatch.Stop();


            stopwatch.Start();
            Thread.Sleep(5000);

            stopwatch.Stop();
            Console.ReadLine();
        }
        }
    }


