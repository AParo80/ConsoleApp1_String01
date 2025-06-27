using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_String01
{
    internal class StringReverse
    {

        public static string ReverseStringArrayReverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseStringForLoop(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Inhalt von Input ist Null!! " + input;
            }
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }
    }
}
