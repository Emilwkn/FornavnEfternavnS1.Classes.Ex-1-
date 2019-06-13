using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavnS1.Classes.Ex_1_
{
    class Box
    {
        private double height;
        private double length;
        private double width;
        private double volume;
        private double surface;

        public Box(double width, double height, double length)
        {
            Height = height;
            Lenght = length;
            Width = width;
        }

        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Lenght { get { return length; } set { length = value; } }
        public double Volume { get { return volume; } private set { volume = value; } }
        public double Surface { get { return surface; } private set { surface = value; } }

        public void CalculateVolume()
        {
            Volume = Height * Lenght * Width;
        }
        public void CalculateSurface()
        {
            Surface = (Lenght * Width * 2) + (Lenght * Height * 2) + (Width * Height * 2);
        }
        public void PrintInfo()
        {
            CalculateVolume();
            CalculateSurface();
            Console.WriteLine($"Kassen har følgende mål:");
            Console.WriteLine($"Højde:          {Height} cm");
            Console.WriteLine($"Længde          {Lenght} cm");
            Console.WriteLine($"Bredde          {Width} cm");
            Console.WriteLine($"Rumfang:        {Volume} m3");
            Console.WriteLine($"Overflade:      {Surface} m3");
        }
    }
}
