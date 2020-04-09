using MaterialDesignThemes.Wpf;
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

namespace ClubTennis2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public delegate MessageBoxResult Message(string message);
        public static readonly Message message = new Message(MessageBox.Show);

        public MainWindow()
        {
            
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            //Main.Content = new ListMember();
            //MessageBox.Show(Main.CurrentSource.OriginalString.ToString());
            //Main.Content = new ListMember();
            // this.UpdateButtons();
        }

        public void GoListMemberPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new ListMemberPage();
            this.UpdateButtons(typeof(ListMemberPage).Name);
        }

        public void GoAddMemberPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddMemberPage();
            this.UpdateButtons(typeof(AddMemberPage).Name);
        }

        public void GoCompetitionPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new CompetitionPage();
            this.UpdateButtons(typeof(CompetitionPage).Name);
        }
        public void GoClinicPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new ClinicPage();
            this.UpdateButtons(typeof(ClinicPage).Name);
        }

        public void GoTournamentPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new TournamentPage();
            this.UpdateButtons(typeof(TournamentPage).Name);
        }

        public void UpdateButtons(string newPageName)
        {
            foreach (Button b in this.MainButtons.Children.Cast<Button>())
            {
                b.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#673ab7"));
            }

            Button button = (Button)this.FindName(newPageName.Replace("Page", "") + "B");
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#332b86"));

        }
    }
}
