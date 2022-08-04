using CreditInfoTest.DAL.DbContext;
using CreditInfoTest.DAL.Repositories.Abstract;
using CreditInfoTest.Domain.Entities;

namespace CreditInfoTest.DAL.Repositories.Concrete
{
    public class ContractRepository : BaseRepository<Contract>,IContractRepository
    {
        public ContractRepository(CreditInfoTestDbContext context) : base(context)
        {

        }
    }
}
