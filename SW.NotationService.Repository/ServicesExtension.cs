namespace SW.NotationService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SW.NotationService.Repository.Repositories;

    public static class ServicesExtension
    {
        public static void AddRepositoryService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NotationDbContext>(
                options => options.UseSqlServer(connectionString));

            services.AddTransient<INotationRepository, NotationRepository>();
        }
    }
}
