using Moto.Common.Entities;
using System.Data.Entity;

namespace Moto.Dal.Base
{
    public partial class MotoContext : DbContext
    {
        public MotoContext()
            : base("name=MotoEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BrandConfiguration());
            modelBuilder.Configurations.Add(new ModelConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Member> Member { get; set; }
    }
}  