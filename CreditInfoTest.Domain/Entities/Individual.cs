namespace CreditInfoTest.Domain.Entities
{
    public class Individual : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalID { get; set; }
        public Contract Contract { get; set; }
    }
}
