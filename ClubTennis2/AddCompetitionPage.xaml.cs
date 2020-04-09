using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    /// <summary>
    /// Interaction logic for AddCompetitionPage.xaml
    /// </summary>
    public partial class AddCompetitionPage : Page
    {

        private Competition competition = null;
        private ISet<TeamMatch> matches;

        public AddCompetitionPage()
        {
            InitializeComponent();
            Array levels = Enum.GetValues(typeof(Level));
            string[] descriptions1 = new string[levels.Length];
            for (int i = 0; i < levels.Length; i++)
            {
                descriptions1[i] = Enumerations.GetDescription((Enum)levels.GetValue(i));
            }
            this.levelComboBox.ItemsSource = descriptions1;
            this.levelComboBox.SelectedItem = Enumerations.GetDescription((Enum)Level.A);
            this.matches = new SortedSet<TeamMatch>();
            this.teamMatches.ItemsSource = this.matches;
        }

        public AddCompetitionPage(Competition competition) : this()
        {
            this.competition = competition;
            this.nomTextBox.Text = this.competition.Name;
            this.prixTextBox.Text = this.competition.Price.ToString();
            this.levelComboBox.SelectedItem = Enumerations.GetDescription((Enum)this.competition.Level);
            //this.debutCompetitionCalendar.SelectedDate = this.competition.Start;
            //this.finCompetitionCalendar.SelectedDate = this.competition.End;
            this.matches = competition.Matches;
            this.teamMatches.ItemsSource = this.matches;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void AjouterModifier(object sender, RoutedEventArgs args)
        {
            if (this.nomTextBox.Text != null && !this.nomTextBox.Text.Equals(""))
            {
                if (this.prixTextBox.Text != null && !this.prixTextBox.Text.Equals(""))
                {


                    /*if (this.debutCompetitionCalendar.SelectedDate != null)
                    {
                        if (this.finCompetitionCalendar.SelectedDate != null)
                        {
                            DateTime start = this.debutCompetitionCalendar.SelectedDate.Value;
                            DateTime end = this.finCompetitionCalendar.SelectedDate.Value;
                            if (DateTime.Compare(start, end) <= 0)
                            {*/
                    if (this.competition == null)
                    {
                        this.competition = new Competition(this.nomTextBox.Text, //
                                            Enumerations.GetValueFromDescription<Level>(this.levelComboBox.SelectedItem.ToString()),
                                            int.Parse(this.prixTextBox.Text));
                        foreach (TeamMatch teamMatch in this.matches)
                        {
                            this.competition.AddTeamMatch(teamMatch);
                        }
                        Club.club.AddCompetition(this.competition);
                    }
                    else
                    {
                        this.competition.Name = this.nomTextBox.Text;
                        //this.competition.Start = start.Date;
                        //this.competition.End = end.Date.AddDays(1).AddTicks(-1);
                        this.competition.Level = Enumerations.GetValueFromDescription<Level>(this.levelComboBox.SelectedItem.ToString());
                        this.competition.Price = int.Parse(this.prixTextBox.Text);
                    }
                    this.NavigationService.Navigate(new CompetitionPage());
                    /*}
                    else
                    {
                        MainWindow.message("La date de fin ne peut pas être avant la date de début !");
                    }
                } else
                {
                    MainWindow.message("Entrez une date de fin !");
                }
            } else
            {
                MainWindow.message("Entrez une date de début !");
            }*/
                }
                else
                {
                    MainWindow.message("Entrez le prix de la compétition !");
                }
            }
            else
            {
                MainWindow.message("Entrez le nom de la compétition !");
            }
        }

        public void GoAddTeam(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new AddTeamMatchPage(this));
        }

        public void SupprimerSelectionnes(object sender, RoutedEventArgs args)
        {
            IEnumerable<TeamMatch> teamMatchesB = new SortedSet<TeamMatch>(this.teamMatches.SelectedItems.OfType<TeamMatch>());
            if (this.competition == null)
            {

                foreach (TeamMatch teamMatch in teamMatchesB)
                {
                    this.matches.Remove(teamMatch);
                }
            }
            else
            {
                foreach (TeamMatch teamMatch in teamMatchesB)
                {
                    competition.Matches.Remove(teamMatch);
                }
                this.matches = competition.Matches;
            }
            this.teamMatches.ItemsSource = this.matches;
            this.teamMatches.Items.Refresh();
        }

        public void Annuler(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new CompetitionPage());
        }

        public void AddMatch(TeamMatch teamMatch)
        {
            this.matches.Add(teamMatch);
            this.teamMatches.ItemsSource = this.matches;
        }
    }
}
