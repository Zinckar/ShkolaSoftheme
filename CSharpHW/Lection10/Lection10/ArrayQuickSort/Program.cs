using System;

namespace ArrayQuickSort
{
    internal class Program
    {
        private const string SortedArrayInfo = "Sorted Array: ";
        private static void Main(string[] args)
        {
            var initialArray = FillArray(20);
            foreach (var a in initialArray)
            {
                Console.Write($"{a} ");
                
            }
            var sortedArray = SortArray(initialArray);
            Console.WriteLine();

            Console.WriteLine(SortedArrayInfo);
            foreach (var a in sortedArray)
            {
                Console.Write($"{a} ");
            }

            Console.ReadKey();
        }

        private static int[] FillArray(int length)
        {
            int[] arr = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, length);
            }

            return arr;
        }

        private static int[] SortArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > array[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = array[i];
            }
            return result;
        }
    }
}
