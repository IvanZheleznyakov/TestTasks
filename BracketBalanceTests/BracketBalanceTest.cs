using System;
using Xunit;
using BracketBalance;

namespace BracketBalanceTests
{
    public class BracketBalanceTest
    {
        [Fact]
        public void NoBracketsTest()
        {
            string testStr = "1 + 1";
            bool res = FormatChecker.IsBracketBalanced(testStr);

            Assert.True(res);
        }

        [Fact]
        public void CorrectBracketsTest()
        {
            string testExpr1 = "(1+1)";
            string testExpr2 = "[( 2 * 23 ) + (72 / 2)]";
            string testExpr3 = "{ () [] [(())] }{}";

            bool res1 = FormatChecker.IsBracketBalanced(testExpr1);
            bool res2 = FormatChecker.IsBracketBalanced(testExpr2);
            bool res3 = FormatChecker.IsBracketBalanced(testExpr3);

            Assert.True(res1);
            Assert.True(res2);
            Assert.True(res3);
        }

        [Fact]
        public void WrongBracketsTest()
        {
            string testExpr1 = "(1+1";
            string testExpr2 = "[ ( ] )";
            string testExpr3 = "{} () ]";

            bool res1 = FormatChecker.IsBracketBalanced(testExpr1);
            bool res2 = FormatChecker.IsBracketBalanced(testExpr2);
            bool res3 = FormatChecker.IsBracketBalanced(testExpr3);

            Assert.False(res1);
            Assert.False(res2);
            Assert.False(res3);
        }
    }
}
