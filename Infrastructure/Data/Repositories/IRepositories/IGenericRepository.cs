using Core.Entities;

namespace Infrastructure.Data.Repositories.IRepositories;

public interface IGenericRepository<T> where T:BaseEntity
{
    Task<IReadOnlyList<T>> getListOfAsync();
    Task<T> getListOfByIdAsync(long id);
    

}