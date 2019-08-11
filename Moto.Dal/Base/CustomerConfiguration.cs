using Moto.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Moto.Dal.Base
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Name);
            this.Property(t => t.License_Plate);
            this.Property(t => t.Phone_Number);
            this.Property(t => t.Tel_Number);
            this.Property(t => t.Address);
            this.Property(t => t.Del_Flag);
            this.Property(t => t.Update_Date);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.License_Plate).HasColumnName("License_Plate");
            this.Property(t => t.Phone_Number).HasColumnName("Phone_Number");
            this.Property(t => t.Tel_Number).HasColumnName("Tel_Number");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Del_Flag).HasColumnName("Del_Flag");
            this.Property(t => t.Update_Date).HasColumnName("Update_Date");

        }
    }
}

