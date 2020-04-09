using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public interface Event: IComparable<Event>
    {
        int GetID();
        string GetEventName();

        ISet<Member> GetMembersList();

        bool IsDuring(Event otherEvent);

        ISet<TennisCourt> GetTennisCourts();

        DateTime GetStart();

        DateTime GetEnd();

    }
}
