using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ZodiacImageWPF
{
    public partial class ZodiacWindow : Window
    {
        private DateTime _dt;
        public ZodiacWindow(DateTime dt)
        {
            _dt = dt;
            InitializeComponent();
            DefineZodiacByDateBirth();
        }

        private const string CAPRICORN = "images/capricorn.jpg";
        private const string AQUARIUS = "images/aquarius.jpg";
        private const string PISCES = "images/pisces.jpg";
        private const string ARIES = "images/aries.jpg";
        private const string TAURUS = "images/taurus.jpg";
        private const string GEMINI = "images/gemini.jpg";
        private const string CANCER = "images/cancer.jpg";
        private const string LEO = "images/leo.jpg";
        private const string VIRGO = "images/virgo.jpg";
        private const string LIBRA = "images/libra.jpg";
        private const string SCORPIO = "images/scorpio.jpg";
        private const string SAGITTARIUS = "images/sagittarius.jpg";

        private void DefineZodiacByDateBirth()
        {
            BirthDate.Text = _dt.ToString();
            int month = _dt.Month;
            int day = _dt.Day;

            switch (month)
            {
                case 1:
                    if (day <= 19)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(CAPRICORN, UriKind.Relative));
                        return;
                    }
                    Zodiac.Source = new BitmapImage(new Uri(AQUARIUS, UriKind.Relative));
                    return;


                case 2:
                    if (day <= 18)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(AQUARIUS, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(PISCES, UriKind.Relative));
                    return;
                    ;
                case 3:
                    if (day <= 20)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(PISCES, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(ARIES, UriKind.Relative));
                    return;
                    ;
                case 4:
                    if (day <= 19)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(ARIES, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(TAURUS, UriKind.Relative));
                    return;
                    ;
                case 5:
                    if (day <= 20)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(TAURUS, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(GEMINI, UriKind.Relative));
                    return;
                    ;
                case 6:
                    if (day <= 20)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(GEMINI, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(CANCER, UriKind.Relative));
                    return;
                    ;
                case 7:
                    if (day <= 22)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(CANCER, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(LEO, UriKind.Relative));
                    return;
                    ;
                case 8:
                    if (day <= 22)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(LEO, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(VIRGO, UriKind.Relative));
                    return;
                    ;
                case 9:
                    if (day <= 22)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(VIRGO, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(LIBRA, UriKind.Relative));
                    return;
                    ;
                case 10:
                    if (day <= 22)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(LIBRA, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(SCORPIO, UriKind.Relative));
                    return;
                    ;
                case 11:
                    if (day <= 21)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(SCORPIO, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(SAGITTARIUS, UriKind.Relative));
                    return;
                    ;
                case 12:
                    if (day <= 21)
                    {
                        Zodiac.Source = new BitmapImage(new Uri(SAGITTARIUS, UriKind.Relative));
                        return;
                    }
                    ;
                    Zodiac.Source = new BitmapImage(new Uri(CAPRICORN, UriKind.Relative));
                    return;
                    ;
            }
            return;
        }
    }
}