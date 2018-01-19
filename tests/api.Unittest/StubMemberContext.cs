using System;
using umayplusapi.Contexts;
using umayplusapi.Models;

namespace api.Unittest
{
    public class StubMemberContext : IMemberContext
    {
        public MemberModel findMember(string umayplusCardID, string personalCardID)
        {
            var expectMember = new MemberModel()
            {
                UmayplusCardID = "6273885053341539",
                PersonalCardID = "3100505143401",
                BirthDate = "01/01/2530",
                MobilePhone = "092224955",
                FirstName = "Anusorn",
                LastName = "Bothong"
            };
            return expectMember;
        }
    }
}
