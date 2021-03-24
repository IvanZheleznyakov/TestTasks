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

            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr1));
            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr2));
            Assert.Throws<ArgumentException>(() => NumberConverter.NumberConverter.RomanToInt(testStr3));
        }
    }
}
