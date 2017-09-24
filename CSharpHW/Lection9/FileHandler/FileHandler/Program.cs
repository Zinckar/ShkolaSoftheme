using System;
using System.IO;

namespace FileHandler
{
    class Program
    {
        private const string EnterPath = "Enter path to the file";
        private const string OpenedForRead = "File is opened for reading";
        private const string OpenedForWrite = "File is opened for writing";
        private const string OpenedForReadWrite = "File is opened for reading & writing";

        static void Main(string[] args)
        {
            var filePath = string.Empty;
            var fh = new FileHandle();

            Console.WriteLine(EnterPath);
            try
            {
                filePath = Console.ReadLine();

            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }


            //Read
            try
            {
                fh = fh.OpenForRead(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(fh);
            Console.WriteLine(OpenedForRead);
            Console.ReadKey();

            //Write
            try
            {
                fh = fh.OpenForWrite(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(fh);
            Console.WriteLine(OpenedForWrite);
            Console.ReadKey();

            //ReadWrite
            try
            {
                fh = fh.OpenFile(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(fh);
            Console.WriteLine(OpenedForReadWrite);
            Console.ReadKey();

        }


    }
}