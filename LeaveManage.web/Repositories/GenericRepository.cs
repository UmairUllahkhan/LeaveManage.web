﻿using LeaveManage.web.Data;
using LeaveManage.web.Repository;
using Microsoft.EntityFrameworkCore;

namespace LeaveManage.web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(List<T> entity)
        {
            await _context.AddRangeAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }



        public async Task UpdateAsync(T entity)
        {
            //_context.Entry(entity).State = EntityState.Modified;
            _context.Update(entity);
            
        }
    }
}
