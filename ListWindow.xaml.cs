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
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        string console = "NES";
        bool completed = false;
        service.GamesService gservice = new service.GamesService();
        public ListWindow()
        {
            InitializeComponent();
            
        }

        public ListWindow(string console, bool completed)
        {
            this.console = console;
            this.completed = completed;

            InitializeComponent();
            
            this.DataContext = gservice.RetrieveGames(console, completed);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Set game as Complete

            gservice.EditGame(int.Parse(txtId.Text));
        }

        private void gameGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GAME game = gameGrid.SelectedItem as GAME;
            int ID = game.Id;
            txtId.Text = ID.ToString();
        }
    }
}
