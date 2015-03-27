using Photography.Models;
using System.Data.Entity;

namespace Photography.Interfaces
{
    public interface IPhotographyContext
    {
        DbSet<Category> Categories { get; set; }
    }
}