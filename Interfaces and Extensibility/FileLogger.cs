using System;
using System.IO;

namespace Interfaces_and_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {

           
          Log(message,"Error");
        }

        public void LogInfo(string message)
        {

            Log(message, "Info");
        }

        private void Log(string message, string messageType)
        {
            //we use using to dispose when done reading
            // we use this function to avoid repeatition 
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType +":"+ message);

            }

        }
        
    }
}