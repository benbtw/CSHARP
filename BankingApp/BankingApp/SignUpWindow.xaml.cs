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
using System.Windows.Shapes;

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
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

        private void logInBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void signUpBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
