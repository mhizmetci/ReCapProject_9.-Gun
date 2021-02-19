﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic Constraint : jenerik kısıt.
    //class: referans tip olabilir.
    // IEntity : IEntity olabilir ya da IEntity implemente eden bir nesene olabilir.
    // new() : new lenebilir olmalı.
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetById(int Id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
