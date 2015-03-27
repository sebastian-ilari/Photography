using AutoMapper;
using Photography.Business;
using Photography.Interfaces;
using Photography.Models;
using Photography.Models.Enums;

namespace Photography.Converters
{
    public class CategoryViewModelConverter : ITypeConverter<Category, CategoryViewModel>
    {
        private ICategoryBusiness categoryBusiness;

        public CategoryViewModelConverter()
        {
            this.categoryBusiness = new CategoryBusiness();
        }

        // TODO: This should work with Unity
        //public CategoryViewModelConverter(ICategoryBusiness categoryBusiness)
        //{
        //    this.categoryBusiness = categoryBusiness;
        //}

        public CategoryViewModel Convert(ResolutionContext context)
        {
            Category category = (Category)context.SourceValue;
            
            return new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                BackgroundImagePath = this.categoryBusiness
                                                .GetSingleImageFullPathByCategoryAndPictureType(category, PictureType.Background),
                BackgroundImagePathList = this.categoryBusiness
                                                .GetImageFullPathListByCategoryAndPictureType(category, PictureType.Background),
                CoverImagePath = this.categoryBusiness
                                                .GetSingleImageFullPathByCategoryAndPictureType(category, PictureType.Cover),
                ThumbnailImagePathList = this.categoryBusiness
                                                .GetImageFullPathListByCategoryAndPictureType(category, PictureType.Thumbnail),
            };
        }
    }
}