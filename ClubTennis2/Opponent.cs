using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubTennis2.Enumerations;

namespace ClubTennis2
{
    public class Opponent : TennisPlayer
    {

        /*public static Opponent[] opponents = {
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
            new Opponent(DateTime.ParseExact("20-03-1992", "dd-MM-yyyy", null), Gender.MALE, "Bertrand", "Ferrard", null, Level.F, "Cergy"),
    };*/

        private string clubName;
        public Opponent(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, Level level, string clubName) :
            base(dateOfBirth, gender, firstName, lastName, theAddress)
        {
            this.clubName = clubName;
        }

        public Opponent(DateTime dateOfBirth, Gender gender, string firstName, string lastName, Address theAddress, string clubName) :
            base(dateOfBirth, gender, firstName, lastName, theAddress)
        {
            this.clubName = clubName;
        }

        // Getters and Setters
        public string ClubName
        {
            get { return this.clubName; }
            set { this.clubName = value; }
        }
    }
}
