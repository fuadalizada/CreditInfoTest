using CreditInfoTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreditInfoTest.DAL.ModelConfiguration
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("TBL_CONTRACT");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.OriginalAmount).HasColumnName("ORIGINAL_AMOUNT").HasColumnType("decimal");
            builder.Property(p => p.InstallmentAmount).HasColumnName("INSTALLMENT_AMOUNT").HasColumnType("decimal");
            builder.Property(p => p.CurrentBalance).HasColumnName("CURRENT_BALANCE").HasColumnType("decimal");
            builder.Property(p => p.OverdueBalance).HasColumnName("OVERDUE_BALANCE").HasColumnType("decimal");
            builder.Property(p => p.ContractCode).HasColumnName("CONTRACT_CODE").HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.DateOfLastPayment).HasColumnName("DATE_OF_LAST_PAYMENT");
            builder.Property(p => p.NextPaymentDate).HasColumnName("NEXT_PAYMENT_DATE");
            builder.Property(p => p.DateAccountOpened).HasColumnName("DATE_ACCOUNT_OPENED");
            builder.Property(p => p.RealEndDate).HasColumnName("REAL_END_DATE");
        }
    }
}
