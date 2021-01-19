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

        public void Cost() // Подсчёт Суммы за проживание в отеле
        {
            int day = Convert.ToInt32(Console.ReadLine());
            decimal Summ = day * 30;
            Console.WriteLine(Summ);
            RoomRent(Summ);
        }

        public void RoomRent(decimal Summ)
        {

            if (blacklist != false && cash > Summ)
            {
                this.cash -= Summ;
                Console.WriteLine(cash);
            }
            else { Console.WriteLine("У Вас недостаточно денег!"); }
        }


    }
}
