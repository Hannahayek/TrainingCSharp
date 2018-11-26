using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs e)
        {
            Console.WriteLine("Mail Service:Sending an email..."+e.Video.Title);
        }
    }
}
