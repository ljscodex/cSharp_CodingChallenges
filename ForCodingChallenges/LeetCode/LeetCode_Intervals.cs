using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.LeetCode
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
        public int[][] Merge_Intervals(int[][] intervals)
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

        // 228. Summary Ranges

        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> rtnList = new List<string>();
            List<int> tmp = new List<int>();
            bool bAdd = false;

            for (int i = 0; i < nums.Length; i++)
            {
                tmp.Add(nums[i]);

                if (i < nums.Length - 1)
                {
                    if (nums[i + 1] != nums[i] + 1)
                    {
                        tmp.Add(nums[i]);
                        bAdd = true;
                    }
                }
                if (bAdd || i == nums.Length - 1)
                {
                    if (tmp.Count > 1)
                    {
                        if (tmp.Min() != tmp.Max())
                        {
                            rtnList.Add(tmp.Min() + "->" + tmp.Max());
                        }
                        else rtnList.Add(tmp.Min().ToString());

                        tmp.Clear();
                    }
                    else
                    {
                        rtnList.Add(nums[i].ToString());
                        tmp.Clear();
                    }
                    bAdd = false;
                }
            }

            return rtnList;
        }

    }
}
