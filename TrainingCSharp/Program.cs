using System;
using TrainingCSharp.Math;

namespace TrainingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
      var john=new Person();

            john.FirstName = "Hanna";
            john.LastName = "hayek";
            john.introduce();

            Calculater calculater=new Calculater();

            var result = calculater.Add(10, 11);
        }
    }


    class ArraysProgram
    {
    static void Main(string[] args)
    {

        var numbers = new int[3];
        numbers[0] = 1;
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);

        var flags = new bool[3];
        flags[0] = true;
        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        var names=new string[3]{"jack","hanna","batal"};
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
            Console.Read();
    }

    }
}

















//Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);

            //int i = 1;
            //byte b = (byte)i;

            //var number = "12345";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);


          //  try
            //{
              //  var number = "12345";
              //  byte b = Convert.ToByte(number);
              //  Console.WriteLine(b);
 
           // }
//catch (Exception)
           // {

              //  Console.WriteLine("number not converted");
          //  }
           // Console.ReadLine();
      //  }



    //}

