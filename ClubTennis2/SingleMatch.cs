using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class SingleMatch: Match
    {
        private Member player;
        //private Opponent opponent;

        public SingleMatch(Member player) : base()
        {
            this.player = player;
        }

        public override ISet<Member> GetPlayers()
        {
            ISet<Member> members = new SortedSet<Member>();
            members.Add(this.player);
            return members;
        }


        // Getters and Setters
        public Member Player
        {
            get { return this.player; }
            set { this.player = value; }
        }

        
    }
}
