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

namespace Lab_2
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

            // if name left blank, just exit
            if (txtName.Text.Length == 0 & Name.Text.Length == 0)
            {
                MessageBox.Show("Ви не ввели ім'я та назву групи!", "Error");
                txtName.Focus();
                Name.Focus();
                return;
            }

            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Ви не ввели ім'я!", "Error");
                txtName.Focus();
                return;
            }

            if (Name.Text.Length == 0)
            {
                MessageBox.Show("Ви не ввели назву групи!", "Error");
                Name.Focus();
                return;
            }

            // otherwise, display name
            MessageBox.Show("«Вітаю, " + txtName.Text + ", студент групи " + Name.Text);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // close form
            this.Close();

        }
    }
}
