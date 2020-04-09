using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class RankingComparator : Comparer<Member>
    {
        public override int Compare(Member x, Member y)
        {
            if (x.Level.Equals(y.Level))
            {
                return x.CompareTo(y);
            }
            return x.Level.CompareTo(y.Level);
        }
    }
}
