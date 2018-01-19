using System;
using Xunit;
using umayplusapi.Services;
using umayplusapi.Models;

namespace api.Unittest
{
    public class MemberServiceTest
    {
        [Fact]
        public void GetMemberInfo_Success_ReturnMemberInfo()
        {
            var umayplusCardID = "6273885053341539";
            var personalCardID = "3100505143401";
            var birthDate = "01/01/2530";
            var mobilePhone = "092224955";

            var expectMember = new MemberServiceTest()
            {
                UmayplusCardID = "6273885053341539",
                PersonalCardID = "3100505143401",
                BirthDate = "01/01/2530",
                MobilePhone = "092224955",
                FirstName = "Anusorn",
                LastName = "Bothong"
            };

            MemberService memberService = new MemberService();
            MemberModel actualMember = memberService.getMemberInfo(umayplusCardID, personalCardID, birthDate, mobilePhone);
        
            Assert.Equal(expectMember.UmayplusCardID, actualMember.UmayplusCardID);
            Assert.Equal(expectMember.PersonalCardID, actualMember.PersonalCardID);
            Assert.Equal(expectMember.BirthDate, actualMember.BirthDate);
            Assert.Equal(expectMember.MobilePhone, actualMember.MobilePhone);
            Assert.Equal(expectMember.FirstName, actualMember.FirstName);
            Assert.Equal(expectMember.LastName, actualMember.LastName);
        }
    }
}
