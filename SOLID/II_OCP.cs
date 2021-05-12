using System;

namespace Altkom._12_14._05._2021.WPCSharp.SOLID.O
{
    abstract class Shape
    {
        public abstract double Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override double Area => A * A;
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public override double Area => A * B;
    }

    class Circle : Shape
    {
        public int R { get; set; }
        public override double Area => R * R * Math.PI;
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
