using ForCodingChallenges.LeetCode;
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ForCodingChallenges.Codility;


var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

    LeetCode_Math lm = new LeetCode_Math();
    LeetCode_TwoPointers lt = new LeetCode_TwoPointers();
    Codility codility = new Codility();

    //LeetCode Examples
    //lm.TrailingZeroes(9052);
   
    
    //Codility Examples 
    //var u = codility.MissingInteger([1, 3, 6, 4, 1, 2]);
    //var i = codility.MissingInteger([-1, -3]);
Console.ReadLine();
