namespace TestProjectCC2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetNtermSequence_0_1_6()
        {
            var result = CC2.Result.FindNthFibonacciNumber(0, 1, 6);

            Assert.That(result, Is.EqualTo(27));
        }
        [Test]
        public void GetNtermSequenceRecursive_0_1_6()
        {
            var result = CC2.Result.FindNthFibonacciNumberRecursive(0, 1, 6);

            Assert.That(result, Is.EqualTo(27));
        }
    }
}