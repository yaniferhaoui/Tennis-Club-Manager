using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class MemberReservation : Event
    {

        private static int nb = 0;

        private int id;
        private DateTime date;
        private Member member1;
        private Member member2;
        private TennisCourt tennisCourt;

        public MemberReservation(DateTime date, Member member1, Member member2, TennisCourt tennisCourt)
        {
            this.id = nb;
            nb++;
            this.date = date;
            this.member1 = member1;
            this.member2 = member2;
            this.tennisCourt = tennisCourt;
        }
        public DateTime GetEnd()
        {
            return this.date.AddHours(1);
        }

        public DateTime GetStart()
        {
            return this.date;
        }

        public bool IsDuring(Event otherEvent)
        {
            return this.GetStart().CompareTo(otherEvent.GetEnd()) > 0
                && this.GetEnd().CompareTo(otherEvent.GetStart()) < 0;
        }

        public string GetEventName()
        {
            return "Reservation of " + this.member1 + " and " + this.member2;
        }

        public ISet<Member> GetMembersList()
        {
            return new SortedSet<Member>(new Member[] { this.member1, this.member2 });
        }

        public ISet<TennisCourt> GetTennisCourts()
        {
            return new SortedSet<TennisCourt>(new TennisCourt[] { this.tennisCourt });
        }

        public int GetID()
        {
            return this.id;
        }

        public int CompareTo(Event other)
        {
            return this.GetID().CompareTo(other.GetID());
        }


        // Getters and Setters
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Member Member1
        {
            get { return this.member1; }
            set { this.member1 = value; }
        }

        public Member Member2
        {
            get { return this.member2; }
            set { this.member2 = value; }
        }
    }
}
