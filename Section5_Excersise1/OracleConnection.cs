using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Excersise1
{
   public class OracleConnection :DbConnection
    {
        public OracleConnection(string conn) : base(conn)
        {
        }

        public override void Openconnection()
        {
            if(_timeout>TimeSpan.FromSeconds(40))
               throw new TimeoutException("oracle connection timeout");

            else
            Console.WriteLine("oracle connection opened");
        }

        public override void Closeconnection()
        {
            Console.WriteLine("oracle connection closed");
        }
    }
}
