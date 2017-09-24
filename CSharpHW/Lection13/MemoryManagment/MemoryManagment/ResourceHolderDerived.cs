using System;
using System.IO;

namespace MemoryManagment
{
    class ResourceHolderDerived : ResourceHolderBase, IDisposable
    {
        private const string FilePath = "file.txt";
        private const string RemovedInClass = "Resource was removed in ResourceHolderDerived.Dispose";
        private const string RemovedInFinilizer = "Resource was removed in ResourceHolderDerived finalizer";

        private readonly StreamReader _resource;

        public ResourceHolderDerived()
        {
            _resource = new StreamReader(FilePath);
        }


        public void Read()
        {
            var resourceText = _resource.ReadLine();
            Console.WriteLine(resourceText);
        }

        void IDisposable.Dispose()
        {

            Console.WriteLine(RemovedInClass);
            GC.SuppressFinalize(this);
        }

        ~ResourceHolderDerived()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(RemovedInFinilizer);
        }
    }
}