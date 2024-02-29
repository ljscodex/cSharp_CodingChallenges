using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ForCodingChallenges.Generics;

namespace ForCodingChallenges.Codility
{


    public class Codility
    {


        // [Benchmark]
        // [Arguments([-1,-3])]
        public int MissingInteger(int[] A)
        {
            A = A.Where(x => x > 0).ToArray();
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (i == A.Length - 1) return A[i] + 1;
                if (A[i + 1] > A[i] + 1)
                {
                    return A[i] + 1;
                }
            }
            return 1;
        }

        public int longestPassword(String S)
        {
            int max = 0;
            var words = S.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                words[i] = rgx.Replace(words[i], "");
                if ((words[i].Length >= max ) && (words[i].Length >= 3)) //3 because we need even letters (2+) and odd numers (1+)
                {
                    // lets check odd numbers or even letters
                    char[] arr = words[i].ToCharArray();

                    var letters = Array.FindAll<char>(arr, (c => (char.IsLetter(c))));
                    var numbers = Array.FindAll<char>(arr, (c => (char.IsNumber(c))));
                    GenericsOperations g = new GenericsOperations();
                    if (g.isODD(letters.Length) && !g.isODD(numbers.Length))
                    {
                        max = words[i].Length;
                    }
                }

            }
            if (max > 0) { return max; }
            return -1;

        }

    }
}
