using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client("", "", -1.00m, true);
            //client.Print();
            
            Administrator admin = new Administrator("Administrator", "qwe");
            Client client = new Client("Tanya", "Ivanova", 300m, true);
            Client client2 = new Client("Katya", "Krupina", 300m, true);
            Client client3 = new Client("Tanya", "Ivanova", 300m, true);
            admin.Add(client);
            admin.Add(client2);
            admin.Delete(client2);
            admin.Add(client3);
            Console.ReadLine();
        }
    }
}
