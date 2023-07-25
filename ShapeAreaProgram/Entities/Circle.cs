using ShapeAreaProgram.Entities.Enums;
using ShapeAreaProgram.Entities.Enums.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaProgram.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

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
            return (Radius*Radius)*3.14;
        }
    }
}
