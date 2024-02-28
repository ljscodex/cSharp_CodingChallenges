using ForCodingChallenges.LeetCode;
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;


    var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

    LeetCode_Math lm = new LeetCode_Math();


    lm.TrailingZeroes(9052);
    //LeetCode_Math.TrailingZeroes(30);

