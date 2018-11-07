using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("SQL");
            var oracle = new OracleConnection("Oracle246");
            var command1 = new DbCommand(sql, "SELECT name, job, to_char(salary,'$9999.99') AS 'Salary' FROM emp;");
            var command2 = new DbCommand(oracle, "SELECT name, age, height FROM profle;");
            command1.Execute();
            Console.WriteLine("\n");
            command2.Execute();
            Console.ReadLine();
        }
    }
}
