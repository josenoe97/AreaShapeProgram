using ShapeAreaProgram.Entities.Enums;
using ShapeAreaProgram.Entities.Enums.Exceptions;
using System;

namespace ShapeAreaProgram.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) 
            : base(color)
        {
            if (radius < 0)
            {
                throw new DomainException("radius value can't be negative");
            }
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
