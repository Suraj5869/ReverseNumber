using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumber.Models
{
    internal class Reverse
    {
        public static int ReverseNumber(int number)
        {
            int divisor = 10;
            int temp = number;
            int output = 0;

            while (temp > 0)
            {
                int digit = temp % divisor;
                temp = temp / divisor;
                output = output * 10 + digit;
            }
            return output;
        }
    }
}
