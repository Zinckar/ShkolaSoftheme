using System;
using System.Globalization;
using System.Windows;

namespace ZodiacImageWPF
{
   

    public partial class MainWindow : Window
    {
        private const string FORMAT = "dd/MM/yyyy";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBirthDate(object sender, RoutedEventArgs e)
        {
            DateTime dt;

            if (DateTime.TryParseExact(BirthDate.Text, FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dt))
            {
                ZodiacWindow zodiacWindow = new ZodiacWindow(dt);
                zodiacWindow.Show();
                Close();
            }
            else
            {
                var win2 = new MainWindow();
                win2.Show();
                Close();
            }


        }
    }
}
