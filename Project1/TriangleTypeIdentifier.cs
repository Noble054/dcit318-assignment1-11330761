using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter side C: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("The triangle is Equilateral.");
        else if (a == b || b == c || a == c)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
 
}
