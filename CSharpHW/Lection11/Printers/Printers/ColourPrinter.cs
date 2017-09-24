using System;

namespace Printers
{
    public class ColourPrinter : Printer
    {
        public override void Print(Text text)
        {
            Console.WriteLine("Derived from Printer. Base class message : {0}", text.Message);
        }
        public void Print(Text text, Colour colour)
        {
            Console.WriteLine("This message: {0} will be printed in this colour : {1}", text.Message, colour.Name);
        }
    }
}