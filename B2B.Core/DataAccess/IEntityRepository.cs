
using B2B.Core.Entities;
using System.Linq.Expressions;

namespace B2B.Core.DataAccess;

public interface IEntityRepository<T> where T : class,IEntity, new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetList(Expression<Func<T,bool>> filter=null);
    T Get(Expression<Func<T, bool>> filter);
}
