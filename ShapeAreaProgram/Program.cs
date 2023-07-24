﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ShapeAreaProgram.Entities;
using ShapeAreaProgram.Entities.Enums;

namespace ShapeAreaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShape = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Retangle of Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

                    listShape.Add(new Rectangle(width,height,color));
                }
                else if (ch == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

                    listShape.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in listShape)
            {
                Console.WriteLine(shape.Area().ToString("F2" , CultureInfo.InvariantCulture));
            }
        }
    }
}
