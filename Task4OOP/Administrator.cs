using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Administrator : Client
    {
        List<int> room = new List<int>();

        public Administrator(string FirstName, string LastName, decimal Cash, bool BlackList) : 
            base(FirstName, LastName, Cash, BlackList)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Cash = cash;
            this.BlackList = blacklist;
        }


        public void RoomRent()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            decimal Summ = day * 30;
            Console.WriteLine(Summ);

            if (blacklist != false && cash > Summ)
            {

            }
            else Console.WriteLine("У Вас недостаточно денег!");
        }


    }
}
