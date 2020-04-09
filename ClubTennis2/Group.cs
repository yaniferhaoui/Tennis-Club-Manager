using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class Group
    {
        private Coach coach;
        private short maxSize;
        private ISet<Member> youngs = new SortedSet<Member>();

        public Group(Coach coach, short maxSize)
        {
            this.coach = coach;
            this.maxSize = maxSize;
        }

        // Methods
        public bool Add(Member member)
        {
            bool succed = false;
            if (member.Age <= 18)
            {
                this.youngs.Add(member);
                succed = true;
            }
            return succed;
        }
        public bool Remove(Member member)
        {
            return this.youngs.Remove(member);
        }


        // Getters and Setters
        public Coach Coach
        {
            get { return this.coach; }
            set { this.coach = value; }
        }

        public short MaxSize
        {
            get { return this.maxSize; }
            set { this.maxSize = value; }
        }

        public int Size
        {
            get { return this.youngs.Count(); }
        }

        public ISet<Member> ViewOfMembers
        {
            get { return new SortedSet<Member>(this.youngs); }
        }
    }
}
