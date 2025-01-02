namespace DemoDI.Implementations.Interface;

public interface IGenericBaseRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(int id);
}
