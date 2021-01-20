using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Person
    {
        protected string firstName;
        protected string lastName;

        public Person(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
