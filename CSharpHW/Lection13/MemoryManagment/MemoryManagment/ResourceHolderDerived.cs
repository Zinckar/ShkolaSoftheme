using System;
using System.IO;

namespace MemoryManagment
{
    class ResourceHolderDerived : ResourceHolderBase, IDisposable
    {
        private readonly StreamReader _resource;

        public ResourceHolderDerived()
        {
            _resource = new StreamReader(@"file.txt");
        }


        public void Read()
        {
            var resourceText = _resource.ReadLine();
            Console.WriteLine(resourceText);
        }

        void IDisposable.Dispose()
        {

            Console.WriteLine("Resource was removed in ResourceHolderDerived.Dispose");
            GC.SuppressFinalize(this);
        }

        ~ResourceHolderDerived()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resource was removed in ResourceHolderDerived finalizer");
        }
    }
}