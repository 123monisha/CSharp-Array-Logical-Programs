/*using System;


namespace Basic_Programs
{
    internal class Remove_Duplicates_Array
    {
       static void Main(string[] args)
        {
            int[] array = { 0, 1, 9, 1, 6, 2, 5, 2, 2, 6, 9, 9 };
            for(int i=0;i<array.Length-1;i++)
            {
                bool isDuplicate = false;
                for(int j=0;j<i;j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
*/