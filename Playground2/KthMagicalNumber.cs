using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    public static class KthMagicalNumber
    {
        // http://www.geeksforgeeks.org/amazon-interview-experience-set-226-on-campus/
        /*
        magic number is a number formed by adding one or more powers of 5 .find Kth magic number. 
        5, 25, 25+5=30, 125, 125+5=130, 125+25=150, 125+25+5=155,….
        */

        public static long FindKthMagicalNumber(int k)
        {
            // k = 1 => 5
            // k = 2 = (10) in binary => 5*5
            // k = 3 = (11) in binary => 5*5 + 5
            long kthMagicalNumber = 0;
            long multiplier = 5;
            while(k > 0)
            {
                int remainder = k % 2;
                if (remainder == 1)
                {
                    kthMagicalNumber += multiplier;
                }
                
                k = k / 2;
                multiplier = 5 * multiplier;
            }

            return kthMagicalNumber;
        }
    }
}
