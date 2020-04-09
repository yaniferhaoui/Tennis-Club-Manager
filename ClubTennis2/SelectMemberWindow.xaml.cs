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

namespace ClubTennis2
{
    /// <summary>
    /// Interaction logic for SelectMemberWindow.xaml
    /// </summary>
    public partial class SelectMemberWindow : Window
    {

        private Member member = null;
        private ISet<Member> theMembers = null;
        public SelectMemberWindow(DateTime date, ISet<Member> members, Member member = null)
        {
            InitializeComponent();
            this.members.ItemsSource = members;
            
            if (member != null)
            {
                this.member = member;
                this.members.SelectedItem = member;
            }
            this.listeLabel.Content = "Liste de tout Membres, Coachs, Staffs disponibles le " + date.ToString("dd/MM/yyyy");
        }

        public SelectMemberWindow(DateTime date, ISet<Member> members, ISet<Member> membersSelected = null)
        {
            InitializeComponent();
            this.members.ItemsSource = members;
            
            if (membersSelected != null)
            {
                this.theMembers = membersSelected;
            }
            this.members.SelectionMode = DataGridSelectionMode.Extended;
            this.listeLabel.Content = "Liste de tout Membres, Coachs, Staffs disponibles le " + date.ToString("dd/MM/yyyy");
        }

        public void Ajouter(object sender, RoutedEventArgs args)
        {
            if (this.members.SelectionMode.Equals(DataGridSelectionMode.Single))
            {
                if (this.members.SelectedItem != null)
                {
                    this.member = (Member)this.members.SelectedItem;
                }
            } else
            {
                if (this.members.SelectedItems != null)
                {
                    foreach(Member member in this.members.SelectedItems)
                    {
                        this.theMembers.Add(member);
                    }
                }
            }
            
            this.Close();
        }

        public void Annuler(object sender, RoutedEventArgs args)
        {
            this.Close();
        }

        // Getter
        public Member GetMember()
        {
            return this.member;
        }

        public ISet<Member> GetMembers()
        {
            return this.theMembers;
        }
    }
}
