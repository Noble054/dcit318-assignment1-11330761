using System;

class GradeCalculator
{
    static void Main(string[] arges) { 
        Console.WriteLine("Hello, Welcome to your Grade calculator");
        Console.WriteLine("Please enter your text score");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int score)) {
            if (score >= 90) {
                Console.WriteLine("You got an A");
            } else if (score >= 80) {
                Console.WriteLine("You got a B");
            } else if (score >= 70) {
                Console.WriteLine("You got a C");
            } else if (score >= 60) {
                Console.WriteLine("You got a D");
            } else {
                Console.WriteLine("You got an F");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}