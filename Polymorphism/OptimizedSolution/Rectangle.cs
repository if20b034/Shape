using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Rectangle : Shape, IShapeComposition
    {
        private double length;
        private double width; 
        public Rectangle(int x, int y, double length, double width) : base(x, y)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * width + 2 * length;
        }

        public double GetDiameter()
        {
            return Math.Sqrt(Math.Pow(length,2)*Math.Pow(width,2));
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Rectangle");
        }
    }
}
