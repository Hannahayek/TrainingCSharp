using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class UploadaVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("uploading a videos");
        }
    }


    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encode");
        }
    }


    public class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("your video started proccessing ");
        }
    }



    public class ChangeDataBaseStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("video proccessing in Database ");
        }
    }
}
