using Photography.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Photography.Interfaces;

namespace Photography.Controllers
{
    public class MenuController : BaseController
    {
        public MenuController() : this(null) 
        { 
        
        }

        public MenuController(ICategoryService categoryService) : base(categoryService)
        {

        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            IEnumerable<Category> categories = this.categoryService.GetSortedVisibleCategories();

            return PartialView("_Menu", categories);
        }
    }
}