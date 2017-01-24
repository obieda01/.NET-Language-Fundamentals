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
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         stringBits("Hello") → "Hlo"
         stringBits("Hi") → "H"
         stringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {
           if(str==null) return null;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i+=2)
            {
                sb.Append(str[ i]);
            }
            return sb.ToString();
        }
    }
}
