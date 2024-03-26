using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.CodeSignal
{
    public class CodeSignal
    {

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

        public int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            bool bsum = true;

            for ( int i = 0; i < matrix.Length; i++ )
            {
                for (int b = 0; b < matrix[i].Length;b++)
                {
                    //sum += matrix[0][b];
                    bsum = true;
                    for( int c=0; c< i; c++)
                    {
                        if (matrix[c][b] == 0)
                        {
                            bsum = false;
                            break;
                        }
                    }
                    if (bsum) 
                    {
                        sum += matrix[i][b];
                        bsum = true;
                    }
                }
            }

            return sum;
        }


    }
}
