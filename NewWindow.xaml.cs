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

namespace Quiz
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            /*MainWindow main = new MainWindow();
            main.Show();

            NewWindow newWindow = new NewWindow();
            newWindow.Close();*/

            this.Close();
            MainWindow main = new MainWindow();
            main.ShowDialog();
            

            /*this.Hide();
SignInWindow signIn = new SignInWindow();
signIn.ShowDialog();
this.Show();
             */
        }
    }
}
