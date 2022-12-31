namespace TestProjectCC1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateResultWith4NumbersInArray()
        {
            var result = CC1.Result.FindAddTarget(new int[] { 2, 7, 11, 15 }, 17);

            Assert.That(result, Is.EqualTo(new int[] {0,3}));
        }
        [Test]
        public void ValidateResultWith3NumbersInArray()
        {
            var result = CC1.Result.FindAddTarget(new int[] { 3,2,4 }, 6);

            Assert.That(result, Is.EqualTo(new int[] { 1,2 }));
        }
        [Test]
        public void ValidateResultWith2NumbersInArray()
        {
            var result = CC1.Result.FindAddTarget(new int[] { 3, 3}, 6);

            Assert.That(result, Is.EqualTo(new int[] { 0, 1 }));
        }

        [Test]
        public void ValidateNoResultForNumberNotExpected()
        {
            var result = CC1.Result.FindAddTarget(new int[] { 1 }, 1);

            Assert.That(result, Is.Null);
        }
    }
}