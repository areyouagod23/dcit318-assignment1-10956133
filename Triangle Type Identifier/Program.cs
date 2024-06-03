﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter length of side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter length of side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter length of side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Equilateral Triangle");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Isosceles Triangle");
        else
            Console.WriteLine("Scalene Triangle");
    }
}
