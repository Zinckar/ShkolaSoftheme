using System;

namespace Printers
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "hello";
            var colourName = "red";
            var imageName = "house.png";
            var width = 200;
            var height = 400;

            Text text = new Text(message);
            Colour colour = new Colour(colourName);
            Image image = new Image(imageName, width, height);

            Printer printer = new Printer();
            printer.Print(text);
            ColourPrinter colourPrinter = new ColourPrinter();
            colourPrinter.Print(text);
            colourPrinter.Print(text, colour);
            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print(text);
            photoPrinter.Print(image);

            Console.ReadKey();
        }
    }
}