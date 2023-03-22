using Core.Entities;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Impl;

public class GenericRepository<T>:IGenericRepository<T> where T:BaseEntity
{
    private readonly DataContext _context;

    public GenericRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<T>> getListOfAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> getListOfByIdAsync(long id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}