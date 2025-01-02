using DemoDI.Implementations.Interface;

namespace DemoDI.Implementations.Repository;

public class GenericBaseRepository<T> : IGenericBaseRepository<T> where T : class
{
    public Task<T> Create(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
