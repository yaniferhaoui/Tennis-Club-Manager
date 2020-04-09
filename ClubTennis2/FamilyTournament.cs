using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class FamilyTournament : Event
    {
        private static int nb = 0;

        private int id;
        private string name;
        private DateTime start;
        //private DateTime end;
        //private ISet<Coach> coachs = new SortedSet<Coach>();
        private ISet<Member> members = new SortedSet<Member>();
        private ISet<TennisCourt> tennisCourts = new SortedSet<TennisCourt>();

        public FamilyTournament(string name, DateTime start)
        {
            this.name = name;
            this.start = start;
            //this.end = end;
            this.id = nb;
            nb++;
        }

        public void AddMember(Member member)
        {
            this.members.Add(member);
        }

        public void SetMembers(ISet<Member> members)
        {
            this.members = members;
        }

        public void RemoveMember(Member member)
        {
            this.members.Remove(member);

        }


        public DateTime GetStart()
        {
            return this.start;
        }

        public DateTime GetEnd()
        {
            return this.start.AddDays(1).Date.AddTicks(-1);
        }

        public string GetEventName()
        {
            return "Family Tournament of " + this.start.ToString();
        }

        public ISet<Member> GetMembersList()
        {
            /*ISet<Member> allMembers = new SortedSet<Member>(this.members);
            foreach(Coach coach in this.coachs)
            {
                allMembers.Add(coach);
            }*/
            return new SortedSet<Member>(this.members);
        }

        public ISet<TennisCourt> GetTennisCourts()
        {
            return new SortedSet<TennisCourt>(this.tennisCourts);
        }

        public bool IsDuring(Event theEvent)
        {
            return this.GetStart().CompareTo(theEvent.GetEnd()) > 0 
                && this.GetEnd().CompareTo(theEvent.GetStart()) < 0;
        }

        public int CompareTo(Event other)
        {
            return this.id.CompareTo(other.GetID());
        }

        public int GetID()
        {
            return this.id;
        }

        // Getter
        public int ID
        {
            get { return this.GetID(); }
        }

        public int SizeCoach
        {
            get { int i = 0;
                foreach(Member member in this.members)
                {
                    if (member is Coach)
                    {
                        i++;
                    }
                }
                return i;
            }
        }

        public int SizeMember
        {
            get { return this.members.Count; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public DateTime Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public DateTime End
        {
            get { return this.GetEnd(); }
        }

    }
}
