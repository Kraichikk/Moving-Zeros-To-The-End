using System;
using System.Linq;

namespace Moving_Zeros_To_The_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            int[] result = MyMethod(arr);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
        static int[] MyMethod(int[] arr)
        {
            int[] array = new int[arr.Length];
            Array.Fill<int>(array, 0);

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    count++;

                if (arr[i] != 0)
                    array[i - count] = arr[i];
            }
            return array;
        }
        //more clever solution
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
