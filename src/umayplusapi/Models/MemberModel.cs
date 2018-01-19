using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace umayplusapi.Models
{
    [Table("member")]
    public class MemberModel
    {
        public int id { get; set; }

        public string UmayplusCardID { get; set; }

        public string PersonalCardID { get; set; }

        public string BirthDate { get; set; }

        public string MobilePhone { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
