using System;
using System.IO;

namespace MemoryManagment
{
    class ResourceHolderBase : IDisposable
    {
        private const string FilePath = "../../file.txt";
        private const string RemovedInClass = "Resource was removed in ResourceHolderBase";
        private const string RemovedInFinilizer = "Resource was removed in ResourceHolderBase finalizer";

        private readonly StreamReader _resource;

        public ResourceHolderBase()
        {
            _resource = new StreamReader(FilePath);
        }
        public void Read()
        {
            var resourceText = _resource.ReadLine();
            Console.WriteLine(resourceText);
        }

        public void Dispose()
        {
            Console.WriteLine(RemovedInClass);
            GC.SuppressFinalize(this);
        }

        ~ResourceHolderBase()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(RemovedInFinilizer);
        }
    }
}