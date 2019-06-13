using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes.Ex_2_
{
    class Car
    {
        private string make;
        private string model;
        private string color;
        private double price;
        private bool isSold;
        private bool IsOnSale;

        //
        public Car(string make, string model, string color, double price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double Price { get { return price; } set { price = value; } }
        public bool IsSold { get { return isSold; } set { isSold = value; } }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }

        public void PutOnSale()
        {
            if (IsOnSale == false)
            {
                Price = Price * .9;
                IsOnSale = true;
            }
        }

        public void PrintInfo()
        {
            if (IsSold == true)
            {
                Console.WriteLine("SOLGT! Billen er en {0} {1} i farven {2}. Prisen er {3} DKK.", Make, Model, Color, Price);
            }
            if (IsSold == false)
            {
                Console.WriteLine("Billen er en {0} {1} i farven {2}. Prisen er {3} DKK.", Make, Model, Color, Price);
            }
        }
    }
}
