using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ForCodingChallenges
{
    internal class LeetCode_Stack
    {

        // 20. Valid Parentheses
        public bool IsValidParentheses(string s)
        {
            string tmp = s;
            while (tmp.Contains("[]") || tmp.Contains("{}") || tmp.Contains("()"))
            {
                tmp = tmp.Replace("[]", "");
                tmp = tmp.Replace("{}", "");
                tmp = tmp.Replace("()", "");
            }
            if (tmp.Length > 0) { return false; }



            return true;
        }


    }
}
