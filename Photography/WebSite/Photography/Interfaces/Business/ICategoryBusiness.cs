using Photography.Models;
using Photography.Models.Enums;
using System.Collections.Generic;

namespace Photography.Interfaces
{
    public interface ICategoryBusiness
    {
        IEnumerable<Picture> GetPicturesFromCategoryByPictureType(Category category, PictureType pictureType);

        string GetSingleImageFullPathByCategoryAndPictureType(Category category, PictureType pictureType);

        IEnumerable<string> GetImageFullPathListByCategoryAndPictureType(Category category, PictureType pictureType);
    }
}