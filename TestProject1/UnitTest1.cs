using lab1._1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = Logic.Result(20);
            Assert.That(result, Is.EqualTo("0 рублей 20 копеек"));
        }

        [Test]
        public void Test2()
        {

            var result = Logic.Result(500);
            Assert.That(result, Is.EqualTo("5 рублей 0 копеек"));
        }

        [Test]
        public void Test3()
        {

            var result = Logic.Result(250);
            Assert.That(result, Is.EqualTo("2 рубля 50 копеек"));
        }
    }
}
