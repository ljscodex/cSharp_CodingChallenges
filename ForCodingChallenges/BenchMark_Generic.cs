using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingChallenges.BenchmarkGeneric
{
    // I use this class just for benmark pruposes
    public class BenchMark_Generic
    {


        // Test Ternary
        [Benchmark]
        public string TernaryUse()
        {
            int x = 5, y = 20;
            //Ternary Operator (?:)
            return (x >= y) ? "x value greater or iqual than y" : "x value less than y";
        }

        [Benchmark]
        public string NoTernaryUse()
        {
            int x = 20, y = 20;
            // If...else If Statement
            if (x >= y)
            {
                return "x value greater or equal than y";
            }
            else
            {
                return "x value less than y";
            }
            //Nested Ternary Operator (?:)
           // return (x > y) ? "x value greater than y" : (x < y) ? "x value less than y" : "x value equals to y";
        }
    }
}
