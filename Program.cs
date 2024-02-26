using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayHourglass();
    }

    static void DisplayHourglass()
    {
        Part1();
        Part2();
        Part1();
        Part3();
    }

    static void Part1()
    {
        Console.WriteLine("*********");
        Console.WriteLine(" *******");
        Console.WriteLine("  *****");
        Console.WriteLine("   ***");
        Console.WriteLine("    *");
    }

    static void Part2()
    {
        Console.WriteLine("    *");
        Console.WriteLine("    *");
    }

    static void Part3()
    {
        Console.WriteLine("   ***");
        Console.WriteLine("  *****");
        Console.WriteLine(" *******");
        Console.WriteLine("*********");
    }
}
