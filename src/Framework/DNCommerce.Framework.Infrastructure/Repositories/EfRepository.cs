using DNCommerce.Application;
using DNCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DNCommerce.Framework.Infrastructure.Repositories
{
    public partial class EfRepository<TObject> : IRepository<TObject> where TObject : class
    {
        protected ApplicationDbContext _context;

        public EfRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<TObject> GetAll()
        {

            return _context.Set<TObject>().ToList();
        }

        public async Task<ICollection<TObject>> GetAllAsync()
        {
            return await _context.Set<TObject>().ToListAsync();
        }

        public TObject Get(object id)
        {
            return _context.Set<TObject>().Find(id);
        }

        public async Task<TObject> GetAsync(object id)
        {
            return await _context.Set<TObject>().FindAsync(id);
        }

        public TObject Find(Expression<Func<TObject, bool>> match)
        {
            return _context.Set<TObject>().SingleOrDefault(match);
        }

        public async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match)
        {
            return await _context.Set<TObject>().SingleOrDefaultAsync(match);
        }

        public ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match)
        {
            return _context.Set<TObject>().Where(match).ToList();
        }

        public async Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match)
        {
            return await _context.Set<TObject>().Where(match).ToListAsync();
        }

        public TObject Add(TObject dao)
        {
            _context.Set<TObject>().Add(dao);
            _context.SaveChanges();
            return dao;
        }

        public async Task<Guid> AddAsync(TObject dao)
        {
            _context.Set<TObject>().Add(dao);
            await _context.SaveChangesAsync();
            return n ;
        }

        public TObject Update(TObject dao, int key)
        {
            if (dao == null)
                return null;

            TObject existing = _context.Set<TObject>().Find(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(dao);
                _context.SaveChanges();
            }
            return existing;
        }

        public async Task<TObject> UpdateAsync(TObject dao, int key)
        {
            if (dao == null)
                return null;

            TObject existing = await _context.Set<TObject>().FindAsync(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(dao);
                await _context.SaveChangesAsync();
            }
            return existing;
        }

        public void Delete(TObject dao)
        {
            _context.Set<TObject>().Remove(dao);
            _context.SaveChanges();
        }

        public async Task<int> DeleteAsync(TObject t)
        {
            _context.Set<TObject>().Remove(t);
            return await _context.SaveChangesAsync();
        }

        public int Count()
        {
            return _context.Set<TObject>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<TObject>().CountAsync();
        }
    }
}