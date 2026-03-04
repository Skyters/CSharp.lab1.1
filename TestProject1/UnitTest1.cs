using lab1._1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestConverting1()
        {
            var result = Logic.ConversionPennyStringToRubles(20);
            Assert.That(result, Is.EqualTo("20 копеек"));
        }

        [Test]
        public void TestConverting2()
        {

            var result = Logic.ConversionPennyStringToRubles(500);
            Assert.That(result, Is.EqualTo("5 рублей"));
        }

        [Test]
        public void TestConverting3()
        {

            var result = Logic.ConversionPennyStringToRubles(250);
            Assert.That(result, Is.EqualTo("2 рубля 50 копеек"));
        }
    }
}
