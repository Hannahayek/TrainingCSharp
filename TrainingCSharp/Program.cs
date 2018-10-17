using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using TrainingCSharp.Math;

namespace TrainingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();

            john.FirstName = "Hanna";
            john.LastName = "hayek";
            john.introduce();

            Calculater calculater = new Calculater();

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

            var names = new string[3] {"jack", "hanna", "batal"};
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
                Console.WriteLine((int) method);


                var methodID = 3;
                //convert int to string 
                Console.WriteLine((ShippingMethod) methodID);
                Console.WriteLine(method.ToString());


                var methodName = "Express";

                //conver string to Enum 
                var shippingmethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

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
                Console.WriteLine(string.Format("a is {0}, b is {1}", a, b));


                var array1 = new int[3] {1, 2, 3};
                var array2 = array1;
                array2[0] = 0;
                Console.WriteLine(string.Format("array1[0]= {0} ,array2[0] = {1}", array1[0], array2[0]));
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

                var person = new Person {Age = 20};
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

                switch (season)
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

    
    class DemoForLoops
    {

        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }


            }

            for (var i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //var name = "hanna hayek";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);


            //}

            //foreach ( var charcter in name)
            //{
            //    Console.WriteLine(name);

            //}

            var number = new int[5] {1, 2, 3, 4, 5};


            foreach (var numbers in number)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadLine();


        }


    }

    class WhileLoops
    {

        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            //var i = 0;
            //while(i<=10)
            //{
            //    if (i % 2 == 0)

            //      Console.WriteLine(i);
            //    i++;


            //}




            //while(true)
            //{
            //    Console.Write("Enter your name: ");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    Console.WriteLine("@Echo: "+input);

            //}
            //same result as above but what continue
            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {

                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }


        }


    }


    class DemoRandomclass
    {

        static void Main(string[] args)
        {
            const int passwordlength = 10;
            //we created random password
            //first we create array that can hold 10 places, then store the random chars in the array/then convert array to string
            var random = new Random();
            var buffer = new char[passwordlength];
            for (int i = 0; i < passwordlength; i++)
                //'a' internal represents number
                buffer[i] = (char) ('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);





            Console.ReadLine();

        }


    }

  


    class DemoArrays53
    {

        static void Main(string[] args)
        {
            var numbers = new[] {1, 8, 4, 9, 6, 7};



            //length
            Console.WriteLine("length " + numbers.Length);

            //indexof

            var number = Array.IndexOf(numbers, 4);
            Console.WriteLine("index of 4 =" + number);

            //clear
            //0 starting index 2 length of elements
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effects of clear");
            foreach (var str in numbers)
            {
                Console.WriteLine(str);
            }

            //copy
            var another = new int[3];

            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effects of copy");
            foreach (var str in another)
            {
                Console.WriteLine(str);
            }

            //sort method

            Array.Sort(numbers);

            Console.WriteLine("Effects of sort");
            foreach (var str in numbers)
            {
                Console.WriteLine(str);
            }

            //reverse method

            Array.Reverse(numbers);

            Console.WriteLine("Effects of reverse");
            foreach (var str in numbers)
            {
                Console.WriteLine(str);
            }





            Console.ReadLine();
        }

    }


    class DemoLists55
    {

        static void Main(string[] args)
        {

            var numbers = new List<int>() {1, 2, 3, 4, 1};

            numbers.Add(1);
            //add array to the list
            numbers.AddRange(new int[3] {4, 6, 7});


            foreach (var number in numbers)
                Console.WriteLine(number);

            //    Console.WriteLine();
            //    Console.WriteLine("index of 1 is" + numbers.IndexOf(1));
            //Console.WriteLine("last index of 1 is" + numbers.LastIndexOf(1));
            //    Console.WriteLine("count is" + numbers.Count);


            //remove ,removes with number=4
            //numbers.Remove(4);
            //here we remove all numbers=4
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            //after removing number 1
            Console.WriteLine("removed number 4");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //clear everything
            numbers.Clear();


            Console.ReadLine();
        }


    }



    class DateTime59
    {

        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("Hours: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd"));






            Console.ReadLine();

        }

    }

    class TimeSpan60
        {

            static void Main(string[] args)
            {
               var timeSpan=new TimeSpan(1,2,3);
                var timeSpan1 = TimeSpan.FromHours(1);
                var end = DateTime.Now.AddMinutes(2);

                var start = DateTime.Now;

                var duration = end - start;
                Console.WriteLine("Duartion "+duration);
            //proporties
                Console.WriteLine(" Total Minutes :"+timeSpan.TotalMinutes);
                Console.WriteLine("Minutes :" + timeSpan.Minutes);

            //add  
                Console.WriteLine("Add Example "+ timeSpan.Add(TimeSpan.FromMinutes(8)));
                //subtract
                Console.WriteLine("Subtract Example " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));


                //tostring
                Console.WriteLine("To String" +timeSpan.ToString());

                //conversion from string

                Console.WriteLine("conversion from string"+ TimeSpan.Parse("01:02:03"));
            Console.ReadLine();
               
            }
        }


    class DemoString61
    {

        static void Main(string[] args)
        {
            var fullname = "Hanna Hayek ";
            Console.WriteLine("Trim '{0}'",fullname.Trim());
            Console.WriteLine("To Upper '{0}'", fullname.Trim().ToUpper());
            Console.WriteLine("To Lower '{0}'", fullname.Trim().ToLower());

            var index = fullname.IndexOf(' '); //get index of the space
            var firstname = fullname.Substring(0,index);
            var firstname1 = fullname.Substring(1);
            var secondname = fullname.Substring(index + 1); //from index +1 to the end
            Console.WriteLine("first name "+firstname);
            Console.WriteLine("second name " + secondname);
            Console.WriteLine("first name substring " + firstname1);
            //we can split also in this way, it will save it in array

            var names = fullname.Split(' ');
            Console.WriteLine("first name " + names[0]);
            Console.WriteLine("second name " + names[1]);

            Console.WriteLine(fullname.Replace("Hanna", "batal"));
            ////to remove the trim white space
            //if(String.IsNullOrEmpty(" ".Trim()))
            //    Console.WriteLine("invalid");
            //above method replaced with 
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var str = "25";

            
            var age = Convert.ToByte(str);
            Console.WriteLine("age is "+ age);

            var price = 29.95f;

            Console.WriteLine("Price converted "+price.ToString("C"));

            Console.ReadLine();

        }
       
    }



    class SummarisingText65
    {

        static void Main(string[] args)
        {
            var sentence = "this is going to be a really really rellay really really long text";

          

            var summary =StringUtility.SummarizeText(sentence,25);
            Console.WriteLine(summary);
            Console.ReadLine();


        }
                                          


    }



    class StringBuilder67
    {

        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder //can be done in this way also
                 .Append('-', 10)
                 .AppendLine()
                 .Append("Header")
                 .AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            builder.Replace('-', '+');
            Console.WriteLine(builder);
            builder.Remove(0, 10);
            Console.WriteLine(builder);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("first charcter"+builder[0]);
            Console.ReadLine();


        }



    }


    class DemoFileandFileInfo73
    {/// <summary>
    /// file provides static methods //fileinfo provides instances method
    /// </summary>
  

        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";         
            
            //true to overrride 
            File.Copy(@"C:\temp\mypic.jpg", @"d:\temp\mypic", true);
            File.Delete(path);

            if(File.Exists(path))
            {

            }

            var content = File.ReadAllText(path);
            var fileinfo = new FileInfo(path);

            fileinfo.CopyTo("destination");
            fileinfo.Delete();

            if (fileinfo.Exists)
            {
                ////
            }

        }



    }


    class DemoDirectoryandDirectoryInfo74
    {

        static void Main(string[] args)
        {
        //    Directory.CreateDirectory(@"c:\hanna");


            //"*.sln" to filter search we can get all files with .sln
            var files = Directory.GetFiles(@"C:\Users\v-hahaye\source\repos\TrainingCSharp", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }


            var directoryInfo = new DirectoryInfo("");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            Console.ReadLine();
        }

    }




    class DemoPath75
    {

        static void Main(string[] args)
        {
            var path = @"C:\Users\v-hahaye\source\repos\TrainingCSharp\TrainingCSharp.sln";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("String way "+extension);
            Console.WriteLine("Path static method way "+Path.GetExtension(path));
            Console.WriteLine("FileName: "+Path.GetFileName(path));
            Console.WriteLine("FileName: without extenstion " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Get Directory " + Path.GetDirectoryName(path));
            Console.ReadLine();
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

