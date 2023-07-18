using System;
using System.Linq.Expressions;
using System.Security.Principal;
using K101MovieApp.Core.Entities.Abstract;

namespace K101MovieApp.Core.DataAccess
{
    public interface IRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
    }
}

