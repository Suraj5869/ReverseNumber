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
            int multiple = 10;
            int min = 0;

            while (temp > min)
            {
                int digit = temp % divisor;
                temp = temp / divisor;
                output = output * multiple + digit;
            }
            return output;
        }
    }
}
