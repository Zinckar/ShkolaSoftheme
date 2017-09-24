using System;

namespace Printers
{
    public class Printer
    {
        public virtual void Print(Text text)
        {
            Console.WriteLine(text.Message);
        }
    }
}