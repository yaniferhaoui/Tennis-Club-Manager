using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Competition : PaidEvent
    {
        private Level levelRequired;
        private string name;
        private ISet<TeamMatch> matches = new SortedSet<TeamMatch>();
        private int duration;

        public Competition(string name, Level levelRequired, int price) :
            base(price)
        {
            this.duration = duration;
            this.levelRequired = levelRequired;
            this.name = name;
        }

        public bool AddTeamMatch(TeamMatch teamMatch)
        {
            return this.matches.Add(teamMatch);
        }

        public override ISet<Member> GetMembersList()
        {
            ISet<Member> members = new SortedSet<Member>();
            foreach (TeamMatch match in matches)
            {
                foreach (Member member in match.Members)
                {
                    members.Add(member);
                }
            }
            return members;
        }

        public bool isPlayingThisDay(Member member, DateTime date)
        {
            foreach (TeamMatch match in this.matches)
            {
                if (match.Date.Date.Equals(date.Date))
                {
                    if (match.Member1.Equals(member) || match.Member2.Equals(member))
                    {
                        
                        return true;
                    }
                }

            }
            
            return false;
        }

        public override DateTime GetStart()
        {
            if (this.matches.Count != 0)
            {
                DateTime min = this.matches.First<TeamMatch>().Date;
                foreach (TeamMatch match in this.matches)
                {
                    if (match.Date.CompareTo(min) < 0)
                    {
                        min = match.Date;
                    }
                }
                return min;
            }
            return default(DateTime);
        }

        public override DateTime GetEnd()
        {
            if (this.matches.Count != 0)
            {
                DateTime max = this.matches.First<TeamMatch>().Date;
                foreach (TeamMatch match in this.matches)
                {
                    if (match.Date.CompareTo(max) > 0)
                    {
                        max = match.Date;
                    }
                }
                return max;
            }
            return default(DateTime);
        }

        // Getters and Setters
        public Level Level
        {
            get { return this.levelRequired; }
            set { this.levelRequired = value; }
        }

        public string LevelDesc
        {
            get { return Enumerations.GetDescription((Enum)this.levelRequired); }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public ISet<TeamMatch> Matches
        {
            get { return this.matches; }
        }

        public ISet<Member> Members
        {
            get
            {
                ISet<Member> members = new SortedSet<Member>();
                foreach (TeamMatch match in matches)
                {
                    foreach (Member member in match.Members)
                    {
                        members.Add(member);
                    }
                }
                return members;
            }
        }

        public int Size
        {
            get
            {
                return this.matches.Count;
            }
        }
    }
}
