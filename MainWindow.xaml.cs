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

namespace HelloWorld2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show(passwordBox.Password);
            //MessageBox.Show(textBoxUserName.Text);
            //buttonSubmit.IsEnabled = true;
            buttonSubmit.IsEnabled = EnableTextBox(textBoxUserName.Text, passwordBox.Password);
        }
        public static bool EnableTextBox(string UserName, string Password)
        {

            if (UserName == "\r\n" || Password == "password")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void textBoxUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            buttonSubmit.IsEnabled = EnableTextBox(textBoxUserName.Text, passwordBox.Password);

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            buttonSubmit.IsEnabled = EnableTextBox(textBoxUserName.Text, passwordBox.Password);

        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
