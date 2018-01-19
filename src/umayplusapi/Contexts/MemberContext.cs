using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using umayplusapi.Models;

namespace umayplusapi.Contexts
{
    public class MemberContext : DbContext, IMemberContext
    {
        public MemberContext(DbContextOptions<MemberContext>dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<MemberModel> Members { get; set; }

        public MemberModel findMember(string umayplusCardID, string personalCardID)
        {

            return this.Members.Where( m => m.UmayplusCardID == umayplusCardID 
                                      && m.PersonalCardID == personalCardID).First();
        }
    }
}
