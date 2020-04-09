using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Staff : Employee
    {
        // Leisure constructor
        public Staff(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, string rib, int salary) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, rib, salary)
        {
        }

        // Competition constructor
        public Staff(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, Level level, string rib, int salary) :
            base(dateOfBirth, gender, firstName, lastName, theAddress, level, rib, salary)
        {
        }
    }
}
