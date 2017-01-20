using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("C:\\Users> DecimalToBinary\nPlease enter in a series of decimal values (separated by spaces); for example: 460 8218 1 31313 987654321");
                char[] seprators = { ' ' };
                string[] stringValueArray= Console.ReadLine().Split(seprators);
                for (int i=0;i<stringValueArray.Length;i++)
                {
                    int intValue = int.Parse(stringValueArray[i]);
                    
                    Console.WriteLine(intValue+" in binary is " +DecimalToBinary(intValue)+"\n");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occurred! \nyou entered a wrong value \n\n", e);
            }
        }

        static String DecimalToBinary(int decValue)
        {
            StringBuilder sb = new StringBuilder();
                                    
            while (decValue != 0)
            {
                sb.Append(((decValue & 1) == 1 ? '1' : '0').ToString());
                decValue >>= 1;

            }
            char[] charArray = sb.ToString().ToCharArray();
            StringBuilder sb_temp = new StringBuilder();

            for (int i = charArray.Length-1; i >=0; i--)
            {
                sb_temp.Append(charArray[i].ToString()); 
            }
            return sb_temp.ToString();
        }
       
    }
}
