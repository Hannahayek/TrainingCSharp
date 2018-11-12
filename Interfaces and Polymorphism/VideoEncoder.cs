using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {

        private readonly MailService _mailService;
        public VideoEncoder()
        {
            _mailService = new MailService();
        }


        public void Encode (Video video)
        {
            //video encode logic

            _mailService.Send(new Mail());
        }
    }
}
