using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.LeetCode
{
    internal class LeetCode_Hashmap
    {
        //202. Happy Number
        public bool IsHappy(int n)
        {
            bool isHappy = false;
            string result = n.ToString();
            List<int> Numbers = new List<int>();
            while (!isHappy)
            {
                int ires = 0;
                for (int a = 0; a < result.Length; a++)
                {
                    int x = int.Parse(result.Substring(a, 1));
                    ires = ires + (int)Math.Pow(x, 2);
                }
                if (ires == 1)
                {
                    return true;
                }
                if (Numbers.Exists(e => e == ires))
                {
                    return false;
                }
                Numbers.Add(ires);
                result = ires.ToString();

            }

            return false;
        }

        //1. Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexes = new int[2];

            for (int a = 0; a <= nums.Length - 1; a++)
            {

                for (int b = 0; b <= nums.Length - 1; b++)
                {
                    if (nums[a] + nums[b] == target && a != b)
                    {
                        indexes[0] = a;
                        indexes[1] = b;
                        return indexes;
                    }

                }
            }
            return indexes;


        }


    }
}
