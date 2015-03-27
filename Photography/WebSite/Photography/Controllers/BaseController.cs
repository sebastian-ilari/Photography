using Photography.Interfaces;
using Photography.Models;
using System.Web.Mvc;

namespace Photography.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ICategoryService categoryService;

        public BaseController() : this(null)
        {

        }
        
        public BaseController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // The default id of 1 is to send the user to the home page when there isn't any id on the URL.
        // TODO: maybe this logic can be resolved on the RouteConfig file?
        public virtual ActionResult Index(int id = 1)
        {
            Category category = this.categoryService.GetById(id);

            CategoryViewModel categoryViewModel = this.categoryService.ConvertToViewModel(category);

            return View(categoryViewModel);
        }
    }
}