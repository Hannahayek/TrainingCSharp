using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Composition
{



class Program
    {
        
       
        static void Main(string[] args)
        {

            var dbMigrator=new DbMigrator(new Logger());
            //or we pass as below way

            var logger=new Logger();

            var installer=new Installer(logger);
            dbMigrator.Migrate();
            installer.install();
            Console.ReadLine();
        }
    }

}