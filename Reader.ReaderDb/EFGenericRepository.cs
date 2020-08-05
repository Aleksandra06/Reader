using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Reader.ReaderDb
{
    public class EFRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext mContext;
        DbSet<TEntity> mDbSet;

        public EFRepository(DbContext context)
        {
            mContext = context;
            mDbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return mDbSet.ToList();
        }
        public IQueryable<TEntity> GetQueryable()
        {
            return mDbSet.AsQueryable();
        }

        public IEnumerable<TEntity> Take(int count)
        {
            return mDbSet.Take(count).ToList();
        }

        public IEnumerable<TEntity> Take(int count, Func<TEntity, bool> predicate)
        {
            return mDbSet.Where(predicate).Take(count).ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return mDbSet.Where(predicate).ToList();
        }

        public TEntity FindById(int id)
        {
            return mDbSet.Find(id);
        }

        public TEntity Create(TEntity item)
        {
            var itemNew = mDbSet.Add(item).Entity;
            mContext.SaveChanges();
            return itemNew;
        }
        public TEntity Update(TEntity item, string operation = "")
        {
            mContext.Entry(item).State = EntityState.Modified;
            mContext.SaveChanges();
            return item;
        }

        public void Remove(TEntity item)
        {
            mDbSet.Attach(item);
            mDbSet.Remove(item);
            mContext.SaveChanges();
        }
        public TEntity Reload(int id)
        {
            var item = mDbSet.Find(id);
            mContext.Entry(item).State = EntityState.Detached;
            var result = mContext.Entry(item).GetDatabaseValues();
            if (result == null)
            {
                return null;
            }
            else
            {
                return (TEntity)result.ToObject();
            }
        }
    }
}
