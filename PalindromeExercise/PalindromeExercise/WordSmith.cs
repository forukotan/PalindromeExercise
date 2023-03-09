using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            // what is a palindrome
            // reverse of the word is euqalto the original word
            // return true or false 
            
            
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);
               if (reversed == word)
                { 
                    return true; 
                }
               else
                {
                    return false;
                }
            
        }
         
    }
}
