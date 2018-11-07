using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Excersise1
{
   public abstract class DbConnection
    {
        public string _connection { get; private set; }
        public readonly TimeSpan _timeOut = TimeSpan.FromSeconds(40);
        public DateTime _startTime { get; set; }

        public DbConnection(string conn)
        {
            _connection = conn;
            if (String.IsNullOrWhiteSpace(conn))
                throw new ArgumentNullException("connections is null");
        }

        public abstract void Openconnection();
        public abstract void Closeconnection();



    }
}
