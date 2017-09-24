using System;
using System.IO;

namespace MemoryManagment
{
    class ResourceHolderBase : IDisposable
    {
        private readonly StreamReader _resource;

        public ResourceHolderBase()
        {
            _resource = new StreamReader("file.txt");
        }
        public void Read()
        {
            var resourceText = _resource.ReadLine();
            Console.WriteLine(resourceText);
        }

        public void Dispose()
        {
            Console.WriteLine("Resource was removed in ResourceHolderBase");
            GC.SuppressFinalize(this);
        }

        ~ResourceHolderBase()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resource was removed in ResourceHolderBase finalizer");
        }
    }
}