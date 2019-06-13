using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes.Ex_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bil1 = new Car("Dacia", "Logan", "Beige", 170000, false);
            Car bil2 = new Car("Toyota", "Yaris", "Rød", 89000, true);
            Car bil3 = new Car("Honda", "Civic", "Hvid", 199000, false);


            bil1.PrintInfo();
            Console.WriteLine();
            bil2.PrintInfo();
            Console.WriteLine();
            bil3.PrintInfo();

            Console.ReadKey();
        }
    }
}
