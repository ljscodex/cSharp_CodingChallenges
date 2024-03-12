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

            if ( s.Length == t.Length && s != t) { return false;}

            t = new string(t.Where(c => s.Contains(c)).ToArray());
            if ( s == t ) { return true; }

            if (t.Length == 0) { return true; }
            else if (t.Length < s.Length)
            {
                return false;
            }
            HashSet<char> compares = s.ToHashSet();

            if (s.Length == t.Length && s != t) { return false; }

            foreach ( var hash in compares    )
            {
                if ( hash.ToString() == t ) { return true; }

                    while (hash != t[0] && t.Length > 0)
                    {
                        t = t.Remove(0, 1);
                    }
                if ( hash == t[0])
                {

                   while (t.Length > 0 && hash == t[0] )
                    {
                        t =t.Remove(0,1);
                    }

                }
                if ( s == t ) { return true; }
                if ( t.Length == 0) { return false; }

            }

            return true;
        }



    }
}
