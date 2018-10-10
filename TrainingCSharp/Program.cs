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

            var names = new string[3] { "jack", "hanna", "batal" };
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
                var names = new string[3] { "hanna", "munir", "hayek" };

                var formatename = string.Join(",", names);

                var text = "hi John i am looking\nlook into the following paths\nc:\\folder1\\folder3";
                //to fix below issue with text and void // 
                var text1 = @"hi John i am looking
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
                RegularAirMail = 1,
                RegisteredAirMail = 2,
                Express = 3
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

        class ReferenceTypesDemo
        {
            static void Main(string[] args)
            {

                var a = 10;
                var b = a;
                b++;
                // 0 and 1 are place holders
                Console.WriteLine(string.Format("a is {0}, b is {1}",a,b));


                var array1 = new int[3] { 1, 2, 3 };
                var array2 = array1;
                array2[0] = 0;
                Console.WriteLine(string.Format("array1[0]= {0} ,array2[0] = {1}",array1[0],array2[0]));
                Console.ReadLine();
            }

        }


        public class Person
        {
            public int Age;
        }
        class ReferenceTypesDemo2
        {

            static void Main(string[] args)
            {

                var number = 1;
                Increment(number);
                //out put will be 1, 2 number are in different memory locations
                Console.WriteLine(number);

                var person = new Person { Age = 20 };
                MakeOld(person);
                Console.WriteLine(person.Age);
               
                Console.ReadLine();
            }
            public static void Increment(int number)
            {
                number += 10;
            }

            public static void MakeOld(Person person)
            {
                person.Age += 10;

            }

        }


class DemoIfElse
        {

            static void Main(string[] args)
            {


                //int hour = 10;

                //if (hour > 0 && hour < 12)
                //{
                //    Console.WriteLine("It is Morning");
                //}

                //else if (hour >= 12 && hour < 18)
                //{
                //    Console.WriteLine("it is afternoon");
                //}


                //else
                //{
                //    Console.WriteLine("it is evening");

                //}


                bool isGoldCustomer = true;

                //float price;

                //if (isGoldCustomer)
                //    price = 19.5f;

                //else
                //    price = 29.95f;
                // above if can be done as below

                float price = (isGoldCustomer) ? 19.5f : 29.95f;
                Console.WriteLine(price);
                Console.ReadLine();





            }

            }



        class DemoSwitch
        {
            public enum Season
            {
                Spring,
                Summer,
                Winter,
                Autumn
            }
            static void Main(string[] args)
            {

                var season = Season.Autumn;

                switch(season)
                {
                    case Season.Autumn:
                        Console.WriteLine("it is autumn very sweet season");
                        break;

                    case Season.Summer:
                        Console.WriteLine("go swim, what you are waiting for");
                        break;


                    case Season.Spring:
                    case Season.Winter:
                        Console.WriteLine("Cold or Cool weather");
                        break;

                    default:
                        Console.WriteLine("not understanding");
                        break;

                }
               




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

