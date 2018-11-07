using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Section5_Excersise1
{
   public class DbCommand
    {
        public DbConnection _connection { get; private set; }
        public string _command { get; private set; }
        public DbCommand(DbConnection conn,string sqlcommand)
        {
            if (conn == null)
            {

                throw new NullReferenceException("connection empty");
            }
            else
            {
                _connection = conn;
                if (string.IsNullOrWhiteSpace(sqlcommand))
                    throw new ArgumentNullException("command is empty");
                else
                {
                    _command = sqlcommand;
                }
            }
        }

        public void Execute()
        {
            if(string.IsNullOrWhiteSpace(_command))
                throw new NullReferenceException();

            else
            {
                _connection.Openconnection();
                Console.WriteLine("exuecting command "+ _command);
                _connection.Closeconnection();
            }
        }

    }
  
}
