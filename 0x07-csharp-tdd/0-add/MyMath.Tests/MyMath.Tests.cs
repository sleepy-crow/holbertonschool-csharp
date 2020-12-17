using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1)]
        [TestCase(5, 1)]
        [TestCase(-10, 1)]
        [TestCase(1, 2)]
        [TestCase(1, 15)]
        [TestCase(0, 0)]
        [TestCase(3, 5)]
        [TestCase('k', 's')]
        [TestCase(1, 1)]
        public void Tester(int a, int b)
        {
            int tested = Operations.Add(a, b);
            Assert.AreEqual(tested, a + b);
        }
    }
}