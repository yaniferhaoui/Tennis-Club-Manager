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
    /// Interaction logic for TournamentPage.xaml
    /// </summary>
    public partial class TournamentPage : Page
    {
        public TournamentPage()
        {
            InitializeComponent();
            this.tournois.ItemsSource = Club.club.FamilyTournaments;
        }

        public void GoAddTournament(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new AddTournamentPage());
        }

        public void SupprimerSelectionnes(object sender, RoutedEventArgs args)
        {
            foreach (FamilyTournament row in new SortedSet<FamilyTournament>(this.tournois.SelectedItems.OfType<FamilyTournament>()))
            {
                Club.club.RemoveTournament(row);
            }
            this.tournois.ItemsSource = Club.club.FamilyTournaments;
        }

        public void Modifier(object sender, RoutedEventArgs args)
        {
            FamilyTournament obj = (FamilyTournament)((Button)args.Source).DataContext;
            this.NavigationService.Navigate(new AddTournamentPage(obj));
        }
    }
}
