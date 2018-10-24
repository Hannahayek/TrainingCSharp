using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {

        public string Name { get; set; }
        //we define constructor because set is private in Birthdate 
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }
        public int Age
        {//this cant be like birthday auto implement,because it depends on birthdate
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}
