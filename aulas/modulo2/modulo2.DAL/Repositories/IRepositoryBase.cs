using System;
using System.Collections.Generic;
namespace modulo2.DAL.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
         void Add(TEntity obj);
                 void AddRange(ICollection<TEntity> obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}