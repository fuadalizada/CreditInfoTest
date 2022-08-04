using CreditInfoTest.DAL.DbContext;
using CreditInfoTest.DAL.Repositories.Abstract;
using CreditInfoTest.DAL.Repositories.Concrete;
using CreditInfoTest.DAL.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CreditInfoTest.WebApi.Utils
{
    public class ServiceConfiguration : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CreditInfoTestDbContext>(option => {
                option.UseSqlServer(AppSettings.ConnectionString);
            });

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            DependencyInjectionRepositories(services);
        }

        private void DependencyInjectionRepositories(IServiceCollection services)
        {
            services.AddScoped<IIndividualRepository, IndividualRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
        }
    }
}
