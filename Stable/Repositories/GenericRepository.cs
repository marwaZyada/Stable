
using Microsoft.EntityFrameworkCore;
using Stable.Data;
using Stable.Models;
using Stable;
using Stable.Specifications;

namespace Stable.Repositories
{
    public class GenericRepository<T> : IGeneicRepository<T> where T:BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(T entity)
        {
         await  _context.Set<T>().AddAsync(entity);
          return  await _context.SaveChangesAsync();
            
        }

        public async Task<int> DeleteAsync(T entity)
        {
             _context.Set<T>().Remove(entity);
         return   await _context.SaveChangesAsync();
          
        }

        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
             _context.Set<T>().Update(entity);
         return   await _context.SaveChangesAsync();
           
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>(), spec);
        }

        
    }
}
