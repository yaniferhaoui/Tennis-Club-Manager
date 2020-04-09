using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace ClubTennis2
{
    /// <summary>
    /// Interaction logic for AddTeamMatchPage.xaml
    /// </summary>
    public partial class AddTeamMatchPage : Page
    {
        private AddCompetitionPage page;
        private Member member1;
        private Member member2;
        private DateTime start;
        private DateTime end;
        private DateTime date;
        private TeamMatch teamMatch;

        public AddTeamMatchPage(AddCompetitionPage page)
        {
            InitializeComponent();
            this.page = page;
            this.start = DateTime.Now.Date;
            this.end = DateTime.Now.AddYears(2000);
        }

        public AddTeamMatchPage(AddCompetitionPage page, Competition competition)
        {
            InitializeComponent();
            this.page = page;
            this.start = competition.Start;
            this.end = competition.End;
        }

        public void ModifierJ1(object sender, RoutedEventArgs args)
        {
            if (this.dateCalendar.SelectedDate != null)
            {
                if (this.dateCalendar.Visibility.Equals(Visibility.Hidden))
                {
                    ISet<Member> members;
                    if (this.member2 == null)
                    {
                        members = Club.club.GetAvailableCompetitors(this.dateCalendar.SelectedDate.Value);
                    } else
                    {
                        members = Club.club.GetAvailableCompetitors(this.dateCalendar.SelectedDate.Value, this.member2);
                    }

                    SelectMemberWindow wind =
                        new SelectMemberWindow(this.dateCalendar.SelectedDate.Value, members, this.member1);
                    wind.ShowDialog();
                    this.member1 = wind.GetMember();

                    if (this.member1 != null)
                    {
                        this.j1.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.j1.Content = this.member1.FirstName + " " + this.member1.LastName;
                        }));
                    }
                }
                else
                {
                    MainWindow.message("Veuillez valider la date !");
                }
            }
            else
            {
                MainWindow.message("Selectionner une date avant !");
            }
        }

        public void ModifierJ2(object sender, RoutedEventArgs args)
        {
            if (this.dateCalendar.SelectedDate != null)
            {
                if (this.dateCalendar.Visibility.Equals(Visibility.Hidden))
                {
                    ISet<Member> members;
                    if (this.member1 == null)
                    {
                        members = Club.club.GetAvailableCompetitors(this.dateCalendar.SelectedDate.Value);
                    }
                    else
                    {
                        members = Club.club.GetAvailableCompetitors(this.dateCalendar.SelectedDate.Value, this.member1);
                    }

                    SelectMemberWindow wind =
                        new SelectMemberWindow(this.dateCalendar.SelectedDate.Value, members, this.member2);

                    wind.ShowDialog();
                    this.member2 = wind.GetMember();

                    if (this.member2 != null)
                    {
                        this.j2.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.j2.Content = this.member2.FirstName + " " + this.member2.LastName;
                        }));
                    }
                }
                else
                {
                    MainWindow.message("Veuillez valider la date !");
                }
            }
            else
            {
                MainWindow.message("Selectionner une date avant !");
            }

        }

        public void ModifierDate(object sender, RoutedEventArgs args)
        {
            this.member1 = null;
            this.member2 = null;
            this.j1.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.j1.Content = "Inconnu";
            }));
            this.j2.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.j2.Content = "Inconnu";
            }));
            this.dateLabel.Visibility = Visibility.Hidden;
            this.modifierDate.Visibility = Visibility.Hidden;
            this.dateCalendar.Visibility = Visibility.Visible;
            this.validerDate.Visibility = Visibility.Visible;
        }

        public void ValiderDate(object sender, RoutedEventArgs args)
        {
            if (this.dateCalendar.SelectedDate != null)
            {
                if (this.start.CompareTo(this.dateCalendar.SelectedDate.Value) <= 0)
                {
                    if (this.end.CompareTo(this.dateCalendar.SelectedDate.Value) >= 0)
                    {
                        this.date = this.dateCalendar.SelectedDate.Value;
                        this.dateLabel.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.dateLabel.Content = this.dateCalendar.SelectedDate.Value.ToString();
                            this.dateLabel.Visibility = Visibility.Visible;
                        }));
                        this.modifierDate.Visibility = Visibility.Visible;

                        this.dateCalendar.Visibility = Visibility.Hidden;
                        this.validerDate.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        MainWindow.message("Selectionner une date avant : " + this.end);
                    }
                }
                else
                {
                    MainWindow.message("Selectionner une date après : " + this.start);
                }
            }
            else
            {
                MainWindow.message("Selectionner une date avant !");
            }
        }

        public void Ajouter(object sender, RoutedEventArgs args)
        {
            if (this.dateCalendar.SelectedDate != null)
            {
                if (this.dateCalendar.Visibility.Equals(Visibility.Hidden))
                {
                    if (this.member1 != null)
                    {
                        if (this.member2 != null)
                        {
                            if (this.simple.IsSelected == true)
                            {
                                this.teamMatch = new TeamMatch(this.member1, this.member2, this.date);
                            }
                            else
                            {
                                this.teamMatch = new TeamMatch(new Binome(this.member1, this.member2), this.date);
                            }
                            this.page.AddMatch(this.teamMatch);
                            this.NavigationService.Navigate(page);
                        }
                        else
                        {
                            MainWindow.message("Veuillez selectionner un Membre 2 !");
                        }
                    }
                    else
                    {
                        MainWindow.message("Veuillez selectionner un Membre 1 !");
                    }
                }
                else
                {
                    MainWindow.message("Veuillez valider la date !");
                }
            } else
            {
                MainWindow.message("Selectionner une date avant !");
            } 
        }

        public void Annuler(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(page);
        }
    }
}
