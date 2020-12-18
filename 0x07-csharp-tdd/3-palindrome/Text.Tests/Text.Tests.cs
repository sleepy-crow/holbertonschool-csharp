using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_palindrome_True()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("amor a roma"));
            Assert.IsTrue(Text.Str.IsPalindrome("A man, a plan, a canal: Panama."));
            Assert.IsTrue(Text.Str.IsPalindrome("level"));
            Assert.IsTrue(Text.Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void Test_palindrome_False()
        {
            Assert.IsFalse(Text.Str.IsPalindrome("Hola"));
            Assert.IsFalse(Text.Str.IsPalindrome("Holberton"));
            Assert.IsFalse(Text.Str.IsPalindrome("Roma"));
            Assert.IsFalse(Text.Str.IsPalindrome("Antonio"));
        }

        [Test]
        public void Test_palindrome_empty()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(string.Empty));
        }
    }
}