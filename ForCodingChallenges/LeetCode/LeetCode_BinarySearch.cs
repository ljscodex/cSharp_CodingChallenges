using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.LeetCode
{
    internal class LeetCode_BinarySearch
    {
        //35. Search Insert Position
        public int SearchInsert(int[] nums, int target)
        {

            List<int> Index = nums.ToList();
            int i = Index.IndexOf(target);
            if (i >= 0) { return i; }

            int o = Index.FindIndex(x => x > target);
            int s = Index.FindIndex(x => x < target);

            if (o > s) { return o; }
            if (o == -1 && s <= 0) { return nums.Length; }

            return 0;

        }

    }
}
