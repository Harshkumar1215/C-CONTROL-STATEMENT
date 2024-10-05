


*
* *
* * *
* * * *
* * * * *



using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Number of rows
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); // Move to the next line
        }
    }
}
