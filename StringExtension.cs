using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length==0)
            {
                throw new ArgumentException();
            }

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        }
    }
}
