using System;

namespace TrainingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);

            //int i = 1;
            //byte b = (byte)i;

            //var number = "12345";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);


            try
            {
                var number = "12345";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);



              
            }
            catch (Exception)
            {

                Console.WriteLine("number not converted");
            }
            Console.ReadLine();
        }
    }
}
