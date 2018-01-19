using System;
namespace umayplusapi.Models
{
    public class ResponseMessage
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public MemberModel Data { get; set; }
    }
}
