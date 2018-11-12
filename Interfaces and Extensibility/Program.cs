using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Extensibility
{
    class Program

    {
        static void Main(string[] args)
        {

            //  var dbMigrator=new DbMigrator(new ConsoleLogger());
            //also we can call as below with interface
            var dbMigrator = new DbMigrator(new FileLogger("e:\\log.txt"));
            dbMigrator.Migrate();

            Console.ReadLine();
        }
    }
}
