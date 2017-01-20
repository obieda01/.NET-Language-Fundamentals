using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("C:\\Users> Fiboncci \nPlease enter the Fibonacci number: ");
                int fabNumber = int.Parse(Console.ReadLine());

                //Fib=(n-1)+(n-2)
                
                int a = 0;
                int b = 1;
                StringBuilder chache = new StringBuilder();
                chache.Append("0, 1");
                //int c = 0;
                for (int i = 0; i < fabNumber; i++)
                {
                   
                    int c = a + b;
                    if (c < fabNumber)
                    {
                        chache.Append(", " + c);
                        a = b;
                        b = c;
                    }
                    else break;
                }
                Console.WriteLine(chache);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred! \nyou entered a wrong value \n\n", e);

            }
        }
    }
}
