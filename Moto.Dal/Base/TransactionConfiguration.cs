using Moto.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Moto.Dal.Base
{
    internal class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Name);
            this.Property(t => t.Date);
            this.Property(t => t.Amount);
            this.Property(t => t.Detail);
            this.Property(t => t.Memo);
            this.Property(t => t.Update_Date);

            // Table & Column Mappings
            this.ToTable("Transaction");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Update_Date).HasColumnName("Update_Date");

        }
    }
}

