using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution {
    public abstract class Shape {

        protected int _x { get; set; }
        protected int _y { get; set; }

        public Shape(int x, int y) {
            this._x = x;
            this._y = y;
        }

        public virtual void ShowOrigin() {
            Console.WriteLine(string.Format("Origin: {0}, {1}", _x, _y));
        }
    }
}
