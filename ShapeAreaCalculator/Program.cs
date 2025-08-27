using System;
using System.Collections.Generic;
using Shapes; //Imported the Shapes Project

namespace ShapeAreaCalculator;
internal class Program
{
    static void Main()
    {
        IShape circ = new Circle(-7);
        Console.WriteLine($"Circle Area: {circ.Area()}");
    }
}
