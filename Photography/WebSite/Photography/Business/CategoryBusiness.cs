using AutoMapper;
using Photography.Interfaces;
using Photography.Models;
using Photography.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Photography.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        public IEnumerable<Picture> GetPicturesFromCategoryByPictureType(Category category, PictureType pictureType)
        {
            return category.Pictures
                                .Where<Picture>(
                                    picture => picture.PictureType.Equals(pictureType))
                                        .ToList();
        }
        
        public string GetSingleImageFullPathByCategoryAndPictureType(Category category, PictureType pictureType)
        {
            Picture picture = this.GetPicturesFromCategoryByPictureType(category, pictureType).FirstOrDefault();

            return picture != null ? picture.FullPath : string.Empty;
        }

        public IEnumerable<string> GetImageFullPathListByCategoryAndPictureType(Category category, PictureType pictureType)
        {
            IEnumerable<Picture> pictures = this.GetPicturesFromCategoryByPictureType(category, pictureType);

            IList<string> imagePaths = new List<string>();

            foreach(Picture picture in pictures)
            {
                imagePaths.Add(picture.FullPath);
            }

            return imagePaths;
        }
    }
}