using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes.Ex_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(40,60,20);

            box.PrintInfo();

            Console.ReadKey();
        }
    }
}
