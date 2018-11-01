using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_and_Downcasting
{

    

    class Program
    {
        static void Main(string[] args)
        {   //up casting
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width); //value will be 100 because they refernce to same object

            //for example stram reader can have object from memory because derived from stream class
            //StreamReader streamReader = new StreamReader(new MemoryStream());

            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("string");
            ////better user generic list as below , because we can define type
            //var list1 = new List<int>();

            //downcasting


            Shape shape = new Text();
            Text text = (Text) shape;
            //text. with downcasting we can access values of base class 

            Console.ReadLine();



        }
    }
}
