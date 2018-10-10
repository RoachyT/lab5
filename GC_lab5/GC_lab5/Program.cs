using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            long  x;
            string userInput, goAgain;
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Boolean flag = true;
            bool isValid = false;

            do
                {
                    Console.WriteLine("Enter an integer that's between 1 and  20: ");
                    userInput = Console.ReadLine();

                 isValid = long.TryParse(userInput, out x);
                if (!isValid)
                {
                    Console.WriteLine("Try Again");
                    continue;
                }
                    Console.WriteLine("The fatorial of " + x + " is " + getFactorial(x));
                Console.WriteLine("Continue? (y/n): ");
                goAgain = Console.ReadLine().ToLower();
                    if (goAgain == "n" || goAgain == "no")
                        {
                    flag = false;
                    Console.WriteLine("Goodbye");
                    
                        }

                }

                while (flag);


        }
        static long getFactorial(long result)
        {
           

            if (result == 1)
            {
                return 1;
            }
            else
            {
                return getFactorial(result -1) * result;

            }
         
        }
    }

}
