using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiers
{

    public class Person
    {// with private should start with _
        //methords should be Camelcase 
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //to access private birth date we use methods
            var person=new Person();
           person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadLine();


        }
    }
}
