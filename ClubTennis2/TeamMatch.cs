using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class TeamMatch: IComparable<TeamMatch>
    {
        private static int nb = 0;

        private int id;
        private Member teamLeader;
        private DateTime date;
        private ISet<Match> matches = new SortedSet<Match>();
        private Member member1;
        private Member member2;

        public TeamMatch(Member member1, Member member2, DateTime date)
        {
            this.teamLeader = member1;
            this.date = date;
            this.id = nb;
            nb++;
            this.member1 = member1;
            this.member2 = member2;
            this.matches.Add(new SingleMatch(member1));
            this.matches.Add(new SingleMatch(member2));
        }
        public TeamMatch(Binome bin, DateTime date)
        {
            this.teamLeader = bin.Member1;
            this.date = date;
            this.member1 = bin.Member1;
            this.member2 = bin.Member2;
            this.matches.Add(new DoubleMatch(bin.Member1, bin.Member2));
        }

        public int CompareTo(TeamMatch other)
        {
            return this.id.CompareTo(other.id);
        }

        // Getters and Setters
        public short Resultat
        {
            get
            {
                short res = 0;
                foreach (Match match in this.matches)
                {
                    res += match.Resultat;
                }
                return res;
            }
        }
        public Member TeamLeader
        {
            get { return this.teamLeader; }
            set { this.teamLeader = value; }
        }

        public string Type
        {
            get
            {
                if (this.matches.Count > 1)
                {
                    return "Matchs Simples";
                }
                return "Match Double";
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Member Member1
        {
            get
            {
                return this.member1;
            }
        }

        public Member Member2
        {
            get
            {
                return this.member2;
            }
        }

        public string Member1String
        {
            get
            {
                return this.member1.FirstName + " " + this.member1.LastName;
            }
        }

        public string Member2String
        {
            get
            {
                return this.member2.FirstName + " " + this.member2.LastName;
            }
        }

        // Getters and Setters
        public ISet<Match> Matches
        {
            get { return new SortedSet<Match>(this.matches); }
        }


        public ISet<Member> Members
        {
            get
            {
                ISet<Member> members = new SortedSet<Member>();
                foreach (Match match in this.matches)
                {
                    foreach(Member member in match.GetPlayers())
                    {
                        members.Add(member);
                    }
                }
                return members;
            }
        }
    }
}
