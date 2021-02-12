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

namespace Ex_3
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            // get the name of the drink
            string login = txtLog.Text;
            string password = txtPass.Password;
            if (login.Length <= 1)
            {
                log_nope.Visibility = Visibility.Visible;
                log_ok.Visibility = Visibility.Hidden;
                MessageBox.Show("ENTER LOGIN!");


            }
            else if (password.Length <= 1)
            {
                pass_nope.Visibility = Visibility.Visible;
                pass_ok.Visibility = Visibility.Hidden;
                MessageBox.Show("ENTER PASSWORD!");


            }
            else
            {
                if (login == "admin")
                {
                    log_nope.Visibility = Visibility.Hidden;
                    log_ok.Visibility = Visibility.Visible;
                    if (password == "admin")
                    {
                        pass_nope.Visibility = Visibility.Hidden;
                        pass_ok.Visibility = Visibility.Visible;

                        MessageBox.Show("HELLO MY ADMIN! ");

                    }
                    else
                    {
                        pass_nope.Visibility = Visibility.Visible;
                        pass_ok.Visibility = Visibility.Hidden;

                        MessageBox.Show("Wrong Password! Try again! ", "Error");
                    }
                }
                else
                {
                    log_nope.Visibility = Visibility.Visible;
                    log_ok.Visibility = Visibility.Hidden;

                    MessageBox.Show("Wrong Login! Try again! ", "Error");
                    

                }
            }
        }
    }
}