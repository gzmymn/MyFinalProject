using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //
{
    //generic constraint(jenerik kısıt) T'ye verilebilecek şeyleri belirliyoruz
    //class=referance type, referans tip olabilir
    //IEntity : referans tip ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity, new() //burada bir standart oluşturduk
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
