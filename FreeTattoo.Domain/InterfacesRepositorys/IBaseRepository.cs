namespace Domain.InterfacesRepositorys;

public interface IBaseRepository
{
    Task <T> CreateAsync<T>(T entity);
    Task<T> UpdateAsync<T>();
    Task<T> DeleteAsync<T>();
    Task<T> GetAsync<T>();
    Task<T> GetAllAsync<T>();
}