using System;
using Xunit;
using NumberConverter;

namespace NumberConverterTests
{
    public class NumberConverterTest
    {
        [Fact]
        public void WrongFormatTest()
        {
            string testStr1 = "test";
            string testStr2 = "123";
            string testStr3 = "xvi";
            string testStr4 = "MMXAI";

            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr1));
            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr2));
            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr3));
            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr4));
        }

        [Fact]
        public void SimpleNumbersTest()
        {
            string str1 = "I";
            string str2 = "V";
            string str3 = "XVI";
            string str4 = "MDCLXVI";

            int num1 = NumberConverter.NumberConverter.RomanToInt(str1);
            int num2 = NumberConverter.NumberConverter.RomanToInt(str2);
            int num3 = NumberConverter.NumberConverter.RomanToInt(str3);
            int num4 = NumberConverter.NumberConverter.RomanToInt(str4);

            Assert.Equal(1, num1);
            Assert.Equal(5, num2);
            Assert.Equal(16, num3);
            Assert.Equal(1666, num4);
        }

        [Fact]
        public void ComplexNumbersTest()
        {
            string str1 = "MDXCIV";
            string str2 = "MCDIII";
            string str3 = "MXCXXIX";

            int num1 = NumberConverter.NumberConverter.RomanToInt(str1);
            int num2 = NumberConverter.NumberConverter.RomanToInt(str2);
            int num3 = NumberConverter.NumberConverter.RomanToInt(str3);

            Assert.Equal(1594, num1);
            Assert.Equal(1403, num2);
            Assert.Equal(1119, num3);
        }
    }
}
