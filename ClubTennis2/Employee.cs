using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Employee : Member
    {
        private string rib;
        private int salary;
        private DateTime arrivalTime;

        // Leisure constructor
        public Employee(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, string rib, int salary) :
            base(dateOfBirth, gender, firstName, lastName, theAddress)
        {
            this.rib = rib;
            this.salary = salary;
            this.arrivalTime = DateTime.Now;
            this.SubscriptionPaidThidYear = true;
        }

        // Competition constructor
        public Employee(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, Level level, string rib, int salary) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, level)
        {
            this.rib = rib;
            this.salary = salary;
            this.arrivalTime = DateTime.Now;
            this.SubscriptionPaidThidYear = true;
        }

        // Getters and Setters
        public string RIB
        {
            get { return this.rib; }
            set { this.rib = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public DateTime ArrivalTime
        {
            get { return this.arrivalTime; }
            set { this.arrivalTime = value; }
        }
    }
}
