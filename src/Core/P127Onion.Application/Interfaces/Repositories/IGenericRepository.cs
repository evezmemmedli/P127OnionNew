using P127Onion.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T>  where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
