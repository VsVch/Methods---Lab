﻿using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = Area(width, height);
            Console.WriteLine(area);

        }

        private static double Area(double width, double height)
        {
            return width * height;

        }
    }
}
