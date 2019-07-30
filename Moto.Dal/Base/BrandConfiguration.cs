using Moto.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Moto.Dal.Base
{
    internal class BrandConfiguration : EntityTypeConfiguration<Brand>
    {
        public BrandConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Brand_code);
            this.Property(t => t.Brand_name);
            this.Property(t => t.Address);
            this.Property(t => t.Tel);
            this.Property(t => t.Name);
            this.Property(t => t.Update_date);

            // Table & Column Mappings
            this.ToTable("Brand");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Brand_code).HasColumnName("Brand_code");
            this.Property(t => t.Brand_name).HasColumnName("Brand_name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Update_date).HasColumnName("Update_date");
        }
    }
}

