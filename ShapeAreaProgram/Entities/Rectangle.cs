using ShapeAreaProgram.Entities.Enums;
<<<<<<< HEAD
using ShapeAreaProgram.Entities.Enums.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> aa3fc7e5a803346d7a0647e291278bd77bbe1d6f

namespace ShapeAreaProgram.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) 
            : base(color) 
        { 
            if(width < 0 || height < 0)
            {
                throw new DomainException("width and height value can't be negative");
            }
            Width = width;
            Height = height; 
        }

        public override double Area()
        {
            return Width * Height ;
        }
    }
}
