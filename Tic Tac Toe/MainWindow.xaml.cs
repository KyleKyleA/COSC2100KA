using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Author: Kule Angeles
// Date: 9/24/2025
// Description: This is a simple Tic Tac Toe game using WPF for the UI. The game allows two players to take turns marking X and O on a 3x3 grid. The game checks for a win or a draw after each move and displays the result. Players can reset the game to play again or exit the application.
//
namespace TicTacToeUIGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            // Close the application when the exit button is clicked 
            Application.Current.Shutdown();
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}