using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var proccessor=new PhotoProcessor();
            var filters=new PhotoFilters();
           Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            //so we can add and method later and add it to delegate 
            filterHandler += RemoveRedEyeFilter;
            proccessor.Process("photo.jpg",filterHandler);
            Console.ReadLine();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("apply red eye filter");
        }
    }
}
