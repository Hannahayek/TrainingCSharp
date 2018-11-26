using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1-Define a delegate
        //2- Define an event based on that delegate
        //3- Raise the event
        // args any additional data we want to pass

        //1-Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //we suppose here the video succesffully encoded
            OnVideoEncoded();
        }

        //3- Raise the event//should be protected and virtual void
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);

        }

    }
}
