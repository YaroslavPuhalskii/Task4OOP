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

            Administrator admin = new Administrator("", "", 201.00m, true);
            Administrator admin1 = new Administrator("", "", 201.00m, true);
            Administrator admin2 = new Administrator("", "", 201.00m, true);
            Administrator admin3 = new Administrator("", "", 201.00m, true);
            Administrator admin4 = new Administrator("", "", 201.00m, true);
            admin.Cost();
            admin1.Cost();
            admin2.Cost();
            admin3.Cost();
            admin4.Cost();
            Console.ReadLine();
        }
    }
}
