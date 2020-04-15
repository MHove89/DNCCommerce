using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DNCommerce.Application
{
    public interface IRepository<TObject> where TObject : class
    {
        TObject Add(TObject dao);
        Task<TObject> AddAsync(TObject dao);
        int Count();
        Task<int> CountAsync();
        void Delete(TObject dao);
        Task<int> DeleteAsync(TObject dao);
        TObject Find(Expression<Func<TObject, bool>> match);
        ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match);
        Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match);
        Task<TObject> FindAsync(Expression<Func<TObject, bool>> match);
        TObject Get(object id);
        ICollection<TObject> GetAll();
        Task<ICollection<TObject>> GetAllAsync();
        Task<TObject> GetAsync(object id);
        TObject Update(TObject dao, int key);
        Task<TObject> UpdateAsync(TObject dao, int key);
    }
}