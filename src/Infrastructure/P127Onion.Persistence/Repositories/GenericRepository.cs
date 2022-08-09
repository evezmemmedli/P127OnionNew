using Microsoft.EntityFrameworkCore;
using P127Onion.Application.Interfaces.Repositories;
using P127Onion.Domain.Entities.Base;
using P127Onion.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ProniaDbContext _context;

        public GenericRepository(ProniaDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
             _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async  Task<List<T>> GetAllAsync()
        {
            List<T> values = await _context.Set<T>().ToListAsync();
            return values;
        }

        public async Task<T> GetById(int id)
        {
            T value = await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
            return value;
        }

      
    }
}
