namespace SW.NotationService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServicesExtension
    {
        public static void AddRepositoryService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NotationDbContext>(
                options => options.UseSqlServer(connectionString));
        }
    }
}
