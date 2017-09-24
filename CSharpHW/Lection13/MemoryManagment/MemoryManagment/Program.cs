using System;

namespace MemoryManagment
{
    class Program
    {
        private const string ShowDisposeInConstruction = "Show dispose method in using construction";
        private const string ShowExplicit = "Show explicit invokation of dispose method";
        private const string ShowFinalize = "Show invokation of finalize method";
        static void Main(string[] args)
        {
            Console.WriteLine(ShowDisposeInConstruction);

            using (ResourceHolderBase rhb = new ResourceHolderBase())
            {
                rhb.Read();
            }
            using (ResourceHolderDerived rhd = new ResourceHolderDerived())
            {
                rhd.Read();
            }

            Console.WriteLine();
            Console.WriteLine(ShowExplicit);
            ResourceHolderBase rhb1 = new ResourceHolderBase();
            rhb1.Read();
            rhb1.Dispose();
            ResourceHolderDerived rhd1 = new ResourceHolderDerived();
            rhd1.Read();
            rhd1.Dispose();

            Console.WriteLine();
            Console.WriteLine(ShowFinalize);
            ResourceHolderBase rhb2 = new ResourceHolderBase();
            rhb2.Read();
            ResourceHolderDerived rhd2 = new ResourceHolderDerived();
            rhd2.Read();
            Console.ReadKey();
        }
    }
}