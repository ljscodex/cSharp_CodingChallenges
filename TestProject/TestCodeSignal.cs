using ForCodingChallenges.CodeSignal;
using System.Collections;
using System.Xml.Linq;

namespace TestProject_CodeSignal
{
    public class TestsCodeSignal
    {
        private CodeSignal _codeSignal;

        [SetUp]
        public void Setup()
        {
            _codeSignal = new CodeSignal();
        }


        [TestCase(new int[] { 3, 6, -2, -5, 7, 3 }, ExpectedResult = 21)]
        [TestCase(new int[] { -1, -2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 5, 1, 2, 3, 1, 4 }, ExpectedResult = 6)]
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 6)]
        [TestCase(new int[] { 9, 5, 10, 2, 24, -1, -48 }, ExpectedResult = 50)]
        [TestCase(new int[] { 5, 6, -4, 2, 3, 2, -23 }, ExpectedResult = 30)]
        [TestCase(new int[] { 4, 1, 2, 3, 1, 5 }, ExpectedResult = 6)]
        [TestCase(new int[] { -23, 4, -3, 8, -12 }, ExpectedResult = -12)]
        [TestCase(new int[] { 1, 0, 1, 0, 1000 }, ExpectedResult = 0)]
        /*

* [5, 1, 2, 3, 1, 4]6
* [1, 2, 3, 0]6
* [9, 5, 10, 2, 24, -1, -48] 50
* [5, 6, -4, 2, 3, 2, -23] 30
* [4, 1, 2, 3, 1, 5] 6
* [-23, 4, -3, 8, -12] -12
*  [1, 0, 1, 0, 1000] 0
*  */
        public int TestCodeSignal_adjacentElementsProduct(int[] inputArray)
        {
            return _codeSignal.adjacentElementsProduct(inputArray);
        }



        // 100 19801
        // 3 13
        // 4 25
        // 5 41
        // 899 161946005
        [TestCase(100, ExpectedResult = 19801)]
        [TestCase(3, ExpectedResult = 13)]
        [TestCase(4, ExpectedResult = 25)]
        [TestCase(5, ExpectedResult = 41)]
        [TestCase(8999, ExpectedResult = 161946005)]
        public int TestCodeSignal_shapeArea(int n)
        {
            return _codeSignal.shapeArea(n);
        }



        [TestCase(new int[] { 6, 2, 3, 8 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 5, 4, 6 }, ExpectedResult = 0)]
        [TestCase(new int[] { 6, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 1 }, ExpectedResult = 0)]
        public int TestCodeSignal_MakeArrayConsecutive2(int[] intArray)
        {
            return _codeSignal.MakeArrayConsecutive2(intArray);
        }

        [TestCase(new int[] { 1, 3, 2, 1 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 1, 2 }, ExpectedResult = false)]
        [TestCase(new int[] { 3, 6, 5, 8, 10, 20, 15 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 1, 2, 3, 4, 4 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 4, 10, 4, 2 }, ExpectedResult = false)]
        [TestCase(new int[] { 10, 1, 2, 3, 4, 5 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 1, 1, 2, 3 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 2, 3, 4, 99, 5, 6 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 5, 3, 5 }, ExpectedResult = true)]

        public bool TestCodeSignal_almostIncreasingSequence(int[] intArray)
        {
            return _codeSignal.almostIncreasingSequence(intArray);
        }


        [TestCaseSource(nameof(TestSet1))]
        [TestCaseSource(nameof(TestSet2))]
        [TestCaseSource(nameof(TestSet3))]
        [TestCaseSource(nameof(TestSet4))]
        [TestCaseSource(nameof(TestSet5))]
        [TestCaseSource(nameof(TestSet6))]

        public void testCodeSignal_matrixElementsSum((int[][] matrix, int expectedResult) td)
        {
            {
                Assert.That(_codeSignal.matrixElementsSum(td.matrix), Is.EqualTo(td.expectedResult));
                //(_codeSignal.matrixElementsSum(td.matrix), td.expectedResult));
            }
        }

        internal static IEnumerable<(int[][], int)> TestSet1() 
        {
            int[][] jagged = new int[3][];

            jagged[0] = [1, 1, 1, 0];
            jagged[1] = [0, 5, 0, 1];
            jagged[2] = [2, 1, 3, 10];
            yield return (jagged, 9);
        }

        internal static IEnumerable<(int[][], int)> TestSet2()
        {
            int[][] jagged = new int[3][];

            jagged[0] = [0,1,1,2];
            jagged[1] = [0,5,0,0];
            jagged[2] = [2,0,3,3];
            yield return (jagged,9);
        }

        internal static IEnumerable<(int[][], int)> TestSet3()
        {
            int[][] jagged = new int[3][];

            jagged[0] = [1,1,1];
            jagged[1] = [2,2,2];
            jagged[2] = [3,3,3];
            yield return (jagged, 18);
        }
        internal static IEnumerable<(int[][], int)> TestSet4()
        {
            int[][] jagged = new int[3][];

            jagged[0] = [1, 0, 3];
            jagged[1] = [0, 2, 1];
            jagged[2] = [1, 2, 0];
            yield return (jagged, 5);
        }

        internal static IEnumerable<(int[][], int)> TestSet5()
        {
            int[][] jagged = new int[4][];

            jagged[0] = [1];
            jagged[1] = [5];
            jagged[2] = [0];
            jagged[3] = [2];
            yield return (jagged, 6);
        }

        internal static IEnumerable<(int[][], int)> TestSet6()
        {
            int[][] jagged = new int[4][];

            jagged[0] = [4,0,1];
            jagged[1] = [10,7,0];
            jagged[2] = [0,0,0];
            jagged[3] = [9,1,2];
            yield return (jagged, 15);
        }


        [TestCase(new string[] { "aba", "aa", "ad", "vcd", "aba" }, new string[] { "aba", "vcd", "aba" })]
        [TestCase(new string[] { "aa" }, new string[] { "aa" })]
        [TestCase(new string[] { "abc", "eeee", "abcd", "dcd" }, new string[] { "eeee", "abcd" })]
        public void TestCodeSignal_AllLongestStrings(string[] array, string[] result)
        {
            Assert.That( result, Is.EqualTo(_codeSignal.AllLongestStrings(array)));
        }


    }
}