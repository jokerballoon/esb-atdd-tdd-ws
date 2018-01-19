using System;
using umayplusapi.Models;

namespace umayplusapi.Services
{
    public interface IMemberService
    {
        MemberModel getMemberInfo(string umayplusCardID, string personalCardID, string irthDate, string mobilePhone);
    }
}
