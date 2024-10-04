using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        
        int a = Convert.ToInt32(Console.ReadLine());
       
        switch (a)
        {
            case 1: 
            Console.WriteLine( "Monday ");
            break;
            case 2:
            Console.WriteLine(" Tuesday");
            break;
            Console.WriteLine (" wednesday");
            break; 
            case 3: 
            Console.WriteLine (" Thusday");
            break;
            case 4:
            Console.WriteLine ( " Wednesday ");
            break;
            case 5 : 
            Console.WriteLine ( " Friday");
            break ; 
            case 6: 
            Console.WriteLine (" saturday");
            break ;
            case 7:
            Console.WriteLine (" Sunday");
            break; 
            default : 
             Console.WriteLine ( " invaled ");
             break ;
            
        }
        

    }
}
