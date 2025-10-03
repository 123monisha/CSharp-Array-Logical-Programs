/*using System;

namespace Basic_Programs
{
    internal class Reverse_Array
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("Reversed array is: " + String.Join(", ", array));
        }
    }
}
*/