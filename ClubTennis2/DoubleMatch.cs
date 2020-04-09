using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class DoubleMatch : Match
    {
        private Member player1;
        private Member player2;

        public DoubleMatch(Member player1, Member player2) : base()
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public override ISet<Member> GetPlayers()
        {
            ISet<Member> members = new SortedSet<Member>();
            members.Add(this.player1);
            members.Add(this.player2);
            return members;
        }

        // Getters and Setters
        public Member Player1
        {
            get { return this.player1; }
            set { this.player1 = value; }
        }
        public Member Player2
        {
            get { return this.player2; }
            set { this.player2 = value; }
        }

    }
}
