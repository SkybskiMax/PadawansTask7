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

            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==null)
                {
                    throw new ArgumentNullException();
                }
            }

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        }
    }
}
