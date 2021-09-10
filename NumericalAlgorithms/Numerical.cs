using System;
using System.Collections.Generic;

namespace algo
{
    public static class Numerical
    {
        public static ulong NOD(ulong a, ulong b)
        {
            while (b != 0)
            {
                var reminder = a % b;
                a = b;
                b = reminder;
            }
            return a;
        }
        public static ulong Pow(uint a, uint pow)
        {
            var dic = new Dictionary<int, uint>();
            var binary = Convert.ToString(pow, 2);
            ulong result = 1;
            for(var i = 0; i < binary.Length; i++)
            {
                if (i == 0)
                    dic[i] = a;
                else
                    dic[i] = dic[i - 1] * dic[i - 1];

                if (binary[binary.Length - 1 - i] == '1')
                    result *= dic[i];
            }
            return result;
        }
    }
}