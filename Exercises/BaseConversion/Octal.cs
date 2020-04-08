using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConversion
{
    class Octal
    {
        public static void OctConvert(string message)
        {

            Console.WriteLine("enter an Octal number: ");
            string number1 = Console.ReadLine();
            int convertnumber = Convert.ToInt32(number1, 8);
            Console.WriteLine("The binary version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 2));
            Console.WriteLine("the decimal version of this number is: ");
            Console.WriteLine(Convert.ToString(convertnumber, 10));

        }

        internal static void OctConvert()
        {
            throw new NotImplementedException();
        }
    }
}