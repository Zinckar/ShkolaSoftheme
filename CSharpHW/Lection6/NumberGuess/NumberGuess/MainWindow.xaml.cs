using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGuess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
        public partial class MainWindow : Window
        {
            private static int tryAgain = 2;
            private int random;
            public MainWindow()
            {
                InitializeComponent();
                random = Random();
        }

            private void Submit(object sender, RoutedEventArgs e)
            {
            
            
            
            try
                {
                    ParseUserNumber(ref random);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

           
            }
        private void ParseUserNumber(ref int random)
            {

            var userNumber = Int32.Parse(UserNumber.Text);
                if (random == userNumber)
                {
                    MessageBox.Show("Congratz! You're right!");
                    tryAgain = 2;
                    random = Random();  
                }
                else
                {
                    MessageBox.Show("You have " + tryAgain + " more tries");
                    tryAgain--;
                    if (tryAgain < 0)
                    {
                        tryAgain = 2;
                        random = Random();
                    }
 
                }
            
        }

            private int Random()
            {
                int randomNumber;
                Random random = new Random();
                randomNumber = random.Next(1, 10);

                return randomNumber;
            }
        }
    }
