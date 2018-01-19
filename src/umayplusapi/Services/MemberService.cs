using System;
using umayplusapi.Contexts;
using umayplusapi.Models;
namespace umayplusapi.Services
{
    public class MemberService : IMemberService
    {
        private IMemberContext memberContext;
        public MemberService(IMemberContext memberContext)
        {
            this.memberContext = memberContext;
        }

        public MemberModel getMemberInfo(string umayplusCardID, string personalCardID, string irthDate, string mobilePhone)
        {
            MemberModel member = memberContext.findMember(umayplusCardID, personalCardID);
            return member;
        }
    }
}
