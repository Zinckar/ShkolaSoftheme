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

namespace NumericDataTypes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (dataType.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "byte":
                    ShowByteValues();
                    break;
                case "sbyte":
                    ShowSbyteValues();
                    break;
                case "short":
                    ShowShortValues();
                    break;
                case "ushort":
                    ShowUshortValues();
                    break;
                case "int":
                    ShowIntValues();
                    break;
                case "uint":
                    ShowUintValues();
                    break;
                case "long":
                    ShowLongValues();
                    break;
                case "ulong":
                    ShowUlongValues();
                    break;
                case "float":
                    ShowFloatValues();
                    break;
                case "double":
                    ShowDoubleValues();
                    break;
                case "decimal":
                    ShowDecimalValues();
                    break;
            }
        }


        private void ShowByteValues()
        {
            minValue.Text = byte.MinValue.ToString();
            maxValue.Text = byte.MaxValue.ToString();
            defaultValue.Text = default(byte).ToString();
        }

        private void ShowSbyteValues()
        {
            minValue.Text = sbyte.MinValue.ToString();
            maxValue.Text = sbyte.MaxValue.ToString();
            defaultValue.Text = default(sbyte).ToString();
        }

        private void ShowShortValues()
        {
            minValue.Text = short.MinValue.ToString();
            maxValue.Text = short.MaxValue.ToString();
            defaultValue.Text = default(short).ToString();
        }

        private void ShowUshortValues()
        {
            minValue.Text = ushort.MinValue.ToString();
            maxValue.Text = ushort.MaxValue.ToString();
            defaultValue.Text = default(ushort).ToString();
        }

        private void ShowIntValues()
        {
            minValue.Text = int.MinValue.ToString();
            maxValue.Text = int.MaxValue.ToString();
            defaultValue.Text = default(int).ToString();
        }

        private void ShowUintValues()
        {
            minValue.Text = uint.MinValue.ToString();
            maxValue.Text = uint.MaxValue.ToString();
            defaultValue.Text = default(uint).ToString();
        }

        private void ShowLongValues()
        {
            minValue.Text = long.MinValue.ToString();
            maxValue.Text = long.MaxValue.ToString();
            defaultValue.Text = default(long).ToString();
        }

        private void ShowUlongValues()
        {
            minValue.Text = ulong.MinValue.ToString();
            maxValue.Text = ulong.MaxValue.ToString();
            defaultValue.Text = default(ulong).ToString();
        }

        private void ShowFloatValues()
        {
            minValue.Text = float.MinValue.ToString();
            maxValue.Text = float.MaxValue.ToString();
            defaultValue.Text = default(float).ToString();
        }

        private void ShowDoubleValues()
        {
            minValue.Text = double.MinValue.ToString();
            maxValue.Text = double.MaxValue.ToString();
            defaultValue.Text = default(double).ToString();
        }

        private void ShowDecimalValues()
        {
            minValue.Text = decimal.MinValue.ToString();
            maxValue.Text = decimal.MaxValue.ToString();
            defaultValue.Text = default(decimal).ToString();
        }
    }
}
