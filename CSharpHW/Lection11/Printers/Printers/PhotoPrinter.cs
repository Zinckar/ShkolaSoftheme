using System;
using System.Drawing;

namespace Printers
{
    public class PhotoPrinter : Printer
    {
        public override void Print(Text text)
        {
            Console.WriteLine("Derived from Printer. Base class message : {0}", text.Message);
        }
        public void Print(Image image)
        {
            Console.WriteLine("{0} has width - {1} and height - {2}", image.Name, image.Width, image.Height);
        }
    }
}