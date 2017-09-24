using System;

namespace MemoryManagment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Show dispose method in using construction");

            using (ResourceHolderBase rhb = new ResourceHolderBase())
            {
                rhb.Read();
            }
            using (ResourceHolderDerived rhd = new ResourceHolderDerived())
            {
                rhd.Read();
            }

            Console.WriteLine();
            Console.WriteLine("Show excplicit invokation of dispose method");
            ResourceHolderBase rhb1 = new ResourceHolderBase();
            rhb1.Read();
            rhb1.Dispose();
            ResourceHolderDerived rhd1 = new ResourceHolderDerived();
            rhd1.Read();
            rhd1.Dispose();

            Console.WriteLine();
            Console.WriteLine("Show invokation of finalize method");
            ResourceHolderBase rhb2 = new ResourceHolderBase();
            rhb2.Read();
            ResourceHolderDerived rhd2 = new ResourceHolderDerived();
            rhd2.Read();
            Console.ReadKey();
        }
    }
}