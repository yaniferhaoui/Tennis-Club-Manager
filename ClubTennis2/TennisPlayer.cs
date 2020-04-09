using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class TennisPlayer : Person
    {
        private Level level = Level.A; // NC by default

        public TennisPlayer(DateTime birthdate, Gender gender, string firstName, string lastName, Address theAddress) :
            base(birthdate, gender, firstName, lastName, theAddress)
        {
        }
        public TennisPlayer(DateTime birthdate, Gender gender, string firstName, string lastName, Address theAddress, Level level) :
            base(birthdate, gender, firstName, lastName, theAddress)
        {
            this.level = level;
        }


        // Getters and Setters
        public Level Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public string LevelDescription
        {
            get
            {
                return Enumerations.GetDescription(this.level);
            }
        }
    }
}
