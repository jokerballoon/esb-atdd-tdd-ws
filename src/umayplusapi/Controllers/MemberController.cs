using Microsoft.AspNetCore.Mvc;
using umayplusapi.Models;
using umayplusapi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace umayplusapi.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private IMemberService memberService;
        public MemberController(IMemberService memberService)
        {
            this.memberService = memberService;
        }

        [HttpPost]
        public ResponseMessage Post([FromBody]MemberModel member)
        {
            MemberModel returnMember = this.memberService.getMemberInfo(member.UmayplusCardID, member.PersonalCardID, 
                                        member.BirthDate, member.MobilePhone);
            
            return new ResponseMessage(){
                Status = "200",
                Data = returnMember
            };
        }

    }
}
