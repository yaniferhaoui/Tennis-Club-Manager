using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Member : TennisPlayer
    {
        private RegistrationType registrationType;
        private bool subscriptionPaidThisYear = false;
        private ISet<int> eventIDsPaid = new SortedSet<int>();

        // Leisure constructor
        public Member(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress) :
            base(dateOfBirth, gender, firstName, lastName, theAddress)
        {
            this.registrationType = RegistrationType.LEISURE;
        }

        // Competition constructor
        public Member(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, Level level) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, level)
        {
            this.registrationType = RegistrationType.COMPETITION;
        }

        // Methods
        public bool EventIsPaid(PaidEvent theEvent)
        {
            return this.eventIDsPaid.Contains(theEvent.ID);
        }

        public void PayEvent(PaidEvent theEvent) {
            this.eventIDsPaid.Add(theEvent.ID);
        }

        // Getters and Setters
        public int SubscriptionPrice
        {
            get
            {
                int subscriptionPrice = this.registrationType.Equals(RegistrationType.LEISURE) ? 0 : 20;
                if (this.Address.city.ToUpper().Equals(Club.club.City))
                {
                    if (this.Age < 18)
                    {
                        subscriptionPrice += 130;
                    }
                    else
                    {
                        subscriptionPrice += 200;
                    }
                }
                else
                {
                    if (this.Age < 18)
                    {
                        subscriptionPrice = 180;
                    }
                    else
                    {
                        subscriptionPrice = 280;
                    }
                }
                return subscriptionPrice;
            }
        }

        public RegistrationType RegistrationType
        {
            get { return this.registrationType; }
            set { this.registrationType = value; }
        }

        public bool SubscriptionPaidThidYear
        {
            get { return this.subscriptionPaidThisYear; }
            set { this.subscriptionPaidThisYear = value; }
        }

        public string Type
        {
            get { return this.GetType().Name; }
        }

    }
}