using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_DSaA_RegularSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numArr = new int[20];
            bool[] numFound = new bool[20];
            int numQuestions = 0;
            string uInput = "";
            int numSearch = 0;
            int searchResult = 0;

            for(int x = 0; x < numArr.Length; x++)
                numArr[x] = rnd.Next(1,101);

            foreach(int num in numArr)
                Console.Write(num + "   ");

            Console.WriteLine("\nLets assume these are the only numbers in the collection....");
            Console.WriteLine("And we need to look for a specific number.\n");

            while(numSearch <= 0)
            {
                Console.Write("What is the number we shall be looking for? ");
                uInput = Console.ReadLine();
                try
                {
                    numSearch = int.Parse(uInput);
                }
                catch(Exception e) 
                { 
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to continue...");
                }
            }

            Console.WriteLine($"\nWe shall be looking for all instances of the number {numSearch}...");

            for(int x = 0; x < numArr.Length;x++)
            {
                Console.WriteLine($"Selecting the number in index {x}...");
                for (int y = 0; y < numArr.Length; y++)
                {
                    if(y == x)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (numFound[y])
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(numArr[y] + "   ");
                    Console.ResetColor();
                }

                Console.WriteLine($"\nComparing the 2 numbers {numArr[x]} and {numSearch}...");
                numQuestions++;
                if (numArr[x] == numSearch)
                {
                    numFound[x] = true;
                    searchResult++;
                }
            }

            Console.WriteLine($"\n\nDone searching! After {numQuestions} comparisons, I have found {searchResult} results for {numSearch}.");

            Console.ReadKey();
        }
    }
}
