using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FizzWriter
{
    public static class FizzBuzz
    {
        public static void FizzBuzzWriter()
        {
            bool isValid = false;

            string destinationPath = string.Empty;
            while (!isValid)
            {
                Console.WriteLine("Please input the Path you want the FizzBuzz.txt file to be on:");
                destinationPath = Console.ReadLine();
                if (!Directory.Exists(destinationPath))
                {
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                        File.Create(Path.GetFileName(destinationPath));
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("the Path you entered is NOT Valid");
                    }
                }
                isValid = true;
            }

            using (StreamWriter sr = new StreamWriter(destinationPath))
            {
                for (int i = 1; i <= 300; i++)
                {
                    if ((i % 3 == 0 && i % 5 == 0) || (i.ToString().Contains("3") && !(i.ToString().Contains("5"))))
                    {
                        sr.WriteLine("Fizz ");

                    }
                    else
                    {
                        if ((i % 3 != 0 && i % 5 == 0) || (i.ToString().Contains("5") && !(i.ToString().Contains("3"))))
                        {
                            sr.WriteLine("Buzz ");
                        }
                        else
                        {
                            if ((i % 3 == 0 && i % 5 == 0))
                            {
                                sr.WriteLine("FizzBuzz ");
                            }
                            else sr.WriteLine(i.ToString() + " ");

                        }

                    }
                }
            }
        }
    }
}
