using System;
using umayplusapi.Models;

namespace umayplusapi.Contexts
{
    public interface IMemberContext
    {
        MemberModel findMember(string umayplusCardID, string personalCardID);
    }
}
