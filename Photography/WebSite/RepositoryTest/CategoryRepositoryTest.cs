using Microsoft.VisualStudio.TestTools.UnitTesting;
using Photography.Models;
using System.Linq;
using Photography.Services;
using System.Collections.Generic;
using Common;
using Photography.Interfaces;

namespace RepositoryTest
{
    [TestClass]
    public class CategoryRepositoryTest : TestContext<CategoryService>
    {
        [TestInitialize]
        public void Initialize()
        {
            this.Container.GetMock<IRepository<Category>>()
                    .Setup(repo => repo.GetAll())
                    .Returns(new List<Category>
                                        {
                                            new Category { Visible = true, Position = 3 },
                                            new Category { Visible = false, Position = 2 },
                                            new Category { Visible = true, Position = 5 },
                                        }.AsQueryable)
                    .Verifiable();
        }
        
        [TestMethod]
        public void TestGetSortedVisibleCategoriesReturnsOnlyVisibleCategories()
        {
            Assert.IsTrue(this.Entity.GetSortedVisibleCategories().All<Category>(category => category.Visible));
        }

        [TestMethod]
        public void TestGetSortedVisibleCategoriesReturnsOrderedCategories()
        {
            IEnumerable<Category> categories = this.Entity.GetSortedVisibleCategories();

            IEnumerable<Category> sortedCategories = categories.OrderBy(cat => cat.Position);
            
            //NUnit implementation
            //Assert.That(categories, Is.Ordered.By("Position"));

            Assert.IsTrue(categories.SequenceEqual(sortedCategories));
        }
    }
}