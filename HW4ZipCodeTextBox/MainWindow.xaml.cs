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

namespace HW4ZipCodeTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxBtnSubmit.IsEnabled = IsZipMatch(uxTxtBoxZip.Text);
        }
        private bool IsZipMatch(string ZipCode)
        {
            string pattern5Digit = @"^\d{5}$";
            string pattern9Digit = @"^\d{5}-\d{4}$";
            string patternCA = @"^[A-Z a-z]\d{1}[A-Z a-z]\d{1}[A-Z a-z]\d{1}$";
            if(Regex.IsMatch(ZipCode, pattern5Digit)|| Regex.IsMatch(ZipCode, pattern9Digit)|| Regex.IsMatch(ZipCode, patternCA))
            {
                return true;
            }
            else
            {
                return false;
            }
            //return Regex.IsMatch(ZipCode, patternCA);
        }

        private void uxTxtBoxZip_TxtChanged(object sender, TextChangedEventArgs e)
        {
            try { uxBtnSubmit.IsEnabled = IsZipMatch(uxTxtBoxZip.Text); }//Without try block i get an error and I don't understand why
            catch (Exception ex) { /*MessageBox.Show(ex.ToString());*/ }//This didn't give me any usfull information
        }
    }
}
