namespace Printers
{
    public class Image
    {
        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Image(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
    }
}