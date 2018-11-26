using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {

        public void OnVideoEncoded(object source,EventArgs args)
        {
            Console.WriteLine("Message Service : sending Text massage");
        }
    }
}
