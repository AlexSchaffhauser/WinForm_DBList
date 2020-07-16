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

namespace AlexSBProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow();
            add.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Identify which Radio Button is checked and send content to next window
            string sendConsole;
            if (rb1.IsChecked == true)
            {
                sendConsole = rb1.Content.ToString();
            }
            else if (rb2.IsChecked == true)
            {
                sendConsole = rb2.Content.ToString();
            }
            else if (rb3.IsChecked == true)
            {
                sendConsole = rb3.Content.ToString();
            }
            else if (rb4.IsChecked == true)
            {
                sendConsole = rb4.Content.ToString();
            }
            else
            {
                sendConsole = rb5.Content.ToString();
            }

            ListWindow list = new ListWindow(sendConsole, cbCompleted.IsChecked.Value);
            list.Show();
        }
    }
}
