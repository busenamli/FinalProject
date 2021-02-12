using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class : referans tip olabilir demek
    //T referans tipi ve IEntity ya da IEntity implemente eden bir nesne olabilir ve new'lenebilir(nesne) olmalıdır
    public interface IEntityRepository<T> where T:class,IEntity, new() 
    {
        //Sorguyu deişken olarak kullanabilmemizi sağlar
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
