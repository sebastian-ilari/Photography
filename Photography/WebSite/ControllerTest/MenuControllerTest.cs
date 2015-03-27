using Photography.Models;
using System.Web.Mvc;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Photography.Controllers;
using System.Collections.Generic;
using Common;
using Photography.Interfaces;

namespace ControllerTest
{
    [TestClass]
    public class MenuControllerTest : TestContext<MenuController>
    {
        [TestInitialize]
        public void Initialize()
        {
            this.Container.GetMock<ICategoryService>()
                    .Setup(repo => repo.GetSortedVisibleCategories())
                    .Returns(new List<Category>
                                        {
                                            new Category { Visible = true, Position = 3 },
                                            new Category { Visible = false, Position = 2 },
                                            new Category { Visible = true, Position = 5 },
                                        }.AsQueryable)
                    .Verifiable();
        }

        [TestMethod]
        public void TestMenuControllerHasAtLeastOneCategory()
        {
            PartialViewResult result = (PartialViewResult)this.Entity.Menu();
            IEnumerable<Category> categories = (IEnumerable<Category>)result.Model;

            Assert.IsTrue(categories.Count() > 0);
        }
    }
}
