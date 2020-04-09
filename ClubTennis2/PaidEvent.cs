using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public abstract class PaidEvent : Event
    {
        private static int nbPaidEventInstantiated = 0;

        private int id;
        //private DateTime start;
        //private DateTime end;
        private int price;
        private ISet<TennisCourt> tennisCourts = new SortedSet<TennisCourt>();

        public PaidEvent(int price)
        {
            //this.start = start;
            //this.end = end;
            this.price = price;
            this.id = nbPaidEventInstantiated;
            nbPaidEventInstantiated++;
        }

        public string GetEventName()
        {
            return "ID: " + this.id;
        }

        public bool IsDuring(Event otherEvent)
        {
            return this.GetStart().CompareTo(otherEvent.GetEnd()) > 0
                && this.GetEnd().CompareTo(otherEvent.GetStart()) < 0;
        }

        public ISet<TennisCourt> GetTennisCourts()
        {
            return new SortedSet<TennisCourt>(this.tennisCourts);
        }

        public abstract ISet<Member> GetMembersList();

        public int CompareTo(Event other)
        {
            return this.id.CompareTo(other.GetID());
        }

        public int GetID()
        {
            return this.id;
        }
        public abstract DateTime GetStart();

        public abstract DateTime GetEnd();

        // Getters and Setters
        public DateTime Start
        {
            get
            {
                return this.GetStart();
            }
            
        }

        public DateTime End
        {
            get
            {
                return this.GetEnd();
            }

        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        
        public int ID
        {
            get { return this.id; }
        }
    }
}
