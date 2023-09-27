using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Matrix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox[] boxes;
        public MainWindow()
        {
            InitializeComponent();
            boxes = new TextBox[10];
            boxes[0] = a11;
            boxes[1] = a12;
            boxes[2] = a13;
            boxes[3] = a21;
            boxes[4] = a22;
            boxes[5] = a23;
            boxes[6] = a31;
            boxes[7] = a32;
            boxes[8] = a33;
            boxes[9] = textBox_res;
        }

        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckFillText())
            {
                MessageBox.Show("Fill in all cells", "Error", MessageBoxButton.OKCancel);
                return;
            }
            boxes[boxes.Length-1].Text = (
                Convert.ToDouble(a11.Text)* Convert.ToDouble(a22.Text) * Convert.ToDouble(a33.Text) -
                Convert.ToDouble(a11.Text) * Convert.ToDouble(a23.Text) * Convert.ToDouble(a32.Text) -
                Convert.ToDouble(a12.Text) * Convert.ToDouble(a21.Text) * Convert.ToDouble(a33.Text) +
                Convert.ToDouble(a12.Text) * Convert.ToDouble(a23.Text) * Convert.ToDouble(a31.Text) +
                Convert.ToDouble(a13.Text) * Convert.ToDouble(a21.Text) * Convert.ToDouble(a32.Text) -
                Convert.ToDouble(a13.Text) * Convert.ToDouble(a22.Text) * Convert.ToDouble(a31.Text)).ToString("F4");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Yellow);
            TextBox box = (TextBox)sender;
            if (Regex.IsMatch(box.Text, "^-?\\d+(\\,\\d+)?$"))
            {
                brush.Color = Colors.Black;
                box.Foreground = brush;
                btn_res.IsEnabled = true;
            }
            else
            {
                brush.Color = Colors.Red;
                box.Foreground = brush;
                btn_res.IsEnabled= false;
            }
        }

        private bool CheckFillText()
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            int error = 0;
            for (int i = 0; i < 9; i++)
            {
                if (string.IsNullOrWhiteSpace(boxes[i].Text))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
