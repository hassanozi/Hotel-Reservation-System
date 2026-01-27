using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain.IRepositories
{
    public interface IGeneralRepository<T> where T : BaseModel
    {
        Task<T?> Get(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();
        Task<T?> GetById(int id);
        Task<T?> GetWithTrackingById(int id);
        Task<T?> GetWithTracking(Expression<Func<T, bool>> predicate);
        bool Add(T entity);
        void Update(T entity);
        void SoftDelete(T entity);
        void HardDelete(int id);
        Task SaveChanges();
        bool Exists(int id);
        Task<IEnumerable<TResult>> GetFilter<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> selector);
    }
}
