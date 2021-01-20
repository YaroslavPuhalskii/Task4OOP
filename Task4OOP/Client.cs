using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Client : Person
    {
        protected decimal cash;
        public bool blacklist;
        
        public Client(string FirstName, string LastName, decimal cash, bool BlackList) : base(FirstName,LastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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

        public void Print()
        {
            Console.WriteLine("ФИО : " + firstName + " " + lastName + cash);
        }
    }
}
