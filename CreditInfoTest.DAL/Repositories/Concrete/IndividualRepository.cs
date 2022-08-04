using CreditInfoTest.DAL.DbContext;
using CreditInfoTest.DAL.Repositories.Abstract;
using CreditInfoTest.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CreditInfoTest.DAL.Repositories.Concrete
{
    public class IndividualRepository : BaseRepository<Individual>, IIndividualRepository
    {
        public IndividualRepository(CreditInfoTestDbContext context) : base(context)
        {

        }

        public async override Task<Individual> AddAsync(Individual entity)
        {
            return await base.AddAsync(entity);
        }

        public async override Task<bool> DeleteAsync(Guid id)
        {
           return await base.DeleteAsync(id);
        }

        public async override Task<IQueryable<Individual>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
