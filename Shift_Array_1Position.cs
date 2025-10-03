/*using System;


namespace Basic_Programs
{
    internal class Shift_Array_1Position
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int temp = array[0];
            for(int i=0;i<array.Length-1;i++)
            {
                array[i] = array[i + 1];

            }
            array[array.Length - 1] = temp;
            Console.WriteLine("Shifted Array is :" + string.Join(",", array));
        }

    }
}
*/