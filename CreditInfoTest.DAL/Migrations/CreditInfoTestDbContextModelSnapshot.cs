// <auto-generated />
using System;
using CreditInfoTest.DAL.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CreditInfoTest.DAL.Migrations
{
    [DbContext(typeof(CreditInfoTestDbContext))]
    partial class CreditInfoTestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CreditInfoTest.Domain.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("ContractCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CONTRACT_CODE");

                    b.Property<decimal>("CurrentBalance")
                        .HasColumnType("decimal")
                        .HasColumnName("CURRENT_BALANCE");

                    b.Property<DateTime>("DateAccountOpened")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATE_ACCOUNT_OPENED");

                    b.Property<DateTime>("DateOfLastPayment")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATE_OF_LAST_PAYMENT");

                    b.Property<Guid>("IndividualId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("InstallmentAmount")
                        .HasColumnType("decimal")
                        .HasColumnName("INSTALLMENT_AMOUNT");

                    b.Property<DateTime>("NextPaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("NEXT_PAYMENT_DATE");

                    b.Property<decimal>("OriginalAmount")
                        .HasColumnType("decimal")
                        .HasColumnName("ORIGINAL_AMOUNT");

                    b.Property<decimal>("OverdueBalance")
                        .HasColumnType("decimal")
                        .HasColumnName("OVERDUE_BALANCE");

                    b.Property<DateTime>("RealEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("REAL_END_DATE");

                    b.HasKey("Id");

                    b.HasIndex("IndividualId")
                        .IsUnique();

                    b.ToTable("TBL_CONTRACT", (string)null);
                });

            modelBuilder.Entity("CreditInfoTest.Domain.Entities.Individual", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LASTNAME");

                    b.Property<string>("NationalID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NATIONAL_ID");

                    b.HasKey("Id");

                    b.ToTable("TBL_INDIVIDUAL", (string)null);
                });

            modelBuilder.Entity("CreditInfoTest.Domain.Entities.Contract", b =>
                {
                    b.HasOne("CreditInfoTest.Domain.Entities.Individual", "Individual")
                        .WithOne("Contract")
                        .HasForeignKey("CreditInfoTest.Domain.Entities.Contract", "IndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Individual");
                });

            modelBuilder.Entity("CreditInfoTest.Domain.Entities.Individual", b =>
                {
                    b.Navigation("Contract");
                });
#pragma warning restore 612, 618
        }
    }
}
