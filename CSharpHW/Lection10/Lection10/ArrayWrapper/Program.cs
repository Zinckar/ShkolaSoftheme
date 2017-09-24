using System;

namespace ArrayWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInt = new int[] { 1, 2, 3 };
            ArrayWrapper<int> arrayOfInt = new ArrayWrapper<int>(arrInt);

            arrayOfInt.Add(4);
            Console.WriteLine(arrayOfInt.Contains(4));

            try
            {
                var a = arrayOfInt.GetByIndex(3);
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}