using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Access_Modifiers
{

  
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer();
           // Amazon.RateCalculator calculator=new RateCalculator(); //cannot be accessed outside the assembly it is internal
        }
    }
}
