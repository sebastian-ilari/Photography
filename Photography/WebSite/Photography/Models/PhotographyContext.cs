using Photography.Interfaces;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Photography.Models
{
    public class PhotographyContext : DbContext, IPhotographyContext
    {
        public PhotographyContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}