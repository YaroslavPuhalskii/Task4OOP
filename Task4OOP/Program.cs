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

            Administrator admin = new Administrator("", "", -1.00m, true);
            admin.Cost();
            Console.ReadLine();
        }
    }
}
