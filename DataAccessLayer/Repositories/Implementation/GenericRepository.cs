using DataAccessLayer.Data;
using DataAccessLayer.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public ShoppingDBContext _context { get; }
        private readonly DbSet<T> _table;
        public GenericRepository(ShoppingDBContext context)
        {
            _context = context;
            _table =_context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();  
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);

        }

        public async Task<T> FindAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _table.ToListAsync();

        }
        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
           _context.SaveChanges();

        }
    }
}
