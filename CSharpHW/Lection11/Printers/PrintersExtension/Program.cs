using System;
using Printers;

namespace PrintersExtension
{
    public static class PrinterExtension
    {
        public static void Main(string[] args)
        {
            var message = "hello";
            var colourName1 = "red";
            var colourName2 = "yellow";
            var imageName = "house.png";
            var width = 200;
            var height = 400;

            Text text = new Text(message);
            Colour colour1 = new Colour(colourName1);
            Colour colour2 = new Colour(colourName2);
            Image image = new Image(imageName, width, height);

            Text[] textArray = new Text[] { text, text };
            Colour[] colourArray = new Colour[] { colour1, colour2 };
            Image[] imageArray = new Image[] { image, image };

            Printer printer = new Printer();
            printer.Print(textArray);
            ColourPrinter colourPrinter = new ColourPrinter();
            Console.WriteLine();
            colourPrinter.Print(textArray, colourArray);
            Console.WriteLine();
            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print(imageArray);
            Console.WriteLine();


            Console.ReadKey();
        }
        public static void Print(this Printer printer, Text[] text)
        {
            foreach (var message in text)
            {
                Console.WriteLine(message);
            }
        }

        public static void Print(this PhotoPrinter printer, Image[] imageArray)
        {
            foreach (var image in imageArray)
            {
                Console.WriteLine("{0} has width - {1} and height - {2}", image.Name, image.Width, image.Height);
            }
        }

        public static void Print(this ColourPrinter printer, Text[] textArray, Colour[] colourArray)
        {
            foreach (var a in textArray)
            {
                foreach (var b in colourArray)
                {
                    Console.WriteLine("This message: {0} will be printed in this colour : {1}", a.Message, b.Name);
                }
            }
        }
    }
}