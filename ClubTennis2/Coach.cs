using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{


    public class Coach : Employee
    {
        private Status status;
        private ISet<TennisTraining> trainings = new SortedSet<TennisTraining>();
        //private ISet<TennisClinic> clinics = new SortedSet<TennisClinic>();

        // Leisure constructor
        public Coach(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, string rib, int salary, Status status) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, rib, salary)
        {
            this.status = status;
        }

        // Competition constructor
        public Coach(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, Level level, string rib, int salary, Status status) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, level, rib, salary)
        {
            this.status = status;
        }

        // Getters and Setters
        public Status Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
    }
}
