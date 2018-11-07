using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Excersise1
{
   public abstract class DbConnection
    {
        public String _connection { get; set; }
        public readonly TimeSpan _timeout = TimeSpan.FromSeconds(40);

        public DbConnection(String conn)
        {
            this._connection = conn;
            if (String.IsNullOrWhiteSpace(conn))
                throw new ArgumentNullException("connections is null");
        }

        public abstract void Openconnection();
        public abstract void Closeconnection();



    }
}
