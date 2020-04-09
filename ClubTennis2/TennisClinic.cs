using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class TennisClinic: PaidEvent, Event
    {
        private ISet<Group> groups = new SortedSet<Group>();
        private int nbMaxMember;
        private DateTime start;
        private DateTime end;

        public TennisClinic(DateTime start, DateTime end, int nbMaxMember, int price) : base(price)
        {
            this.nbMaxMember = nbMaxMember;
            this.start = start;
            this.end = end;
        }

        public override ISet<Member> GetMembersList()
        {
            ISet<Member> members = new SortedSet<Member>();
            foreach (Group groupe in groups)
            {
                foreach(Member member in groupe.ViewOfMembers)
                {
                    members.Add(member);
                }
            }
            return members;
        }

/*        public bool IsDuring(DateTime start, DateTime end)
        {
            return this.GetStart().CompareTo(end) > 0 && this.GetEnd().CompareTo(start) < 0;
        }*/

        public override DateTime GetStart()
        {
            return this.start;
        }

        public override DateTime GetEnd()
        {
            return this.end;
        }

        public bool RemoveGroup(Group group)
        {
            return this.groups.Remove(group);
        }

        // Getters and Setters
        public int NbMaxMember
        {
            get { return this.nbMaxMember; }
            set { this.nbMaxMember = value; }
        }
    }
}
