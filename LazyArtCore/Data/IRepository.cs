using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace LazyArtCore.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Finds();
        T Find(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
