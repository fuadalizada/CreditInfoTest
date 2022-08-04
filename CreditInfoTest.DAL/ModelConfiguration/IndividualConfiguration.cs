using CreditInfoTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreditInfoTest.DAL.ModelConfiguration
{
    public class IndividualConfiguration : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.ToTable("TBL_INDIVIDUAL");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.FirstName).HasColumnName("FIRSTNAME").HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(p => p.LastName).HasColumnName("LASTNAME").HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(p => p.NationalID).HasColumnName("NATIONAL_ID").HasColumnType("nvarchar").HasMaxLength(20);
            builder.HasOne(x => x.Contract).WithOne(x => x.Individual).HasForeignKey<Contract>(c => c.IndividualId);
        }
    }
}
