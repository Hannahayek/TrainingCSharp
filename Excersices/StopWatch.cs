using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning = false;

       public void Start()
        {

            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                Console.WriteLine("time started {0}", _startTime);
                _isRunning = true;
            }
            else
                throw new InvalidOperationException("started twice");

        }



        public void Stop()
        {

            if (_isRunning)
            {
                _endTime = DateTime.Now;
                Console.WriteLine("time started {0}", _endTime);
                _isRunning = false;
                GetDuration();
            }
        }

        private void GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Cannot get duration as stopwatch hasn't been started/stopped properly.");
            var timedif = _endTime - _startTime;
            Console.WriteLine("Time passed is: {0}", timedif.ToString());
          
        }

    }
}
