using CC3;
using Moq;
using System.Windows.Input;

namespace TestProjectCC3
{
    public class Tests
    {
        private Parser _parser;

        [SetUp]
        public void Setup()
        {
            _parser = new Parser();
        }

        [Test]
        public void ParseManyManySentence()
        {
            var result = _parser.WordParser("It was many and many a year ago");
            Assert.That(result, Is.EqualTo("I0t w1s m2y a1d m2y a y2r a1o"));
        }
        [Test]
        public void ParseMicrosoftCorporationSentence()
        {
            var result = _parser.WordParser("Copyright,Microsoft:Corporation");
            Assert.That(result, Is.EqualTo("C7t,M6t:C6n"));
        }
    }
}