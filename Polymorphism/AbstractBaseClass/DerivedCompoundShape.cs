using System;
using System.Collections.Generic;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    class DerivedCompoundShape : AbstractShape {

        private List<AbstractShape> _shapeList = new List<AbstractShape>();

        public DerivedCompoundShape(int x, int y) : base(x, y) { }

        public void Add(AbstractShape shape) {
            _shapeList.Add(shape);
        }

        public override double GetArea() {
            double tempArea = 0;
            foreach (AbstractShape shape in _shapeList) {
                tempArea += shape.GetArea();
            }
            Console.WriteLine($"Sum of all perimeters: {tempArea}");

            return tempArea;
        }

        public override double GetPerimeter() {
            double tempPerimeter = 0;
            foreach (AbstractShape shape in _shapeList) {
                tempPerimeter += shape.GetPerimeter();
            }
            Console.WriteLine($"Sum of all perimeters: {tempPerimeter}");

            return tempPerimeter;
        }

        public override void PrintShapeType() {
            Console.WriteLine("I'm a CompoundShape");
            foreach (AbstractShape shape in _shapeList) {
                shape.PrintShapeType();
            }
        }
    }
}
