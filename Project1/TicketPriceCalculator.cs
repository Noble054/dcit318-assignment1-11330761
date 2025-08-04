using System; 

class TicketPriceCalculator
{
  
    static void Main()
    {
        
        Console.Write("Enter your age: ");
        string input = Console.ReadLine(); 
        int age; 

       
        if (int.TryParse(input, out age))
        {
            int price; 

           
            if (age <= 12 || age >= 65)
            {
                price = 7; 
            }
            else
            {
                price = 10; 
            }

            
            Console.WriteLine("Your ticket price is: GHC" + price);
        }
        else
        {
            
            Console.WriteLine("Invalid input. Please enter a number for your age.");
        }
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
