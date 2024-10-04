/*
 * * * * *
 * * * *
 * * *
 * *
 *
 
 */


using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        for (i = 0; i < 5; i++) 
        {
            for (j = 5; j > i; j--) 
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
