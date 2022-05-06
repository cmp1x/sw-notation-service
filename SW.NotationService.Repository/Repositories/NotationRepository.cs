namespace SW.NotationService.Repository.Repositories
{
    using SW.NotationService.Repository.Models;
    using System.Linq;

    public class NotationRepository : INotationRepository
    {
        private NotationDbContext db;

        public NotationRepository(NotationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<NotationDb> GetAll()
        {
            return this.db.Notations;
        }

        public NotationDb Get(string id)
        {
            return this.db.Notations.FirstOrDefault(
                n => n.Id == id);
        }
    }
}
