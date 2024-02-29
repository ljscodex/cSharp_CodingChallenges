using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.Codility
{
    internal class Codility
    {

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

    }
}
