using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 100)
        {
            if (number == 101)
            {
                Console.WriteLine("This number is equal to 101");
            }

            if (number > 120 && number < 150)
            {
                Console.WriteLine("The number is between 120 to 150");
            }
        }
        else
        {
            Console.WriteLine("The number is less than 100");
        }
    }
}
