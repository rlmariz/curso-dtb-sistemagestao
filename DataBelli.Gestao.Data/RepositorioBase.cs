using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataBelli.Gestao.Data
{
    public class RepositorioBase<T> where T : class
    {
        private DataContext context;
        public RepositorioBase(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Save(T instance)
        {
            this.context.Set<T>().Add(instance);
            this.context.SaveChanges();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> where)
        {
            return this.context.Set<T>().Where(where).ToList();
        }

        //public async IEquatable<T> GetAll()
        //{
        //    return await this.context.Set<T>().ToListAsync();
        //}
    }
}
