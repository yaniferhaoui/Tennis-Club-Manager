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
    /// Interaction logic for CompetitionPage.xaml
    /// </summary>
    public partial class CompetitionPage : Page
    {
        public CompetitionPage()
        {
            InitializeComponent();
            this.competitions.ItemsSource = Club.club.Competitions;
        }

        public void GoAddCompetition(object sender, RoutedEventArgs args)
        {
            //((MainWindow)System.Windows.Application.Current.MainWindow).UpdateButtons(typeof(AddCompetitionPage).Name);
            this.NavigationService.Navigate(new AddCompetitionPage());
        }

        public void SupprimerSelectionnes(object sender, RoutedEventArgs args)
        {
            foreach (Competition row in new SortedSet<Competition>(this.competitions.SelectedItems.OfType<Competition>()))
            {
                Club.club.RemoveCompetition(row);
            }
            this.competitions.ItemsSource = Club.club.Competitions;
        }

        public void Modifier(object sender, RoutedEventArgs args)
        { 
            Competition obj = (Competition)((Button)args.Source).DataContext;
            this.NavigationService.Navigate(new AddCompetitionPage(obj));
        }
    }
}
