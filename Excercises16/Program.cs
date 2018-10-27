using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Excercises16
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            Console.WriteLine("Please Press Enter to start...");

            ConsoleKeyInfo input;

            do
            {
                input = Console.ReadKey();

                if (input.Key.Equals(ConsoleKey.Enter))
                {

                    try
                    {
                        stopwatch.Start();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }

                }
                else if (input.Key.Equals(ConsoleKey.Spacebar))
                {
                    stopwatch.Stop();

                }


                Console.ReadLine();

            } while (input.Key.Equals(ConsoleKey.Escape));


            Console.ReadKey();
        }
    }
  
}
