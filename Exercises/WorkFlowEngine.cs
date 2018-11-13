using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
   public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach(var task in workFlow.GetTasks())
            {
                task.Execute();
            }
        }

    }
}
