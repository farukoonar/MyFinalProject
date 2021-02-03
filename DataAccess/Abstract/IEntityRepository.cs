using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //nesne olmalıdır
    //IEmtity veya IEntity implemente eden bir nesne olabilir
    //mewlenebilir olmalıdır
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //generic repository desing pattern
        List<T> GetAll(Expression<Func<T,bool>> filter= null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
