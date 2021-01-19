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
        int i = 1;

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
            Console.WriteLine("На сколько дней Вы желаете остановить?");
            Console.Write("Колчество дней : ");
            int day = Convert.ToInt32(Console.ReadLine());
            decimal Summ = day * 30;
            Console.WriteLine(Summ);
            RoomRent(Summ);
        }

        public void RoomRent(decimal Summ)
        {            
            if (blacklist != false && cash > Summ && room.Count<3)
            {                
                this.cash -= Summ;
                room.Add(i);
                Console.WriteLine(cash);
                i++;
            }
            else 
            {
                Console.WriteLine("У Вас недостаточно денег! Попробуем снова?");
                string yn = Convert.ToString(Console.ReadLine());
                switch (yn)
                {
                    case "yes":
                        Cost();
                        break;
                    case "no":
                        Console.WriteLine("До новых встреч!");
                        break;
                }
            }
        }


    }
}
