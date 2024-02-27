using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges
{
    internal class LeetCode_Intervals
    {

        /*
        // Merge Intervals Challenge
        // URL https://leetcode.com/problems/merge-intervals/?envType=study-plan-v2&envId=top-interview-150
        LeetCode.Merge_Intervals([[1, 3], [2, 6], [8, 10], [15, 18]]);
        LeetCode.Merge_Intervals([[1,4],[4,5]]);
        LeetCode.Merge_Intervals([[2, 3], [4, 5], [6, 7], [8, 9], [1, 10]]);

        LeetCode.Merge_Intervals([[2, 3], [5, 5], [2, 2], [3, 4], [3, 4]]);
        LeetCode.Merge_Intervals([[1, 4], [1, 5]]);

        */
        public static int[][] Merge_Intervals(int[][] intervals)
        {
            var Myintervals = intervals.OrderBy(x => x[0]).ToArray().ToList();
            List<int[]> nArray = new List<int[]>();
            nArray.Add(Myintervals[0]);

            for (int i = 1; i < Myintervals.Count(); i++)
            {
                if (nArray[^1][1] >= Myintervals[i][0])
                {
                    if (nArray[^1][1] < Myintervals[i][1])
                    {
                        nArray[^1][1] = Myintervals[i][1];
                    }
                }
                else
                {
                    nArray.Add(Myintervals[i]);
                }
            }
            return nArray.ToArray();
        }



    }
}
