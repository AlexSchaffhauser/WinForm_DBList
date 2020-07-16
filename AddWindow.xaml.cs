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

namespace AlexSBProject
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                service.GamesService gservice = new service.GamesService();
                GAME game = new GAME()
                {
                    Title = tbTitle.Text,
                    Console = cbConsole.Text,
                    Genre = cbGenre.Text,
                    Complete = false
                };

                gservice.AddGame(game);

                MessageBox.Show("Your game was added to the Database!");
            } else
            {
                MessageBox.Show("Please enter a title");
            }

        }
    }
}
