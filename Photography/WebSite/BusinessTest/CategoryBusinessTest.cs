using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Photography.Models;
using Photography.Business;
using Photography.Models.Enums;
using Photography.Interfaces;
using Photography.Business;

namespace BusinessTest
{
    [TestClass]
    public class CategoryBusinessTest
    {
        protected ICategoryBusiness categoryBusiness { get; set; }
        protected IList<Category> mockCategories { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.categoryBusiness = new CategoryBusiness();
            this.mockCategories = DataGenerator.Categories;
        }

        [TestMethod]
        public void TestGetPicturesFromCategoryByPictureTypeReturnsPicturesFromPictureType()
        {
            PictureType aPictureType = PictureType.Thumbnail;

            IEnumerable<Picture> filteredPictures = 
                                        this.categoryBusiness.GetPicturesFromCategoryByPictureType(this.mockCategories[2],
                                                                                                        aPictureType);

            Assert.IsTrue(this.AreAllPicturesFromTheSamePictureType(aPictureType, filteredPictures));
        }

        [TestMethod]
        public void TestGetPicturesFromCategoryByPictureTypeReturnsPicturesFromCategory()
        {
            PictureType aPictureType = PictureType.Thumbnail;
            Category aCategory = this.mockCategories[2];

            IEnumerable<Picture> filteredPictures = this.categoryBusiness.GetPicturesFromCategoryByPictureType(aCategory, 
                                                                                                        aPictureType);

            bool areFromTheCategory = false;

            foreach (Picture picture in filteredPictures)
            {
                areFromTheCategory = aCategory.Pictures.Contains(picture);
            }

            Assert.IsTrue(areFromTheCategory);
        }

        [TestMethod]
        public void TestGetSingleImageFullPathByCategoryAndPictureTypeReturnsItsFullPath()
        {
            PictureType aPictureType = PictureType.Thumbnail;
            Category aCategory = this.mockCategories[2];

            IEnumerable<Picture> filteredPictures = this.categoryBusiness.GetPicturesFromCategoryByPictureType(aCategory,
                                                                                                        aPictureType);

            string imageFullPath = this.categoryBusiness.GetSingleImageFullPathByCategoryAndPictureType(aCategory,
                                                                                                        aPictureType);

            Assert.AreEqual(filteredPictures.First().FullPath, imageFullPath);
        }

        [TestMethod]
        public void TestGetSingleImageFullPathByCategoryAndPictureTypeReturnsEmptyString()
        {
            PictureType aPictureType = PictureType.Background;
            Category aCategory = this.mockCategories[2];

            string imageFullPath = this.categoryBusiness.GetSingleImageFullPathByCategoryAndPictureType(aCategory,
                                                                                                        aPictureType);

            Assert.AreEqual(string.Empty, imageFullPath);
        }

        [TestMethod]
        public void TestGetImageFullPathListByCategoryAndPictureTypeReturnsAListWithTheRightCount()
        {
            PictureType aPictureType = PictureType.Background;
            Category aCategory = this.mockCategories.First();
            IEnumerable<Picture> pictures = this.categoryBusiness.GetPicturesFromCategoryByPictureType(aCategory, aPictureType);

            IEnumerable<string> backgroundImagePaths = this.categoryBusiness.GetImageFullPathListByCategoryAndPictureType(aCategory, aPictureType);

            Assert.AreEqual(pictures.Count(), backgroundImagePaths.Count());
        }



        private bool AreAllPicturesFromTheSamePictureType(PictureType pictureType, IEnumerable<Picture> filteredPictures)
        {
            foreach (Picture picture in filteredPictures)
            {
                if (!picture.PictureType.Equals(pictureType))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
