using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Triangle : Shape, IShapeComposition
    {
        private double SiteA { get; set; }
        private double SiteB { get; set; }
        private double SiteC { get; set; }

        public Triangle(int x, int y, double SiteA, double SiteB, double SiteC) : base(x, y)
        {
            this.SiteA = SiteA;
            this.SiteB = SiteB;
            this.SiteC = SiteC;
        }

        public double GetArea()
        {
            double s = (SiteA + SiteB + SiteC) / 2;
            return Math.Sqrt(s*(s-SiteA)*(s-SiteB)*(s-SiteC));
        }

        public double GetPerimeter()
        {
            return SiteA+SiteB+SiteC;
        }

        public double[] Getheight()
        {
            double[] result= new double[3];
            result[0]=this.GetArea() * 2 / SiteA;
            result[1] = this.GetArea() * 2 / SiteB;
            result[2] = this.GetArea() * 2 / SiteC;

            return result;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Triangle");
        }
    }
}
