using System;
using System.Linq;
namespace Basic_Programs
{
    internal class Missing_Element_Array
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7 };
            int n = array.Max();
            int totalsum = n * (n + 1) / 2;
            int actualsum = 0;
            foreach(int num in array)
            {
                actualsum += num;
            }
            int missing = totalsum - actualsum;
            Console.WriteLine(missing);
        }
    }
}
