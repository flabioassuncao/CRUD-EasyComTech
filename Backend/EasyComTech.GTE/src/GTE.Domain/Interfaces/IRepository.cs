using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class 
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        IEnumerable<TEntity> ToSeek(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
