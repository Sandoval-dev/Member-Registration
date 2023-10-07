using MemberRegistiration.DataAccess.Concrete.EntityFramework.Mappings;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Concrete.EntityFramework
{
    public class MembershipContext : DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }
        public DbSet<Member> Members { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            //Mapping dosyası, kod ve tablonun hangi alanların hangi alanlara denk geldiğini belirtir.
        }

    }
    
}
