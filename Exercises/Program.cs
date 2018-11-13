using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{




    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Add(new UploadaVideo());
            workFlow.Add(new NotifyOwner());
            workFlow.Add(new CallWebService());
            workFlow.Add(new ChangeDataBaseStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);

            Console.ReadLine();

        }
    }
}
