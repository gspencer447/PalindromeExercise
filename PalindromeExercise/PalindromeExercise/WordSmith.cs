using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string string1)
        {
            char[] charArray = string1.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            if (string1 == reversedString)
            {
                return true;
            }
            return false;
        }
    }
}
