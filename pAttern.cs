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
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" "); // Print spaces
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* "); // Print stars
            }
            Console.WriteLine(); // Move to the next line
        }
    }
}
