using Photography.Models;
using System.Linq;

namespace Photography.Interfaces
{
    public interface IRepository<T> where T : DomainObject
    {
        IQueryable<T> GetAll();
        
        T GetById(int id);
        
        bool Create(T item);
        
        bool Delete(int id);

        bool SaveChanges();
    }
}