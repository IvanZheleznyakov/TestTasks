using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    public static class NumberConverter
    {
        public static int RomanToInt(string romanNumber)
        {
            int result = 0;
            int length = romanNumber.Length;
            for (int i = 0; i != length; ++i)
            {
                int currentNumber = RomanDigitToInt(romanNumber[i]);
                int nextNumber = (i == length - 1) ? 0 : RomanDigitToInt(romanNumber[i + 1]);
                if (currentNumber > nextNumber)
                {
                    result += currentNumber;
                }
                else
                {
                    result -= currentNumber;
                }
            }

            return result;
        }

        public static int RomanDigitToInt(char romanDigit)
        {
            return romanDigit switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Символ " + romanDigit + " не является римским числом"),
            };
        }
    }
}
