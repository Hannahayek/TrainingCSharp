using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class WorkFlow :IWorkFlow
    {
        private readonly IList<IActivity> _activity;

        public WorkFlow()
        {
            _activity = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activity.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activity.Remove(activity);
        }


        public IEnumerable<IActivity> GetTasks()
        {
            return _activity;
        }
    }
}
