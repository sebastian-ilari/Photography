using Photography.Interfaces;

namespace Photography.Controllers
{
    public class AboutController : BaseController
    {
        public AboutController() : this(null)
        {

        }

        public AboutController(ICategoryService categoryService) : base(categoryService)
        {

        }
    }
}