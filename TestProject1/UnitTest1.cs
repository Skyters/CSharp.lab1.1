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
            var result = Logic.ConversionPennyStringToRubles(21);
            Assert.That(result, Is.EqualTo("21 копейка"));
        }

        [Test]
        public void TestConverting3()
        {
            var result = Logic.ConversionPennyStringToRubles(23);
            Assert.That(result, Is.EqualTo("23 копейки"));
        }

        [Test]
        public void TestConverting4()
        {

            var result = Logic.ConversionPennyStringToRubles(500);
            Assert.That(result, Is.EqualTo("5 рублей "));
        }

        [Test]
        public void TestConverting5()
        {

            var result = Logic.ConversionPennyStringToRubles(100);
            Assert.That(result, Is.EqualTo("1 рубль "));
        }

        [Test]
        public void TestConverting6()
        {

            var result = Logic.ConversionPennyStringToRubles(2300);
            Assert.That(result, Is.EqualTo("23 рубля "));
        }

        [Test]
        public void TestConverting7()
        {

            var result = Logic.ConversionPennyStringToRubles(250);
            Assert.That(result, Is.EqualTo("2 рубля 50 копеек"));
        }
    }
}
