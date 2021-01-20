using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Administrator : Person
    {
        List<Person> person = new List<Person>();       
        public Administrator(string FirstName, string LastName) : 
            base(FirstName, LastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;            
        }           
        

        public void Add(Client client)
        {
            Console.WriteLine("На сколько дней Вы желаете остановить?");
            Console.Write("Колчество дней : ");
            int day = Convert.ToInt32(Console.ReadLine());
            decimal Summ = day * 30;
            if (client.blacklist != false && client.Cash > Summ && person.Count < 2)
            {
                person.Add(client);
                Print();
                client.Print();
            }
            else if (client.blacklist == false) { Console.WriteLine("Вы находитесь в чёрном списке!"); }
            else if (person.Count == 2) { Console.WriteLine("Все комнаты заняты!"); }
            else if (client.Cash < Summ) { Console.WriteLine("У Вас недостаточно денег"); }
        }


        public void Delete(Client client)
        {
            person.Remove(client);
        }

        public void Print()
        {
            Console.WriteLine("Вы заселены в отель!");
        }
    }
}
