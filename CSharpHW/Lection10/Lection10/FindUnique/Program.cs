using System;
using System.Linq;

namespace FindUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = FillArray(10001);

            Console.WriteLine(UniqueElement(arr));

            Console.ReadKey();
        }

        private static int UniqueElement(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] ^ arr[i];
            }

            return arr.Max();
        }

        private static int[] FillArray(int length)
        {
            var initialArray = new int[length];
            var half = length / 2;

            for (int i = 0; i <= half; i++)
            {
                initialArray[i] = i;
            }

            for (int i = 0; i < half + 1; i++)
            {
                initialArray[half + i] = i;
            }
            return initialArray;
        }
    }

}