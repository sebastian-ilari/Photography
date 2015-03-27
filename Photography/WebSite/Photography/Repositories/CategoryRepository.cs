using Photography.Interfaces;
using Photography.Models;

namespace Photography.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(IPhotographyContext photographyContext) : base(photographyContext)
        {

        }
    }
}