using System;

namespace ClassMethodAssignment
{
    internal class StaticTools
    {
        // Static method that counts how many 'i' or 'I' characters appear in a string
        public static int IFinder(string input)
        {
            int count = 0;

            // Loop through each character and count i/I
            foreach (char c in input)
            {
                if (c == 'i' || c == 'I')
                    count++;
            }

            return count;


        }
    }
}
