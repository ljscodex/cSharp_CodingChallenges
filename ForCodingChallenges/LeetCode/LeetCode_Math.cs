using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ForCodingChallenges.LeetCode
{
    internal class LeetCode_Math
    {
        //50. Pow(x, n)
        public double MyPow(double x, int n)
        {
            return Math.Pow(x, n);
        }

        //69. Sqrt(x)

        public int MySqrt(int x)
        {

            return (int)Math.Sqrt(x);
        }

        //66. Plus One
        public int[] PlusOne(int[] digits)
        {
            string number = String.Join("", digits);
            BigInteger numbers = BigInteger.Parse(number) + 1;
            digits = numbers.ToString("0." + new string('#', digits.Length)).Select(t => int.Parse(t.ToString())).ToArray();
            return digits;
        }

        //9,223,372,036,854,775,807
        //7,285,091,295,366,732,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6

        //9. Palindrome Number
        public bool IsPalindrome(int x)
        {
            char[] tmp = x.ToString().ToCharArray();

            for (int a = 0; a < tmp.Length - 1; a++)
            {
                if (tmp[a] != tmp[tmp.Length - 1 - a])
                {
                    return false;
                }
            }

            return true;
        }



    }
}
