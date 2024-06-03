using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        double ticketPrice;

        if (age <= 12 || age >= 65)
            ticketPrice = 7;
        else
            ticketPrice = 10;

        Console.WriteLine("Ticket Price: GHC" + ticketPrice);
    }
}
