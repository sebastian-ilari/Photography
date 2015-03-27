using Photography.Interfaces;

namespace Photography.Controllers
{
    public class DetailController : BaseController
    {
        public DetailController() : this(null)
        {

        }

        public DetailController(ICategoryService categoryService) : base(categoryService)
        {

        }
    }
}