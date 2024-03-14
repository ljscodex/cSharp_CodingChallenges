using ForCodingChallenges.LeetCode;

namespace TestProject_LeetCode_ArrayString
{
    public class TestsLeetCode_ArrayString
    {
        private LeetCode_ArrayString _leetCode;

        [SetUp]
        public void Setup(  )
        {
            _leetCode = new LeetCode_ArrayString();
        }

        [TestCase("the sky is blue", ExpectedResult = "blue is sky the")]
        [TestCase("  hello world  ", ExpectedResult = "world hello")]
        [TestCase("a good   example", ExpectedResult = "example good a")]

        public string Test_LeetCode_ArrayString_ReverseWords(string s)
        {
            return _leetCode.ReverseWords(s);
        }
    }
}