using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public abstract class Match: IComparable<Match>
    {
        private static int nb = 0;

        private int id;
        private short resultat = 0;
        public Match()
        {
            this.id = nb;
            nb++;
        }

        public abstract ISet<Member> GetPlayers();

        public int CompareTo(Match other)
        {

            return this.id.CompareTo(other.id);
        }

        public short Resultat
        {
            get { return this.resultat; }
            set { this.resultat = value; }
        }

    }
}
