using System;
using System.Numerics;
using NUnit.Framework;
using Testirovanie_1;

namespace Tests1
{
    [TestFixture]
    public class HelperForPervokyrsnikTests
    {
        // 1. QuickSortIntMass

        [Test]
        public void QuickSort_UnsortedArray_SortsAscending()
        {
            int[] input = { 5, 2, 8, 1, 9 };
            int[] expected = { 1, 2, 5, 8, 9 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_AlreadySorted_DoesNotChange()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_ReverseSorted_SortsAscending()
        {
            int[] input = { 9, 7, 5, 3, 1 };
            int[] expected = { 1, 3, 5, 7, 9 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_WithDuplicates_SortsCorrectly()
        {
            int[] input = { 3, 1, 3, 2, 1, 2 };
            int[] expected = { 1, 1, 2, 2, 3, 3 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_WithNegativeNumbers_SortsCorrectly()
        {
            int[] input = { 0, -5, 10, -2, 3 };
            int[] expected = { -5, -2, 0, 3, 10 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSort_EmptyArray_DoesNothing()
        {
            int[] input = Array.Empty<int>();
            HelperForPervokyrsnik.QuickSortIntMass(input);
            Assert.That(input, Is.Empty);
        }

        [Test]
        public void QuickSort_NullArray_DoesNotThrow()
        {
            int[] input = null;
            Assert.DoesNotThrow(() => HelperForPervokyrsnik.QuickSortIntMass(input));
        }

        [Test]
        public void QuickSort_SingleElement_DoesNothing()
        {
            int[] input = { 42 };
            int[] expected = { 42 };

            HelperForPervokyrsnik.QuickSortIntMass(input);

            Assert.That(input, Is.EqualTo(expected));
        }

        // 2. PalindromStr

        [TestCase("abba", true)]
        [TestCase("abcba", true)]
        [TestCase("a", true)]
        [TestCase("", true)]
        [TestCase("ab", false)]
        [TestCase("abc", false)]
        [TestCase("hello", false)]
        [TestCase("AbBa", false)]
        public void PalindromStr_ReturnsExpected(string input, bool expected)
        {
            Assert.That(HelperForPervokyrsnik.PalindromStr(input), Is.EqualTo(expected));
        }

        public void PalindromStr_Null_ReturnsTrue()
        {
            Assert.That(HelperForPervokyrsnik.PalindromStr(null), Is.True);
        }

        // 3. Factorial

        [TestCase(0, "1")]
        [TestCase(1, "1")]
        [TestCase(5, "120")]
        [TestCase(10, "3628800")]
        [TestCase(20, "2432902008176640000")]
        public void Factorial_ValidInput_ReturnsExpected(int n, string expectedStr)
        {
            BigInteger expected = BigInteger.Parse(expectedStr);
            BigInteger actual = HelperForPervokyrsnik.Factorial(n);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Factorial_Negative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => HelperForPervokyrsnik.Factorial(-1));
        }

        // 4. Fibonacci

        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "1")]
        [TestCase(3, "2")]
        [TestCase(10, "55")]
        [TestCase(20, "6765")]
        [TestCase(50, "12586269025")]
        public void Fibonacci_ValidInput_ReturnsExpected(int n, string expectedStr)
        {
            BigInteger expected = BigInteger.Parse(expectedStr);
            BigInteger actual = HelperForPervokyrsnik.Fibonacci(n);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Fibonacci_Negative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => HelperForPervokyrsnik.Fibonacci(-5));
        }

        // 5. FindSubstring

        [TestCase("hello world", "world", 6)]
        [TestCase("hello world", "hello", 0)]
        [TestCase("hello", "xyz", -1)]
        [TestCase("abc", "", 0)]
        [TestCase("", "a", -1)]
        [TestCase("aaa", "aa", 0)]
        public void FindSubstring_ValidInput_ReturnsIndex(string text, string pattern, int expected)
        {
            Assert.That(HelperForPervokyrsnik.FindSubstring(text, pattern), Is.EqualTo(expected));
        }

        [Test]
        public void FindSubstring_NullText_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
                HelperForPervokyrsnik.FindSubstring(null, "a"));
        }

        [Test]
        public void FindSubstring_NullPattern_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
                HelperForPervokyrsnik.FindSubstring("abc", null));
        }

        // 6. IsPrime

        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(9, false)]
        [TestCase(17, true)]
        [TestCase(25, false)]
        [TestCase(97, true)]
        [TestCase(104729, true)]
        [TestCase(2147483647, true)]
        public void IsPrime_ReturnsExpected(int n, bool expected)
        {
            Assert.That(HelperForPervokyrsnik.IsPrime(n), Is.EqualTo(expected));
        }

        // 7. ReverseInt

        [TestCase(123, 321)]
        [TestCase(-120, -21)]
        [TestCase(0, 0)]
        [TestCase(5, 5)]
        [TestCase(100, 1)]
        [TestCase(1534236469, 0)]
        [TestCase(int.MaxValue, 0)]
        [TestCase(int.MinValue, 0)]
        public void ReverseInt_ReturnsExpected(int input, int expected)
        {
            Assert.That(HelperForPervokyrsnik.ReverseInt(input), Is.EqualTo(expected));
        }

        // 8. ToRoman

        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(58, "LVIII")]
        [TestCase(1994, "MCMXCIV")]
        [TestCase(2024, "MMXXIV")]
        [TestCase(3999, "MMMCMXCIX")]
        public void ToRoman_ValidInput_ReturnsRoman(int input, string expected)
        {
            Assert.That(HelperForPervokyrsnik.ToRoman(input), Is.EqualTo(expected));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(4000)]
        [TestCase(5000)]
        public void ToRoman_OutOfRange_ThrowsArgumentOutOfRangeException(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                HelperForPervokyrsnik.ToRoman(input));
        }
    }
}