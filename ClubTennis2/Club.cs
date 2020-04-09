using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Club
    {

        // There is only one club in this program
        public static readonly Club club = new Club("CST".ToUpper(), "Courbevoie".ToUpper());

        // About the club
        private string name;
        private string city;
        private ISet<Member> members = new SortedSet<Member>();
        private ISet<Coach> coachs = new SortedSet<Coach>();
        private ISet<Staff> staffs = new SortedSet<Staff>();
        private ISet<Competition> competitions = new SortedSet<Competition>(new CompetitionLevelComparator());
        private ISet<FamilyTournament> tournaments = new SortedSet<FamilyTournament>();
        private ISet<TennisClinic> tennisClinics = new SortedSet<TennisClinic>();
        private ISet<MemberReservation> reservations = new SortedSet<MemberReservation>();

        private Club(string name, string city)
        {
            this.name = name;
            this.city = city;

            //"yyyy-MM-dd HH:mm tt"

            // Members
            Address address1 = new Address("3 rue de roq", "Courbevoie", 92400);
            Member member1 = new Member(DateTime.ParseExact("12-04-1998", "dd-MM-yyyy", null), Gender.MALE, "Louis", "Dupond", address1);

            Address address2 = new Address("9 rue Jean De La Fontaine", "Cergy", 95000);
            Member member2 = new Member(DateTime.ParseExact("18-06-1994", "dd-MM-yyyy", null), Gender.MALE, "Benjamin", "Petit", address2);

            Address address3 = new Address("12 rue la fosse", "Saint-Jean", 84000);
            Member member3 = new Member(DateTime.ParseExact("22-10-1992", "dd-MM-yyyy", null), Gender.MALE, "Mark", "Gerard", address3, Level.B);

            Address address4 = new Address("19B rue du pré", "Cergy", 95000);
            Member member4 = new Member(DateTime.ParseExact("02-06-1999", "dd-MM-yyyy", null), Gender.MALE, "Matthieu", "Leval", address4, Level.H);

            Address address5 = new Address("12 rue de roq", "Courbevoie", 92400);
            Member member5 = new Member(DateTime.ParseExact("06-09-1991", "dd-MM-yyyy", null), Gender.MALE, "Paul", "Grandin", address5, Level.B);

            Address address6 = new Address("220 avenue Pascal Grand", "Courbevoie", 92400);
            Member member6 = new Member(DateTime.ParseExact("01-08-1990", "dd-MM-yyyy", null), Gender.MALE, "Thomas", "Boscard", address6, Level.H);
            member6.SubscriptionPaidThidYear = true;

            Address address7 = new Address("8 rue de la fete", "Colombes", 92700);
            Member member7 = new Member(DateTime.ParseExact("16-10-1995", "dd-MM-yyyy", null), Gender.MALE, "Paul", "Le Grand", address7, Level.D);

            Address address8Z = new Address("18 rue de la fete", "Paris", 75000);
            Member member8 = new Member(DateTime.ParseExact("08-10-1995", "dd-MM-yyyy", null), Gender.MALE, "Tristan", "Gallois", address8Z, Level.K);

            Address address8A = new Address("4 rue du pret", "Colombes", 92700);
            Member member8A = new Member(DateTime.ParseExact("15-11-1990", "dd-MM-yyyy", null), Gender.FEMALE, "Françoise", "Frankon", address8A, Level.G);

            Address address8B = new Address("43 bis rue Medical", "Courbevoie", 92400);
            Member member8B = new Member(DateTime.ParseExact("11-07-1998", "dd-MM-yyyy", null), Gender.FEMALE, "Océane", "Görke", address8B, Level.I);

            Address address8C = new Address("22 rue du Tsini", "Courbevoie", 92400);
            Member member8C = new Member(DateTime.ParseExact("04-06-1997", "dd-MM-yyyy", null), Gender.FEMALE, "Manon", "Foulon", address8C, Level.K);

            Address address8D = new Address("2 rue de la sarguette", "Colombes", 92700);
            Member member8D = new Member(DateTime.ParseExact("03-05-1987", "dd-MM-yyyy", null), Gender.FEMALE, "Sophie", "Duret", address8D, Level.G);

            Address address8E = new Address("22 rue Jean", "Colombes", 92700);
            Member member8E = new Member(DateTime.ParseExact("12-10-1988", "dd-MM-yyyy", null), Gender.FEMALE, "Anne", "DuCoin", address8E, Level.I);

            Address address8F = new Address("11 rue du Cleber", "Colombes", 92700);
            Member member8F = new Member(DateTime.ParseExact("18-01-1984", "dd-MM-yyyy", null), Gender.MALE, "Yani", "Ferhaoui", address8F, Level.H);

            this.members.Add(member1);
            this.members.Add(member2);
            this.members.Add(member3);
            this.members.Add(member4);
            this.members.Add(member5);
            this.members.Add(member6);
            this.members.Add(member7);
            this.members.Add(member8);
            this.members.Add(member8A);
            this.members.Add(member8B);
            this.members.Add(member8C);
            this.members.Add(member8D);
            this.members.Add(member8E);
            this.members.Add(member8F);

            // Coachs
            Address address8 = new Address("18 rue de la fete", "Colombes", 92700);
            Coach coach1 = new Coach(DateTime.ParseExact("16-03-1995", "dd-MM-yyyy", null), Gender.MALE, "Tom", "Ferrard", address8, Level.N, "X1X", 1250, Status.FREELANCE);

            Address address9 = new Address("28 rue du puit", "Courbevoie", 92400);
            Coach coach2 = new Coach(DateTime.ParseExact("26-07-1995", "dd-MM-yyyy", null), Gender.MALE, "Raphael", "Mangin", address9, Level.N, "X2X", 1350, Status.EMPLOYEE);

            Address address10 = new Address("7 rue everest", "Courbevoie", 92400);
            Coach coach3 = new Coach(DateTime.ParseExact("01-04-1990", "dd-MM-yyyy", null), Gender.MALE, "Morgan", "Palier", address10, Level.N, "X3X", 1350, Status.EMPLOYEE);

            Address address10A = new Address("18 rue du mont everest", "Achères-Ville", 82150);
            Coach coach3A = new Coach(DateTime.ParseExact("15-07-1985", "dd-MM-yyyy", null), Gender.FEMALE, "Sarah", "Legendre", address10A, Level.I, "X4X", 1350, Status.EMPLOYEE);

            Address address10B = new Address("2 rue de la bretonnerie", "Orléans", 45000);
            Coach coach3B = new Coach(DateTime.ParseExact("11-12-1992", "dd-MM-yyyy", null), Gender.FEMALE, "Victoria", "Alber", address10B, Level.H, "X5X", 1100, Status.EMPLOYEE);

            Address address10C = new Address("12 rue saint jacques", "Tours", 37000);
            Coach coach3C = new Coach(DateTime.ParseExact("28-08-1972", "dd-MM-yyyy", null), Gender.MALE, "Antoine", "Serein", address10C, Level.I, "X6X", 1350, Status.FREELANCE);

            Address address10D = new Address("2 rue de la guetté", "Pontoise", 95000);
            Coach coach3D = new Coach(DateTime.ParseExact("24-04-1995", "dd-MM-yyyy", null), Gender.FEMALE, "Bernadette", "Franc", address10D, Level.H, "X7X", 1300, Status.EMPLOYEE);

            Address address10E = new Address("7 rue everest", "Courbevoie", 92400);
            Coach coach3E = new Coach(DateTime.ParseExact("08-02-1999", "dd-MM-yyyy", null), Gender.MALE, "Jean", "Jacques", address10E, Level.K, "X7X", 1550, Status.FREELANCE);

            this.coachs.Add(coach1);
            this.coachs.Add(coach2);
            this.coachs.Add(coach3);
            this.coachs.Add(coach3A);
            this.coachs.Add(coach3B);
            this.coachs.Add(coach3C);
            this.coachs.Add(coach3D);
            this.coachs.Add(coach3E);

            // Staff
            Address address11 = new Address("4 rue du Général", "Colombes", 92700);
            Staff staff1 = new Staff(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", address11, "X8X", 1500);

            Address address12 = new Address("14 avenue Grandmont", "Courbevoie", 92400);
            Staff staff2 = new Staff(DateTime.ParseExact("08-12-1984", "dd-MM-yyyy", null), Gender.MALE, "Pascal", "Carloire", address12, "X9X", 1600);

            Address address12A = new Address("52 rue de la prairie", "Cergy", 95000);
            Staff staff3 = new Staff(DateTime.ParseExact("12-05-1984", "dd-MM-yyyy", null), Gender.FEMALE, "Louise", "Patrona", address12A, "X10X", 1500);

            Address address12B = new Address("1 bis rue de la gloire", "Courbevoie", 92400);
            Staff staff4 = new Staff(DateTime.ParseExact("08-09-1982", "dd-MM-yyyy", null), Gender.FEMALE, "Fleure", "Celestin", address12B, "X11X", 1100);

            this.staffs.Add(staff1);
            this.staffs.Add(staff2);
            this.staffs.Add(staff3);
            this.staffs.Add(staff4);

            // Competition
            Competition competition1 = CreateCompetition("ATP CUP", Level.A, 10);
            Competition competition2 = CreateCompetition("Open Paris", Level.D, 20);
            Competition competition3 = CreateCompetition("Open Strasbourg", Level.H, 15);
            Competition competition4 = CreateCompetition("Open d'Australie", Level.N, 20);
            Competition competition5 = CreateCompetition("Wimbledon", Level.A, 10);
            Competition competition6 = CreateCompetition("US Open", Level.D, 5);
            Competition competition7 = CreateCompetition("Indian Wells", Level.G, 90);
            Competition competition8 = CreateCompetition("Monte-Carlo", Level.F, 65);
            Competition competition9 = CreateCompetition("Rome", Level.I, 7);
            Competition competition10 = CreateCompetition("Hambourg", Level.J, 10);
            Competition competition11 = CreateCompetition("Toronto", Level.B, 10);
            Competition competition12 = CreateCompetition("Madrid", Level.K, 75);
            this.competitions.Add(competition1);
            this.competitions.Add(competition2);
            this.competitions.Add(competition3);
            this.competitions.Add(competition4);
            this.competitions.Add(competition5);
            this.competitions.Add(competition6);
            this.competitions.Add(competition7);
            this.competitions.Add(competition8);
            this.competitions.Add(competition9);
            this.competitions.Add(competition10);
            this.competitions.Add(competition11);
            this.competitions.Add(competition12);

            FamilyTournament f1 = new FamilyTournament("Tournoi des Amis", DateTime.Now.AddDays(9).Date);
            FamilyTournament f2 = new FamilyTournament("Tournoi des Amoureux", DateTime.Now.AddDays(19).Date);
            FamilyTournament f3 = new FamilyTournament("Wilberg", DateTime.Now.AddDays(99).Date);
            FamilyTournament f4 = new FamilyTournament("Tsini", DateTime.Now.AddDays(27).Date);
            FamilyTournament f5 = new FamilyTournament("Tournoi des Famille", DateTime.Now.AddDays(78).Date);
            FamilyTournament f6 = new FamilyTournament("Tournoi des Anciens", DateTime.Now.AddDays(34).Date);
            FamilyTournament f7 = new FamilyTournament("Equipes", DateTime.Now.AddDays(77).Date);
            FamilyTournament f8 = new FamilyTournament("Ultimate", DateTime.Now.AddDays(66).Date);
            FamilyTournament f9 = new FamilyTournament("La Toulousaine", DateTime.Now.AddDays(89).Date);
            FamilyTournament f10 = new FamilyTournament("Nouvelle année", DateTime.Now.AddDays(33).Date);
            FamilyTournament f11 = new FamilyTournament("Tournoi de consolations", DateTime.Now.AddDays(20).Date);
            FamilyTournament f12 = new FamilyTournament("Les Nouveaux", DateTime.Now.AddDays(13).Date);
            FamilyTournament f13 = new FamilyTournament("Tournoi des Amis N°2", DateTime.Now.AddDays(330).Date);
            FamilyTournament f14 = new FamilyTournament("Tournoi des jeunes", DateTime.Now.AddDays(200).Date);
            FamilyTournament f15 = new FamilyTournament("Auxbourg", DateTime.Now.AddDays(130).Date);
            this.tournaments.Add(f1);
            this.tournaments.Add(f2);
            this.tournaments.Add(f3);
            this.tournaments.Add(f4);
            this.tournaments.Add(f5);
            this.tournaments.Add(f6);
            this.tournaments.Add(f7);
            this.tournaments.Add(f8);
            this.tournaments.Add(f9);
            this.tournaments.Add(f10);
            this.tournaments.Add(f11);
            this.tournaments.Add(f12);
            this.tournaments.Add(f13);
            this.tournaments.Add(f14);
            this.tournaments.Add(f15);

            // Création de binome pour les compétitions
            ISet<Binome> teams = new SortedSet<Binome>();
            foreach (Member memberA in this.AllMember)
            {
                foreach (Member memberB in this.AllMember)
                {
                    if (!memberA.Equals(memberB) && memberA.Level.Equals(memberB.Level))
                    {

                        Binome bin = new Binome(memberA, memberB);
                        if (!teams.Contains(bin) && !teams.Contains(new Binome(memberB, memberA)))
                        {
                            teams.Add(bin);
                        }
                    }
                }
            }

            // Ajout de binome dans les compétitions si les conditions requises le permettent
            Random rnd = new Random();
            foreach (Binome bin in teams)
            {
                foreach (Competition competition in this.competitions)
                {

                    if (Convert.ToInt32(bin.Member1.Level) <= Convert.ToInt32(competition.Level))
                    {
                        DateTime time = DateTime.Now.AddDays(rnd.Next(100));
                        DateTime end = time.AddDays(rnd.Next(50));
                        while (time < end)
                        {
                            if (this.areFreeThisDay(bin, time))
                            {
                                if (rnd.Next(0, 3) != 0)
                                {
                                    if (rnd.Next(0, 2) == 0)
                                    {
                                        competition.AddTeamMatch(new TeamMatch(bin, time));
                                        break;
                                    }
                                    else
                                    {
                                        competition.AddTeamMatch(new TeamMatch(bin.Member1, bin.Member2, time));
                                        break;
                                    }
                                }

                            }
                            time = time.AddDays(1);
                        }
                    }
                }
            }

            // Ajout de Member dans les Tournois
            foreach (FamilyTournament tournament in this.tournaments)
            {
                foreach (Member member in new HashSet<Member>(this.members))
                {
                    if (this.isFreeThisDay(member, tournament.Start.AddHours(1)))
                    {
                        if (rnd.Next(0, 3) != 0)
                        {
                            tournament.AddMember(member);
                        }
                    }
                }

                foreach (Coach coach in new HashSet<Coach>(this.coachs))
                {
                    if (this.isFreeThisDay(coach, tournament.Start.AddHours(1)))
                    {
                        if (tournament.SizeCoach > 1)
                        {
                            if (rnd.Next(0, tournament.SizeCoach*tournament.SizeCoach) != 0)
                            {
                                tournament.AddMember(coach);
                            }
                        }
                        else
                        {
                            tournament.AddMember(coach);
                        }

                    }
                }

            }
        }

        private static Competition CreateCompetition(string name, Level level, int price)
        {
            return new Competition(name, level, price);
        }

        public bool areFreeThisDay(Binome bin, DateTime date)
        {
            return this.isFreeThisDay(bin.Member1, date) && this.isFreeThisDay(bin.Member2, date);
        }

        public bool isFreeThisDay(Member member1, DateTime date)
        {
            foreach (Event e in this.GetEvents())
            {
                foreach (Member member2 in e.GetMembersList())
                {
                    if (member2.Equals(member1))
                    {
                        if (e is Competition)
                        {
                            if(((Competition)e).isPlayingThisDay(member2, date)) {
                                return false;
                            }
                        }
                        else if (e.GetStart().CompareTo(date) < 0 && e.GetEnd().CompareTo(date) > 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /*public bool isPlayingThisDay(Member member1, DateTime date)
        {
            foreach (Competition competition in this.competitions)
            {
                foreach (TeamMatch teamMatch in competition.Matches)
                {
                    foreach (Match match in teamMatch.Matches)
                    {
                        foreach (Member member2 in match.GetPlayers())
                        {
                            if (member2.Equals(member1))
                            {
                                if (date.Date == teamMatch.Date.Date)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }*/
        public ISet<Member> GetAvailableMembers(DateTime date)
        {
            ISet<Member> members = new SortedSet<Member>();
            foreach (Member member in this.AllMember)
            {
                if (this.isFreeThisDay(member, date))
                {
                    members.Add(member);
                }

            }
            return members;
        }

        public ISet<Member> GetAvailableCompetitors(DateTime date)
        {
            ISet<Member> members = new SortedSet<Member>();
            foreach (Member member in this.AllMember)
            {
                if (member.RegistrationType.Equals(RegistrationType.COMPETITION))
                {
                    if (this.isFreeThisDay(member, date))
                    {
                        members.Add(member);
                    }
                }
            }
            return members;
        }

        public ISet<Member> GetAvailableCompetitors(DateTime date, Member member1)
        {
            ISet<Member> members = new SortedSet<Member>();
            foreach (Member member2 in this.AllMember)
            {
                if (member2.RegistrationType.Equals(RegistrationType.COMPETITION))
                {
                    if (!member1.Equals(member2) && member1.Level.Equals(member2.Level))
                    {
                        if (this.isFreeThisDay(member2, date))
                        {
                            members.Add(member2);
                        }
                    }
                }
            }
            return members;
        }

        public ISet<Event> GetEvents()
        {
            ISet<Event> events = new SortedSet<Event>(this.competitions);
            foreach (Event e in this.tournaments)
            {
                events.Add(e);
            }
            return events;
        }

        public void AddMember(Member member)
        {
            this.members.Add(member);
        }

        public void AddCoach(Coach coach)
        {
            this.coachs.Add(coach);
        }

        public void AddStaff(Staff staff)
        {
            this.staffs.Add(staff);
        }

        public Member GetMember(int id)
        {
            foreach (Member member in AllMember)
            {
                if (id == member.ID)
                {
                    return member;
                }
            }
            return null;
        }

        public void AddCompetition(Competition competition)
        {
            this.competitions.Add(competition);
        }

        // Getters and Setters
        public void RemoveMember(Member member)
        {
            if (member.GetType().Equals(typeof(Coach)))
            {
                this.coachs.Remove((Coach)member);
            }
            else if (member.GetType().Equals(typeof(Staff)))
            {
                this.staffs.Remove((Staff)member);
            }
            else
            {
                this.members.Remove(member);
            }
        }

        public void RemoveCompetition(Competition competition)
        {
            this.competitions.Remove(competition);
        }

        public void RemoveTournament(FamilyTournament tournament)
        {
            this.tournaments.Remove(tournament);
        }

        public void AddTournament(FamilyTournament tournament)
        {
            this.tournaments.Add(tournament);
        }

        // Getters
        public ISet<Member> AllMember
        {
            get
            {
                ISet<Member> members = new SortedSet<Member>(this.members);
                foreach (Member member in this.coachs)
                {
                    members.Add(member);
                }
                foreach (Member member in this.staffs)
                {
                    members.Add(member);
                }
                return members;
            }
        }

        public ISet<Member> AllCompetitors
        {
            get
            {
                ISet<Member> members = new SortedSet<Member>(this.AllMember);
                foreach (Member member in new SortedSet<Member>(members))
                {
                    if (!member.RegistrationType.Equals(RegistrationType.COMPETITION))
                    {
                        members.Remove(member);
                    }
                }
                return members;
            }
        }

        public ISet<Member> Members
        {
            get
            {
                return new SortedSet<Member>(this.members);
            }
        }

        public ISet<Coach> Coachs
        {
            get
            {
                return new SortedSet<Coach>(this.coachs);
            }
        }

        public ISet<Staff> Staffs
        {
            get
            {
                return new SortedSet<Staff>(this.staffs);
            }
        }

        public ISet<Competition> Competitions
        {
            get
            {
                return new SortedSet<Competition>(this.competitions);
            }
        }

        public ISet<FamilyTournament> FamilyTournaments
        {
            get
            {
                return new SortedSet<FamilyTournament>(this.tournaments);
            }
        }

        public string Name
        {
            get;
        }

        public string City
        {
            get;
        }
    }
}
