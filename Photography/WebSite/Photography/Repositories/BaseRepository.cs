using Photography.Interfaces;
using Photography.Models;
using System.Data.Entity;
using System.Linq;

namespace Photography.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : DomainObject
    {
        private IPhotographyContext dbContext;
        private DbSet<T> dbSet;

        public BaseRepository(IPhotographyContext photographyContext)
        {
            this.dbContext = photographyContext;
            this.dbSet = ((PhotographyContext)this.dbContext).Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            return this.dbSet;
        }

        public virtual T GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public virtual bool Create(T category)
        {
            return true;
        }

        public virtual bool Delete(int id)
        {
            return true;
        }

        public virtual bool SaveChanges()
        {
            return true;
        }
    }
}