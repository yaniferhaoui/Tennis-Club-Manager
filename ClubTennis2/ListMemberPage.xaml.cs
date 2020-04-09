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
    /// Interaction logic for ListMemberPage.xaml
    /// </summary>
    public partial class ListMemberPage : Page
    {
        public ListMemberPage()
        {
            InitializeComponent();
            this.members.ItemsSource = Club.club.AllMember;
        }

        public void UpdateFilter(object sender, RoutedEventArgs e)
        {
            ISet<Member> members;
            // Fourth Filter
            if (this.FindName("employees") != null && ((RadioButton)this.FindName("employees")).IsChecked == true)
            {
                members = new SortedSet<Member>();
                foreach (Coach coach in Club.club.Coachs)
                {
                    members.Add(coach);
                }
                foreach (Staff staff in Club.club.Staffs)
                {
                    members.Add(staff);
                }
            }
            else if (this.FindName("onlyMembers") != null && ((RadioButton)this.FindName("onlyMembers")).IsChecked == true)
            {
                members = Club.club.Members;

            } else
            {
                members = Club.club.AllMember;
            }

            // First Filter
            if (this.FindName("leisure") != null && ((RadioButton)this.FindName("leisure")).IsChecked == true)
            {
                foreach (Member member in new SortedSet<Member>(members))
                {
                    if (member.RegistrationType != Enumerations.RegistrationType.LEISURE)
                    {
                        members.Remove(member);
                    }
                }
            }
            else if (this.FindName("competition") != null && ((RadioButton)this.FindName("competition")).IsChecked == true)
            {
                foreach (Member member in new SortedSet<Member>(members))
                {
                    if (member.RegistrationType != Enumerations.RegistrationType.COMPETITION)
                    {
                        members.Remove(member);
                    }
                }
            }

            // Second Filter
            if (this.FindName("paid") != null && ((RadioButton)this.FindName("paid")).IsChecked == true)
            {
                foreach (Member member in new SortedSet<Member>(members))
                {
                    if (!member.SubscriptionPaidThidYear)
                    {
                        members.Remove(member);
                    }
                }
            }
            else if (this.FindName("notPaid") != null && ((RadioButton)this.FindName("notPaid")).IsChecked == true)
            {
                foreach (Member member in new SortedSet<Member>(members))
                {
                    if (member.SubscriptionPaidThidYear)
                    {
                        members.Remove(member);
                    }
                }
            }

            // Third Filter
            if (this.FindName("gender") != null && ((RadioButton)this.FindName("gender")).IsChecked == true)
            {
                members = new SortedSet<Member>(members, new GenderComparator());

            }
            else if (this.FindName("ranking") != null && ((RadioButton)this.FindName("ranking")).IsChecked == true)
            {
                members = new SortedSet<Member>(members, new RankingComparator());
            }

            if (this.members != null)
            {
                this.members.ItemsSource = members;
            }
        }

        private void Modifier(object sender, RoutedEventArgs args)
        {
            Member member = (Member)((Button)sender).DataContext;
            if (member.GetType().Equals(typeof(Staff)))
            {
                this.NavigationService.Navigate(new AddMemberPage((Staff)member));
            }
            else if (member.GetType().Equals(typeof(Coach)))
            {
                this.NavigationService.Navigate(new AddMemberPage((Coach)member));
            }
            else
            {
                this.NavigationService.Navigate(new AddMemberPage(member));
            }
            ((MainWindow)System.Windows.Application.Current.MainWindow).UpdateButtons(typeof(AddMemberPage).Name);
        }

        public void SupprimerSelectionnes(object sender, RoutedEventArgs args)
        {
            foreach (Member row in new SortedSet<Member>(this.members.SelectedItems.OfType<Member>()))
            {
                Club.club.RemoveMember(row);
            }
            this.UpdateFilter(sender, args);
        }
    }
}
