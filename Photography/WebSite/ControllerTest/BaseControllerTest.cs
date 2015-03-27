using Photography.Models;
using System.Web.Mvc;
using Photography.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using Photography.Interfaces;

namespace ControllerTest
{
    [TestClass]
    public class BaseControllerTest : TestContext<HomeController>
    {
        private int anotherCategoryId { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.anotherCategoryId = 3;
            
            Category homeCategory = new Category
            {
                Id = 1,
                Name = "Home",
                Description = "Mock Home Category",
                Visible = true,
                Position = 1,
            };

            Category anotherCategory = new Category
            {
                Id = this.anotherCategoryId,
                Name = "Landscape",
                Description = "Another Mock Category",
                Visible = true,
                Position = 5,
            };

            this.Container.GetMock<ICategoryService>()
                    .Setup(repo => repo.GetById(homeCategory.Id))
                    .Returns(homeCategory)
                    .Verifiable();

            this.Container.GetMock<ICategoryService>()
                    .Setup(repo => repo.GetById(this.anotherCategoryId))
                    .Returns(anotherCategory)
                    .Verifiable();

            this.Container.GetMock<ICategoryService>()
                    .Setup(repo => repo.ConvertToViewModel(homeCategory))
                    .Returns(
                                new CategoryViewModel
                                {
                                    Id = homeCategory.Id,
                                    Name = homeCategory.Name,
                                    Description = homeCategory.Description,
                                }
                            );

            this.Container.GetMock<ICategoryService>()
                    .Setup(repo => repo.ConvertToViewModel(anotherCategory))
                    .Returns(
                                new CategoryViewModel
                                {
                                    Id = this.anotherCategoryId,
                                    Name = anotherCategory.Name,
                                    Description = anotherCategory.Description,
                                }
                            );
        }

        [TestMethod]
        public void TestBaseControllerIndexReturnsNotNull()
        {
            ViewResult result = (ViewResult)this.Entity.Index();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestBaseControllerIndexReturnsCategoryViewModel()
        {
            ViewResult result = (ViewResult)this.Entity.Index();

            Assert.IsNotNull((CategoryViewModel)result.Model);
        }

        [TestMethod]
        public void TestBaseControllerIndexReturnsHomeCategoryWithNoParameters()
        {
            ViewResult result = (ViewResult)this.Entity.Index();

            Assert.AreEqual("Home", ((CategoryViewModel)result.Model).Name);
        }

        [TestMethod]
        public void TestBaseControllerIndexReturnsReturnsRightCategory()
        {
            ViewResult result = (ViewResult)this.Entity.Index(this.anotherCategoryId);

            Assert.AreEqual(this.anotherCategoryId, ((CategoryViewModel)result.Model).Id);
        }
    }
}