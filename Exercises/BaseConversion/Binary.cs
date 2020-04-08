using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConversion
{
    class Binary
    {
        public static void BinConvert(string message)
        {
            Console.WriteLine("enter a Binary number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 2);
            Console.WriteLine("The octal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 8));
            Console.WriteLine("the decimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 10));
        }

        internal static void BinConvert()
        {
            throw new NotImplementedException();
        }
    }
}