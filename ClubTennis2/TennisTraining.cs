using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class TennisTraining: Event
    {
        private static int nb = 0;

        private int id;
        private DateTime date;
        private short duration;
        private Coach coach;
        private TennisCourt tennisCourt;
        private ISet<Member> members = new SortedSet<Member>();

        public TennisTraining(short duration, Coach coach)
        {
            this.id = nb;
            nb++;
            this.duration = duration;
            this.coach = coach;
        }

        public int CompareTo(Event other)
        {
            return this.id.CompareTo(other.GetID());
        }

        // Methods
        public DateTime GetEnd()
        {
            return this.date.AddHours(this.duration);
        }

        public string GetEventName()
        {
            return "Tennis Training with " + this.coach;
        }

        public int GetID()
        {
            return this.id;
        }

        public ISet<Member> GetMembersList()
        {
            return new SortedSet<Member>(this.members);
        }

        public DateTime GetStart()
        {
            return this.date;
        }

        public ISet<TennisCourt> GetTennisCourts()
        {
            return new SortedSet<TennisCourt>(new TennisCourt[] { this.tennisCourt });
        }

        public bool IsDuring(Event otherEvent)
        {
            return this.GetStart().CompareTo(otherEvent.GetEnd()) > 0
                && this.GetEnd().CompareTo(otherEvent.GetStart()) < 0;
        }
    }
}
