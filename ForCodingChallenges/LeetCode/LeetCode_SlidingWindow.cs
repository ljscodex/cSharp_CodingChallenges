using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace ForCodingChallenges.LeetCode
{
    public class LeetCode_SlidingWindow
    {

        private List<string> CreateCombinations(int startIndex, string pair, int[] initialArray)
        {
            var combinations = new List<string>();
            for (int i = startIndex; i < initialArray.Length; i++)
            {
                var value = $"{pair}{initialArray[i]},";
                combinations.Add(value);
                combinations.AddRange(CreateCombinations(i + 1, value, initialArray));
            }

            return combinations;
        }

        //209. Minimum Size Subarray Sum
        public int MinSubArrayLen(int target, int[] nums)
        {
            int gcounter = nums.Length+1;
            int sum = 0;
            int LastIndex = 0;
            int position = 0;
            int counter = 0;
            while(position < nums.Length)
            {
                sum += nums[position];
                counter++;
                if (sum >= target)
                {
                    gcounter = Math.Min(gcounter,  counter);
                    LastIndex++;
                    sum = 0;
                    position = LastIndex;
                    counter = 0;
                }
                else { position++; }
            }
    
            


            return gcounter == nums.Length+1 ? 0: gcounter ;
           
        }

    }
}
