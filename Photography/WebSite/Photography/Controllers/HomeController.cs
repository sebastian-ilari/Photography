using Photography.Interfaces;
using Photography.Repositories;
using Photography.Services;

namespace Photography.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController() : this(null)
        {

        }

        public HomeController(ICategoryService categoryService) : base(categoryService)
        {

        }
    }
}