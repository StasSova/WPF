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

namespace Cipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password = "1234567890";
        public MainWindow()
        {
            InitializeComponent();
            Title = "Password is " + password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Content;
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == password) 
            {
                MessageBox.Show("Right. Welcome","Success");
            }
            else
            {
                MessageBox.Show("Try again", "Fail");
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
