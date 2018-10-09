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

        class StringDemo
        {
            static void Main(string[] args)
            {
                var FirstName = "Hanna";
                var LastName = "Hayek";

                var fullname = FirstName + " " + LastName;

                var Fullname = string.Format("My name is {0},{1} ", FirstName, LastName);
                var names = new string[3] {"hanna", "munir", "hayek"};

                var formatename = string.Join(",", names);

                var text = "hi John i am looking\nlook into the following paths\nc:\\folder1\\folder3";
                //to fix below issue with text and void // 
                var text1= @"hi John i am looking
look into the following paths
c:\folder1\folder3";
                //Console.WriteLine(text);
                Console.WriteLine(text1);
                Console.Read();
            }











        }


        class enumDemo
        {
            public enum ShippingMethod
            {
                RegularAirMail =1,
                RegisteredAirMail=2,
                Express =3
            }
            static void Main(string[] args)
            {
                //Convert string to in
                var method = ShippingMethod.Express;
                Console.WriteLine((int)method);


                var methodID = 3;
                //convert int to string 
                Console.WriteLine((ShippingMethod)methodID);
                Console.WriteLine(method.ToString());


                var methodName = "Express";

                //conver string to Enum 
                var shippingmethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

                Console.WriteLine(shippingmethod);
                Console.ReadLine();
            }
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

