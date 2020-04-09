using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class CompetitionLevelComparator : IComparer<Competition>
    {
        public int Compare(Competition x, Competition y)
        {
            //MainWindow.message(x.Level.ToString() + "  " + y.Level.ToString() + "  " + (((int)x.Level).CompareTo(((int)y.Level)) + "  " + (((int)y.Level).CompareTo(((int)x.Level)))));
            if (Convert.ToInt32(y.Level).CompareTo(Convert.ToInt32(x.Level)) == 0)
            {
                return x.CompareTo(y);
            }
            return (Convert.ToInt32(y.Level)).CompareTo(Convert.ToInt32(x.Level));
        }
    }
}
