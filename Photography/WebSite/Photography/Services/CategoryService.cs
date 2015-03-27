using AutoMapper;
using Photography.Interfaces;
using Photography.Models;
using System.Collections.Generic;
using System.Linq;

namespace Photography.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> categoryRepository;
        private ICategoryBusiness categoryBusiness;

        public CategoryService(IRepository<Category> categoryRepository, ICategoryBusiness categoryBusiness)
        {
            this.categoryRepository = categoryRepository;
            this.categoryBusiness = categoryBusiness;
        }

        public Category GetById(int id)
        {
            return this.categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetSortedVisibleCategories()
        {
            return this.categoryRepository.GetAll()
                                            .Where(category => category.Visible)
                                            .OrderBy(categpry => categpry.Position);
        }

        public CategoryViewModel ConvertToViewModel(Category category)
        {
            return Mapper.Map<Category, CategoryViewModel>(category);
        }
    }
}