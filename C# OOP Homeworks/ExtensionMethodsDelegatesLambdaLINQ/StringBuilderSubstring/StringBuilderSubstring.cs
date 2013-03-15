using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            StringBuilder subString = new StringBuilder();
            int maxLength = startIndex + length;

            if (startIndex < 0 || startIndex >= str.Length || maxLength > str.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int index = startIndex; index < maxLength; index++)
            {
                subString.Append(str[index]);
            }

            return subString;
        }
    }
}
