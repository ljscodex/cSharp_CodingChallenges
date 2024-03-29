using Microsoft.Diagnostics.Runtime.DacInterface;
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

        public string[] AllLongestStrings(string[] inputArray)
        {
            var maxlen = inputArray.OrderByDescending(x => x.Length).ToArray();
            var result = maxlen.Where(x => x.Length == maxlen[0].Length);
            return result.ToArray();
        }

        public int commonCharacterCount(string s1, string s2)
        {
            int count=0;

            foreach( char letter in s1)
            { 
                if ( s2.Contains(letter))
                {
                    count++;
                    s2= s2.Remove(s2.IndexOf(letter), 1);
                }

            }
            return count;
        }


       public bool IsLucky(int n)
        {
            char[] array = n.ToString().Select(x => x).ToArray();

            if ( array.Length %2 != 0)
            { return false; }

            int mid = array.Length / 2;
            int sum1 = 0;
            int sum2 = 0;
            for ( int i =0; i< mid; i++)
            {
                sum1 += Int32.Parse(array[i].ToString());
                sum2 += Int32.Parse(array[array.Length - i-1].ToString());
            }
            if ( sum1.Equals(sum2)) { return true;  }

            return false;
        }


    }
}
