using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new ArrayList();

            list.Add(1); //boxing here will happen, because it is int number, not object,arraylist takes object
            list.Add("Hanna");
            list.Add(DateTime.Today);


            //to avoid boxing we use generic list

            var anotherlist = new List<int>(); ///use this for a way unboxing
            anotherlist.Add(1);

           

        }
    }
}
