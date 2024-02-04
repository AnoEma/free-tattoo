using Domain.InterfacesRepositorys;

namespace Infrastructure.Repository;

public class BaseRepository : IBaseRepository
{
    public Task<T> CreateAsync<T>(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync<T>()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAllAsync<T>()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync<T>()
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync<T>()
    {
        throw new NotImplementedException();
    }
}