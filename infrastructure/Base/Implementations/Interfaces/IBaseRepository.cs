using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Base.Implementations.Interfaces;

public interface IBaseRepository<TModel>
{
    Task<List<TModel>> GetAsync();
    Task<TModel?> GetAsync(Guid id);
    Task CreateAsync(TModel newItem);
    Task UpdateAsync(Guid id, TModel updatedItem);
    Task DeleteAsync(Guid id);
}
