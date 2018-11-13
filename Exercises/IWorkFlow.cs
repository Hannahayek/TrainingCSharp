using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetTasks();
    }
}
