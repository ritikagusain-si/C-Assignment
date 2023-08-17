using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInteraces
{
    class Triangle : Ishape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double SideA { get; set; }

        public double SideB { get; set; }

        public Triangle(double tbase, double height, double sideA, double sideB)
        {
            Base = tbase;
            Height = height;
            SideA = sideA;
            SideB = sideB;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculatePerimeter()
        {
            return Base + SideA * SideB;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("---------TRIANGLE--------");
            Console.WriteLine($"Base : {Base}");
            Console.WriteLine($"Height : {Height}");
            Console.WriteLine($"Side A : {SideA}");
            Console.WriteLine($"Side B : {SideB}");
            Console.WriteLine($"Area : ${CalculateArea()}");
            Console.WriteLine($"Perimeter : ${CalculatePerimeter()}");
        }
    }
}
