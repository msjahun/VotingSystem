﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vs.Core;

namespace Vs.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Delete(T entity);
        T GetById(long id);
        long Insert(T entity);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        IEnumerable<T> Include(string path);
    }
}
