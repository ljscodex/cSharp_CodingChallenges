using ForCodingChallenges.Codility;

namespace TestProject_Codility
{
    public class TestsCodility
    {
        private Codility _codility;

        [SetUp]
        public void Setup(  )
        {
            _codility = new Codility();
        }


        [TestCase("We test coders. Give us a Try?", ExpectedResult =  4)]
        [TestCase("Forget  CVs..Save time . x x", ExpectedResult = 2)]
        [TestCase("aaaaaaaaa..                ..aaaaaaaaaaaaaaa", ExpectedResult = 1)]
          
        public int Test_CodilityTotalWords (string Sentence)
        {
            return _codility.TotalWords(Sentence);
        }
    }
}