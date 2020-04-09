using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class Binome: IComparable<Binome>
    {
        private Member member1;
        private Member member2 = null;

        public Binome(Member member1)
        {
            this.member1 = member1;
        }

        public Binome(Member member1, Member member2)
        {
            this.member1 = member1;
            this.member2 = member2;
        }

        public bool isFill()
        {
            return this.member2 != null;
        }

        public bool contains(Member member)
        {
            if (this.member2 != null)
            {
                return this.member1.Equals(member) || this.member2.Equals(member);
            }
            return this.member1.Equals(member);
        }

        public int CompareTo(Binome other)
        {
            if (this.member1.Equals(other.member1))
            {
                if (this.member2 == null && other.member2 == null)
                {
                    return 0;
                } else if (this.member2 == null)
                {
                    return -1;
                }
                return this.member2.CompareTo(other.member2);
            }
            return this.member1.CompareTo(other.member1);
        }

        // Getters and Setters
        public Member Member1
        {
            get { return this.member1; }
            set { this.member1 = value; }
        }

        public Member Member2
        {
            get { return this.member2; }
            set { this.member2 = value; }
        }
    }
}
