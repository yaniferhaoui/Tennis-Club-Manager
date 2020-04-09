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
    /// Interaction logic for AddMemberPage.xaml
    /// </summary>
    public partial class AddMemberPage : Page
    {
        private Member member;
        private Type type = typeof(Member);
        public AddMemberPage()
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

            Array genders = Enum.GetValues(typeof(Gender));
            string[] descriptions2 = new string[genders.Length];
            for (int i = 0; i < genders.Length; i++)
            {
                descriptions2[i] = Enumerations.GetDescription((Enum)genders.GetValue(i));
            }
            this.genreComboBox.ItemsSource = descriptions2;
        }

        public AddMemberPage(Member member) : this()
        {
            this.type = typeof(Member);
            this.member = member;
            this.prenomTextBox.Text = this.member.FirstName;
            this.nomTextBox.Text = this.member.LastName;
            this.genreComboBox.SelectedItem = Enumerations.GetDescription((Enum)this.member.Gender);
            this.adresseTextBox.Text = this.member.Address.streetAddress;
            this.villeTextBox.Text = this.member.Address.city;
            this.codePostaleTextBox.Text = this.member.Address.postalCode.ToString();

            if (this.member.RegistrationType.Equals(RegistrationType.COMPETITION))
            {
                this.leisure.IsChecked = false;
                this.competition.IsChecked = true;
            }

            this.levelComboBox.SelectedItem = Enumerations.GetDescription((Enum)this.member.Level);
            this.birthdateCalendar.SelectedDate = this.member.BirthDate;
        }

        public AddMemberPage(Coach coach) : this((Member)coach)
        {
            this.type = typeof(Coach);
            this.EnableEmployee();
            ((StackPanel)this.status).Visibility = Visibility.Visible;
            if (coach.Status.Equals(Status.EMPLOYEE))
            {
                this.salary.IsChecked = true;
            }
            ((RadioButton)this.FindName("coach")).IsChecked = true;
            ((TextBox)this.FindName("ribTextBox")).Text = coach.RIB;
            ((TextBox)this.FindName("salaryTextBox")).Text = coach.Salary.ToString();
        }

        public AddMemberPage(Staff staff) : this((Member)staff)
        {
            this.type = typeof(Coach);
            this.EnableEmployee();
            ((RadioButton)this.FindName("staff")).IsChecked = true;
            ((TextBox)this.FindName("ribTextBox")).Text = staff.RIB;
            ((TextBox)this.FindName("salaryTextBox")).Text = staff.Salary.ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void GoAddMemberPage(object sender, RoutedEventArgs e)
        {
            if (this.member == null)
            {
                this.type = typeof(Member);
                this.UpdateButtons("AddEmployeeB", "AddMemberB");
                ((Label)this.FindName("ribLabel")).Visibility = Visibility.Hidden;
                ((TextBox)this.FindName("ribTextBox")).Visibility = Visibility.Hidden;
                ((TextBox)this.FindName("ribTextBox")).Text = "";
                ((Label)this.FindName("salaryLabel")).Visibility = Visibility.Hidden;
                ((TextBox)this.FindName("salaryTextBox")).Visibility = Visibility.Hidden;
                ((TextBox)this.FindName("salaryTextBox")).Text = "";
                ((StackPanel)this.FindName("job")).Visibility = Visibility.Hidden;
                ((StackPanel)this.FindName("status")).Visibility = Visibility.Hidden;
            }
            else
            {
                if (!this.member.GetType().Equals(typeof(Member)))
                {
                    MainWindow.message("Impossible de changer le type de ce membre: " + this.type.Name);
                }
            }
        }

        public void HideStatus(object sender, RoutedEventArgs args)
        {
            if (this.member == null)
            {
                ((StackPanel)this.FindName("status")).Visibility = Visibility.Hidden;
            }
            else
            {
                if (this.member.GetType().Equals(typeof(Coach)))
                {
                    ((RadioButton)this.FindName("coach")).IsChecked = true;
                    MainWindow.message("Impossible de changer le type de ce membre: " + this.type.Name);
                }
                else
                {
                    ((RadioButton)this.FindName("staff")).IsChecked = true;

                }
            }
        }

        public void ShowStatus(object sender, RoutedEventArgs args)
        {
            if (this.member == null)
            {
                ((StackPanel)this.FindName("status")).Visibility = Visibility.Visible;
            }
            else
            {
                if (this.member.GetType().Equals(typeof(Staff)))
                {
                    ((RadioButton)this.FindName("staff")).IsChecked = true;
                    MainWindow.message("Impossible de changer le type de ce membre: " + this.type.Name);
                }
                else
                {
                    ((RadioButton)this.FindName("coach")).IsChecked = true;
                }

            }
        }

        private void GoAddEmployeePage(object sender, RoutedEventArgs e)
        {
            if (this.member == null)
            {
                this.EnableEmployee();
                ((RadioButton)this.FindName("staff")).IsChecked = true;
            }
            else
            {
                if (this.member.GetType().Equals(typeof(Member)))
                {
                    MainWindow.message("Impossible de changer le type de ce membre: " + this.type.Name);
                }
            }
        }

        private void EnableEmployee()
        {
            this.UpdateButtons("AddMemberB", "AddEmployeeB");
            ((Label)this.FindName("ribLabel")).Visibility = Visibility.Visible;
            ((TextBox)this.FindName("ribTextBox")).Visibility = Visibility.Visible;
            ((Label)this.FindName("salaryLabel")).Visibility = Visibility.Visible;
            ((TextBox)this.FindName("salaryTextBox")).Visibility = Visibility.Visible;
            ((StackPanel)this.FindName("job")).Visibility = Visibility.Visible;
            this.type = typeof(Staff);
        }

        private void AddEmpoyee()
        {
            string rib = ((TextBox)this.FindName("ribTextBox")).Text;
            if (rib != null && !rib.Equals(""))
            {

                string salary = ((TextBox)this.FindName("salaryTextBox")).Text;
                if (salary != null && !salary.Equals(""))
                {
                    if (this.member != null)
                    {
                        ((Employee)this.member).RIB = rib;
                        ((Employee)this.member).Salary = int.Parse(salary);
                        if (this.member.GetType().Equals(typeof(Coach)))
                        {
                            ((Coach)this.member).Status = ((RadioButton)this.FindName("freelance")).IsChecked == true ? Status.FREELANCE : Status.EMPLOYEE;
                        }
                    }
                    else
                    {
                        if (this.type.Equals(typeof(Coach)))
                        {
                            this.AddNewCoach(rib, salary);
                        }
                        else
                        {
                            this.AddNewStaff(rib, salary);
                        }
                    }
                }
                else
                {
                    MainWindow.message("Veuillez remplir le Salaire !");
                }

            }
            else
            {
                MainWindow.message("Veuillez remplir le RIB !");
            }

        }

        private void AddNewCoach(string rib, string salary)
        {
            this.member = new Coach(this.birthdateCalendar.DisplayDate, //
                Enumerations.GetValueFromDescription<Gender>(this.genreComboBox.SelectedItem.ToString()), //
                this.prenomTextBox.Text, //
                this.nomTextBox.Text, //
                new Address(this.adresseTextBox.Text, this.villeTextBox.Text, int.Parse(this.codePostaleTextBox.Text)), //
                Enumerations.GetValueFromDescription<Level>(this.levelComboBox.SelectedItem.ToString()), rib, //
                int.Parse(salary), ((RadioButton)this.FindName("freelance")).IsChecked == true ? Status.FREELANCE : Status.EMPLOYEE);
            Club.club.AddCoach((Coach)this.member);
        }

        private void AddNewStaff(string rib, string salary)
        {
            this.member = new Staff(this.birthdateCalendar.DisplayDate, //
                Enumerations.GetValueFromDescription<Gender>(this.genreComboBox.SelectedItem.ToString()), //
                this.prenomTextBox.Text, //
                this.nomTextBox.Text, //
                new Address(this.adresseTextBox.Text, this.villeTextBox.Text, int.Parse(this.codePostaleTextBox.Text)), //
                Enumerations.GetValueFromDescription<Level>(this.levelComboBox.SelectedItem.ToString()), rib, //
                int.Parse(salary));
            Club.club.AddStaff((Staff)this.member);
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string prenom = this.prenomTextBox.Text;
            string nom = this.nomTextBox.Text;

            if (prenom != null && !prenom.Equals(""))
            {
                if (nom != null && !nom.Equals(""))
                {
                    if (this.adresseTextBox.Text != null && !this.adresseTextBox.Text.Equals(""))
                    {
                        if (this.villeTextBox.Text != null && !this.villeTextBox.Text.Equals(""))
                        {
                            if (this.codePostaleTextBox.Text != null && !this.codePostaleTextBox.Text.Equals(""))
                            {
                                if (this.birthdateCalendar.SelectedDate != null)
                                {
                                    if (birthdateCalendar.SelectedDate.Value.Date.CompareTo(DateTime.Now.Date) < 0)
                                    {
                                        Gender genre = Enumerations.GetValueFromDescription<Gender>(this.genreComboBox.SelectedItem.ToString());
                                        Address address = new Address(this.adresseTextBox.Text, this.villeTextBox.Text, int.Parse(this.codePostaleTextBox.Text));
                                        Level level = Enumerations.GetValueFromDescription<Level>(this.levelComboBox.SelectedItem.ToString());
                                        DateTime birthdate = this.birthdateCalendar.SelectedDate.Value;

                                        if (this.member != null)
                                        {
                                            this.member.FirstName = prenom;
                                            this.member.LastName = nom;
                                            this.member.Gender = genre;
                                            this.member.Address = address;
                                            this.member.Level = level;
                                            this.member.BirthDate = birthdate;

                                            if (typeof(Employee).IsAssignableFrom(this.member.GetType()))
                                            {
                                                this.AddEmpoyee();
                                            }
                                        }
                                        else
                                        {
                                            if (this.type.Equals(typeof(Member)))
                                            {
                                                this.member = new Member(birthdate, genre, prenom, nom,
                                                    new Address(this.adresseTextBox.Text, this.villeTextBox.Text, int.Parse(this.codePostaleTextBox.Text)), level);
                                                Club.club.AddMember(this.member);
                                            }
                                            else
                                            {
                                                this.AddEmpoyee();
                                            }

                                        }
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).UpdateButtons(typeof(ListMemberPage).Name);
                                        this.NavigationService.Navigate(new ListMemberPage());
                                    } else
                                    {
                                        MainWindow.message("Selectionnez une date antérieure à celle d'aujourd'hui !");
                                    }
                                }
                                else
                                {
                                    MainWindow.message("Selectionnez une date de naissance !");
                                }
                            }
                            else
                            {
                                MainWindow.message("Entrez le code postale !");
                            }
                        }
                        else
                        {
                            MainWindow.message("Entrez la ville !");
                        }
                    }
                    else
                    {
                        MainWindow.message("Entrez l'adresse !");
                    }
                }
                else
                {
                    MainWindow.message("Entrez le nom !");
                }
            }
            else
            {
                MainWindow.message("Entrez le prénom !");
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            if (this.member != null)
            {
                Club.club.RemoveMember(this.member);
            }
            ((MainWindow)System.Windows.Application.Current.MainWindow).UpdateButtons(typeof(ListMemberPage).Name);
            this.NavigationService.Navigate(new ListMemberPage());
        }

        public void UpdateButtons(string oldPage, string newPageName)
        {
            Button button = (Button)this.FindName(newPageName);
            button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#332b86"));

            Button button1 = (Button)this.FindName(oldPage);
            button1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#673ab7")); 
        }

        private void SelectLeisure(object sender, RoutedEventArgs e)
        {
            Label levelLabel = ((Label)this.FindName("levelLabel"));
            if (levelLabel != null)
            {
                levelLabel.Visibility = Visibility.Hidden;
                ((ComboBox)this.FindName("levelComboBox")).Visibility = Visibility.Hidden;
            }

        }

        private void SelectCompetition(object sender, RoutedEventArgs e)
        {
            ((Label)this.FindName("levelLabel")).Visibility = Visibility.Visible;
            ((ComboBox)this.FindName("levelComboBox")).Visibility = Visibility.Visible;
        }
    }
}
