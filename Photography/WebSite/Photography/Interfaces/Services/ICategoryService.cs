using Photography.Models;
using System.Collections.Generic;

namespace Photography.Interfaces
{
    public interface ICategoryService
    {
        Category GetById(int id);
        
        IEnumerable<Category> GetSortedVisibleCategories();

        CategoryViewModel ConvertToViewModel(Category category);
    }
}