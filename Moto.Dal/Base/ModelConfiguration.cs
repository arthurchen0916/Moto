using Moto.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Moto.Dal.Base
{
    internal class ModelConfiguration : EntityTypeConfiguration<Model>
    {
        public ModelConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.model);
            this.Property(t => t.Year);
            this.Property(t => t.cc);
            this.Property(t => t.Color);
            this.Property(t => t.Front_wheel_brakes);
            this.Property(t => t.Rear_wheel_brakes);
            this.Property(t => t.ABS);
            this.Property(t => t.Factory_price);
            this.Property(t => t.Retail_price);
            this.Property(t => t.update_date);

            // Table & Column Mappings
            this.ToTable("Model");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.model).HasColumnName("model");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.cc).HasColumnName("cc");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.Front_wheel_brakes).HasColumnName("Front_wheel_brakes");
            this.Property(t => t.Rear_wheel_brakes).HasColumnName("Rear_wheel_brakes");
            this.Property(t => t.ABS).HasColumnName("ABS");
            this.Property(t => t.Factory_price).HasColumnName("Factory_price");
            this.Property(t => t.Retail_price).HasColumnName("Retail_price");
            this.Property(t => t.update_date).HasColumnName("update_date");

        }
    }
}
