using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems10To19.Problem12
{
    public class FirstAttempt
    {
        public string IntToRoman(int num)
        {
            // 1 <= num <= 3999
            var ones = Convert(num % 10, 'I', 'V', 'X');
            num = num / 10;
            var tens = Convert(num % 10, 'X', 'L', 'C');
            num = num / 10;
            var hunds = Convert(num % 10, 'C', 'D', 'M');
            num = num / 10;
            var thous = Convert(num % 10, 'M', ' ', ' ');

            return string.Join(string.Empty, thous, hunds, tens, ones);
            
        }

        public string Convert(int num, char singleChar, char fiveChar, char tenChar)
        {
            if(num <= 3)
            {
                return new string(singleChar, num);
            }
            if(num == 4)
            {
                return string.Join(string.Empty, singleChar, fiveChar);
            }
            if(num == 5)
            {
                return fiveChar.ToString();
            }
            if(num <=8)
            {
                return string.Join(string.Empty, fiveChar, new string(singleChar, num - 5));
            }
            if(num == 9)
            {
                return string.Join(string.Empty, singleChar, tenChar);
            }

            return string.Empty;
        }
    }
}
