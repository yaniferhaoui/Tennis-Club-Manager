using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class GenderComparator : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            if (x.Gender.Equals(y.Gender))
            {
                return x.CompareTo(y);
            }
            return x.Gender.CompareTo(y.Gender);
        }
    }
}
