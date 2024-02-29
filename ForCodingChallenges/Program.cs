using ForCodingChallenges.LeetCode;
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ForCodingChallenges.Codility;
using ForCodingChallenges.BenchmarkGeneric;


var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

    LeetCode_Math lm = new LeetCode_Math();
    LeetCode_TwoPointers lt = new LeetCode_TwoPointers();
    Codility codility = new Codility();

    BenchMark_Generic bg = new BenchMark_Generic();

    bg.TernaryUse();
    bg.NoTernaryUse();
//LeetCode Examples
//lm.TrailingZeroes(9052);


//Codility Examples 
var a = codility.longestPassword("test 5 a0A pass007 ?xy1");

    //var u = codility.MissingInteger([1, 3, 6, 4, 1, 2]);
    //var i = codility.MissingInteger([-1, -3]);
//Console.ReadLine();

