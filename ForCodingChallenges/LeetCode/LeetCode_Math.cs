using BenchmarkDotNet.Attributes;
using System;
using System.Numerics;


namespace ForCodingChallenges.LeetCode
{
    public class LeetCode_Math
    {
        //50. Pow(x, n)
        // [Benchmark]
        // [Arguments(2,5)]
        public static double MyPow(double x, int n)
        {
            return Math.Pow(x, n);
        }

        //69. Sqrt(x)

        public static int MySqrt(int x)
        {

            return (int)Math.Sqrt(x);
        }

        //66. Plus One
        public static int[] PlusOne(int[] digits)
        {
            string number = String.Join("", digits);
            BigInteger numbers = BigInteger.Parse(number) + 1;
            digits = numbers.ToString("0." + new string('#', digits.Length)).Select(t => int.Parse(t.ToString())).ToArray();
            return digits;
        }

        //9,223,372,036,854,775,807
        //7,285,091,295,366,732,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6

        //9.
        //Number
        public static bool IsPalindrome(int x)
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

        //172. Factorial Trailing Zeroes
        //| Method         | n    | Mean     | Error    | StdDev   | Median   |
        //|--------------- |----- |---------:|---------:|---------:|---------:|
        //| TrailingZeroes | 8692 | 24.97 ms | 0.935 ms | 2.741 ms | 24.18 ms |
        //  [Benchmark]
        //   [Arguments(9052)]
        public int TrailingZeroes(int n)
        {

            int tl = 0;

            int fives = 5;
            while (fives <= n)
            {

                tl += n / fives;
                // raise five to the next power and continue
                fives *= 5;
            }

            return tl;
        }

    }
}
