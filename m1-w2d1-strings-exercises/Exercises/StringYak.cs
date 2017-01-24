using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            StringBuilder sb = new StringBuilder();
            
            if (str == null || str.Length < 3) return str;


            for (int i = 0; i < str.Length ; i++)
            {
                if (str[i] != 'y') sb.Append(str[i]);
                else
                {
                    if (i < str.Length - 2)
                    {
                        if (str[i + 2] != 'k') sb.Append(str[i]);
                        else i += 2;
                    }
                    else
                    {
                        sb.Append(str[i]);
                        sb.Append( str[i + 1]);
                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
