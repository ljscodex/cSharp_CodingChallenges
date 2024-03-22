using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.CodeSignal
{
    public class CodeSignal
    {

        /*
         * [3, 6, -2, -5, 7, 3]21
         * [-1, -2]2
         * [5, 1, 2, 3, 1, 4]6
         * [1, 2, 3, 0]6
         * [9, 5, 10, 2, 24, -1, -48] 50
         * [5, 6, -4, 2, 3, 2, -23] 30
         * [4, 1, 2, 3, 1, 5] 6
         * [-23, 4, -3, 8, -12] -12
         *  [1, 0, 1, 0, 1000] 0
         */
        public int adjacentElementsProduct (int[] inputArray)
        {
            int max = int.MinValue;
            for (int a = 0; a < inputArray.Length - 1; a++)
            {
                int result = inputArray[a] * inputArray[a + 1];
                Console.WriteLine($"Max {max} -- Result {result}");
                if (result > max) { max = result; }
            }
            return max;
        }

        // 100 19801
        // 3 13
        // 4 25
        // 5 41
        // 899 161946005

        public int shapeArea(int n)
        {
            if (n == 1) { return 1; }
            return n * n + (n - 1) * (n - 1);
        }



        public int MakeArrayConsecutive2(int[] statues)
        {
            if (statues.Length == 1) { return 0; }
            Array.Sort(statues);
            int result = 0;
             for (int a = 0; a < statues.Length - 1; a++)
             {
                 if (statues[a] +1 != statues[a+1])
                 {
                    result += statues[a + 1] - statues[a] -1;
                 }

             }
            return result;
        }


        public bool almostIncreasingSequence(int[] sequence)
        {
            bool justOneNumber = false;
            List<int> lista = sequence.ToList();

            for ( int a=0; a< lista.Count -1; a++)
            {

                if (lista[a] >= lista[a + 1])
                {
                    if (!justOneNumber) 
                    {
                        justOneNumber = true;
                        if (a == 0 || lista[a-1] < lista[a+1])
                        {
                            lista.RemoveAt(a);
                        }
                        else { lista.RemoveAt(a + 1); } 
                        a--;
                    }
                    else { return false; }
                }

            }
            return true;
        }

    }
}
