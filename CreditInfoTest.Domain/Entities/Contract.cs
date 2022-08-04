using System;

namespace CreditInfoTest.Domain.Entities
{
    public class Contract : BaseEntity
    {
        public Guid IndividualId { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal OverdueBalance { get; set; }
        public string ContractCode { get; set; }
        public DateTime DateOfLastPayment { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public DateTime DateAccountOpened { get; set; }
        public DateTime RealEndDate { get; set; }
        public Individual Individual { get; set; }
    }
}
