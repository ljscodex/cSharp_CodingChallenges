using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ForCodingChallenges.LeetCode
{
    public class LeetCode_TwoPointers
    {
        //167. Two Sum II - Input Array Is Sorted
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int a = 0; a < numbers.Length; a++)
            {
                int value = target - numbers[a];
                for (int b = 0; b < numbers.Length; b++)
                {
                    if (b != a && value == numbers[b])
                    {
                        result[0] = a + 1;
                        result[1] = b + 1;
                        return result;
                    }
                }
            }

            return result;

        }


        // 125. Valid Palindrome


        public bool IsPalindrome(string s)
        {
            s = s.ToLower().Trim();
            if (s.Length == 0) { return true; }

            string text = Regex.Replace(s, @"[^a-z0-9]", string.Empty);

            string cmpText = ReverseString(text);
            Console.WriteLine($"Texto: {text} / {cmpText}");
            if (cmpText == text) { return true; }

            return false;

        }

        // Used by IsPalindrome funct
        private string ReverseString(string toReverse)
        {
            char[] stringArray = toReverse.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }

        // 392. Is Subsequence
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) { return true; }
            if (t.Length == 0) { return false; }

            t = new string(t.Where(c => s.Contains(c)).ToArray());
            if ( s == t ) { return true; }

            if (t.Length == 0) 
            {
                return true; 
            }
            else if (t.Length < s.Length)
            {
                return false;
            }

            for ( int i =0; i< s.Length; i++)
            {
                if (t.IndexOf(s[i]) >0)
                {
                        t= t.Remove(0, t.IndexOf(s[i]));
                        i--;
                }
                else if (t.IndexOf(s[i]) ==0)
                {
                    while ( t.IndexOf(s[i]) ==0 )
                    {
                        t= t.Remove(t.IndexOf(s[i]),1);
                    }
                }   
                else {
                   // if ( t.Length == 0) { return true; }
                    return false;
                }

            }

            if ( t.Length >0) { return false; }

          /*  int ifirstIndex = 0;
            char nextLetter = '\n';
            for (int i = 0; i < s.Length; i++)
            {

                if (i == 0)
                {
                    if (s[i] != t[i])
                    {
                        t = t.Substring(ifirstIndex+1, t.Length - ifirstIndex-1);
                    }
                }
               
                else
                {
                    if ((ifirstIndex >= t.IndexOf(s[i])) && (t.IndexOf(s[i]) > 0))
                    {
                        t = t.Remove(t.IndexOf(s[i]), 1);
                        return false;
                    }
                }
                ifirstIndex = t.IndexOf(s[i]);

                
                if (ifirstIndex < 0 )
                {
                    return false;
                }

                if (i < (s.Length - 1)) { nextLetter = s[i + 1]; }
                if (nextLetter == s[i])
                {
                    t = t.Remove(t.IndexOf(s[i]), 2);
                }
                else
                {
                    t = t.Remove(t.IndexOf(s[i]), 1);
                }

              }*/
            return true;
        }



    }
}
