using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstraction
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task Delete(int id);
        Task Update(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> FindAsync(int id);
    }
}
