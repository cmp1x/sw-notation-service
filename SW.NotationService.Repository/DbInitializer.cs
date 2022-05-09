namespace SW.NotationService.Repository
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using SW.NotationService.Repository.Models;
    using System;

    public static class DbInitializer
    {
        public static void DbInitialize (this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var db = scope.ServiceProvider.GetService<NotationDbContext>())
                {
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    //Notations
                    db.Notations.Add(new NotationDb() { Id="1", ArtistName="Zemfira", CreatedAt = new DateTime(2007-01-01) });
                    db.SaveChanges();
                }
            }
        }
    }
}
