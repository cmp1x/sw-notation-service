namespace SW.NotationService.Repository.Repositories
{
    using SW.NotationService.Repository.Models;
    using System.Linq;

    public interface INotationRepository
    {
        NotationDb Get(string id);
        IQueryable<NotationDb> GetAll();
    }
}