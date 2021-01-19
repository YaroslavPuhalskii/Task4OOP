using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Client
    {
        protected string firstName;
        protected string lastName;
        protected decimal cash;
        public bool blacklist;
        



        public Client(string FirstName, string LastName, decimal cash, bool BlackList)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.Cash = cash;
            this.blacklist = BlackList;
        }

        public bool BlackList
        {
            get { return blacklist; }
            set { blacklist = value; }
        }

        public decimal Cash
        {
            get { return cash; }
            set { if (value < 0.0m) { cash = 0.0m; }
                else { cash = value; }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public void Print()
        {
            Console.WriteLine("ФИО : " + firstName + " " + lastName + cash);
        }
    }
}
