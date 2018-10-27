using System;
using System.Security.AccessControl;
using System.Security.Policy;

namespace Excercises16
{
    public class StopWatch
    {
        private DateTime _starttime;
        private DateTime _stoptime;
        private bool _isrunning =false;
        public TimeSpan Timedif()
        {
            return  _starttime-_stoptime;
        }

        public StopWatch()
        {
            
        }
        public void Start()
        {
            if (!_isrunning == true)
            {
                _starttime=DateTime.Now;
                Console.WriteLine("Start Time {0}="+_starttime);
                Console.WriteLine("press space to stop");
                _isrunning = true;

            }
            else
            {
                throw new InvalidOperationException("WARNING : Stopwatch is running... Please Spacebar to stop.");
            }
        }

        public void Stop()
        {
           _stoptime=DateTime.Now;
            Console.WriteLine("time stop at {0} "+_stoptime);
            Console.WriteLine("total time dif is " +Timedif().TotalMilliseconds.ToString());
            Console.WriteLine("press enter to continue");
            _isrunning = false;
        }
    }
}