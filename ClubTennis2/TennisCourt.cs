using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class TennisCourt
    {
        private static int nbTennisCourtInstantiated = 0;

        private int id;

        public TennisCourt()
        {
            this.id = TennisCourt.nbTennisCourtInstantiated;
            TennisCourt.nbTennisCourtInstantiated++;
        }

        // Getters and Setters
        public int ID
        {
            get { return this.id; }
        }

    }
}
