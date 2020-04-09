using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AddTournamentPage.xaml
    /// </summary>
    public partial class AddTournamentPage : Page
    {

        private FamilyTournament tournament;
        private ISet<Member> theMembers;

        public AddTournamentPage()
        {
            InitializeComponent();
            this.theMembers = new SortedSet<Member>();
            this.theDate.Visibility = Visibility.Hidden;
        }

        public AddTournamentPage(FamilyTournament tournament)
        {
            InitializeComponent();
            this.tournament = tournament;
            this.theMembers = tournament.GetMembersList();
            this.members.ItemsSource = tournament.GetMembersList();
            this.debutCompetitionCalendar.Visibility = Visibility.Hidden;
            this.validerB.Visibility = Visibility.Hidden;
            this.modifierDate.Visibility = Visibility.Visible;
            this.nomTextBox.Text = tournament.Name;
            this.debutCompetitionCalendar.SelectedDate = tournament.GetStart();
            this.theDate.Content = this.tournament.Start.ToString("dd/MM/yyyy");
        }

        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        public void AjouterMembre(object sender, RoutedEventArgs args)
        {
            if (this.debutCompetitionCalendar.SelectedDate != null)
            {
                if (this.validerB.Visibility.Equals(Visibility.Hidden))
                {
                    SelectMemberWindow wind = new SelectMemberWindow(this.debutCompetitionCalendar.SelectedDate.Value,
                            Club.club.GetAvailableMembers(this.debutCompetitionCalendar.SelectedDate.Value), this.theMembers);
                    wind.ShowDialog();

                    foreach(Member member in new SortedSet<Member>(wind.GetMembers()))
                    {
                        this.theMembers.Add(member);
                        this.members.ItemsSource = this.theMembers;
                        this.members.Items.Refresh();
                    }
                    
                }
                else
                {
                    MainWindow.message("Veuillez valider la date avant !");
                }
            }
            else
            {
                MainWindow.message("Selectionnez une date avant !");
            }

        }

        public void ValiderDate(object sender, RoutedEventArgs args)
        {
            if (this.debutCompetitionCalendar.SelectedDate != null)
            {
                if (this.debutCompetitionCalendar.SelectedDate.Value.CompareTo(DateTime.Now) > 0)
                {
                    this.debutCompetitionCalendar.Visibility = Visibility.Hidden;
                    this.validerB.Visibility = Visibility.Hidden;
                    this.modifierDate.Visibility = Visibility.Visible;
                    this.theDate.Visibility = Visibility.Visible;
                    this.theDate.Content = this.debutCompetitionCalendar.SelectedDate.Value.ToString("dd/MM/yyyy");
                } else
                {
                    MainWindow.message("Non le tournoi doit avoir lieu demain au plus tôt !");
                }
            }
            else
            {
                MainWindow.message("Selectionnez une date avant !");
            }
        }

        public void ModifierDate(object sender, RoutedEventArgs args)
        {
            this.theMembers = new SortedSet<Member>();
            this.members.ItemsSource = this.theMembers;

            this.debutCompetitionCalendar.Visibility = Visibility.Visible;
            this.validerB.Visibility = Visibility.Visible;
            this.modifierDate.Visibility = Visibility.Hidden;
            this.theDate.Visibility = Visibility.Hidden;
        }

        public void SupprimerMembre(object sender, RoutedEventArgs args)
        {
            Member member = (Member)((Button)sender).DataContext;
            this.theMembers.Remove(member);
            this.members.ItemsSource = this.theMembers;
        }

        public void SupprimerSelectionnes(object sender, RoutedEventArgs args)
        {
            foreach (Member member in new SortedSet<Member>(this.members.SelectedItems.OfType<Member>()))
            {
                this.theMembers.Remove(member);
                this.members.ItemsSource = this.theMembers;
            }
        }

        public void AjouterModifier(object sender, RoutedEventArgs args)
        {
            if (this.debutCompetitionCalendar.SelectedDate != null)
            {
                if (this.validerB.Visibility.Equals(Visibility.Hidden))
                {
                    if (this.nomTextBox.Text != null && !this.nomTextBox.Text.Equals(""))
                    {
                        if (this.CountCoach() > 1)
                        {
                            if (this.tournament != null)
                            {
                                this.tournament.Name = this.nomTextBox.Text;
                                this.tournament.Start = this.debutCompetitionCalendar.SelectedDate.Value;
                                this.tournament.SetMembers(this.theMembers);
                            } else
                            {
                                FamilyTournament tournament = new FamilyTournament(this.nomTextBox.Text, this.debutCompetitionCalendar.SelectedDate.Value);
                                tournament.SetMembers(this.theMembers);
                                Club.club.AddTournament(tournament);
                            }
                            this.NavigationService.Navigate(new TournamentPage());
                        } else
                        {
                            MainWindow.message("Il faut au moins 2 Coachs !");
                        }
                    } else
                    {
                        MainWindow.message("Remplissez le nom avant !");
                    }
                } else
                {
                    MainWindow.message("Valider la date avant !");
                }
            } else
            {
                MainWindow.message("Selectionnez une date avant !");
            }
        }

        private int CountCoach()
        {
            int i = 0;
            foreach(Member member in this.theMembers)
            {
                if (member is Coach)
                {
                    i++;
                }
            }
            return i;
        }

        public void Annuler(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new TournamentPage());
        }
    }
}
