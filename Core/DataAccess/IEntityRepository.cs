﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Uptade(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

    }
}
