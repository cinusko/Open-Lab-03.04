using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
             if (number % 2 == 0)
            {
                return "even";
            }else
            {
                return "odd";
            }
        }
    }
}
