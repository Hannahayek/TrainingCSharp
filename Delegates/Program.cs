using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.load(path);
            var filters=new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);
            photo.Save();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
