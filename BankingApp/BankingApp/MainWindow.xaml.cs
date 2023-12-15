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

namespace BankingApp
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

        private void closeBTN_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void emailBOX_LostFocus(object sender, RoutedEventArgs e)
        {
            emailBOX.Text = "Email";
        }

        private void emailBOX_GotFocus(object sender, RoutedEventArgs e)
        {
            emailBOX.Text = "";
        }

        private void passBOX_GotFocus(object sender, RoutedEventArgs e)
        {
            passLBL.Content = "";
        }

        private void passBOX_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passBOX.Password == "")
                passLBL.Content = "Password";
        }

        private void signBTN_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            this.Close();
        }

        private void logBTN_Click(object sender, RoutedEventArgs e)
        {
            BankAppWindow bankAppWindow = new BankAppWindow();
            bankAppWindow.Show();
            this.Close();
        }
    }
}
