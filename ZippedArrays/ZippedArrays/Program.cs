using System;

namespace ZippedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_one = { 1, 5, 2 };

            int[] array_two = { 3, 6, 4 };

            int[] zippedArr = ZippedArray(array_one, array_two);

            string result = String.Empty;

            foreach (var item in zippedArr)
            {
                result += item.ToString() + " ";
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static int[] ZippedArray(int[] a1, int[] a2)
        {
            int[] zippedArray = new int[a1.Length + a2.Length];

            int nextPtr = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                zippedArray[nextPtr++] = a1[i];
                zippedArray[nextPtr++] = a2[i];
            }

            return zippedArray;
        }
    }
}
