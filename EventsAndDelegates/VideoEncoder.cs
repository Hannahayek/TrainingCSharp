using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventsArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1-Define a delegate
        //2- Define an event based on that delegate
        //3- Raise the event
        // args any additional data we want to pass

        //1-Define a delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventsArgs args);

        //2-Define an event based on that delegate
        // public event VideoEncodedEventHandler VideoEncoded;

        //instead of step 1 & 2 we can use built in function as below

        public EventHandler<VideoEventsArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //we suppose here the video succesffully encoded
            OnVideoEncoded(video);
        }

        //3- Raise the event//should be protected and virtual void
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this,new VideoEventsArgs { Video=video});

        }

    }
}
