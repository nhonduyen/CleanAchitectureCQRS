using Microsoft.EntityFrameworkCore;
using Ordering.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordering.Core.Repositories.Command.Base;

namespace Ordering.Infrastructure.Repositories.Command.Base
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        protected readonly OrderingContext _context;

        public CommandRepository(OrderingContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity, CancellationToken ct = default)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public async Task<List<T>> AddRangeAsync(List<T> entity, CancellationToken ct = default)
        {
            await _context.Set<T>().AddRangeAsync(entity);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public async Task UpdateAsync(T entity, CancellationToken ct = default)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(ct);
        }

        public async Task DeleteAsync(T entity, CancellationToken ct = default)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync(ct);
        }
    }
}
