using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Excersise1
{
    public class SqlConnection: DbConnection    
    {
        public SqlConnection(string conn) : base(conn)
        {
        }

        public override void Openconnection()
        {
            if (_startTime.Second >= _timeOut.Seconds)
                throw new TimeoutException("oracle connection timeout");
            else
               Console.WriteLine("Sql connection opened");
        
        }

        public override void Closeconnection()
        {
            Console.WriteLine("Sql connection closed");
        }
    }
}
