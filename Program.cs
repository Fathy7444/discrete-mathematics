// See https://aka.ms/new-console-template for more information
using System;
namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Start Number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------- ");
            Console.Write("Enter the End Number : ");
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------- ");
            Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0}  {1} ", i, ",");
                }
            }
            Console.ReadKey();
        }
    }
}