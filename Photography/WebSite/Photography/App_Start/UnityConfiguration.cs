using Microsoft.Practices.Unity;
using Photography.Business;
using Photography.Interfaces;
using Photography.Models;
using Photography.Repositories;
using Photography.Services;
using System.Web.Mvc;
using Unity.Mvc4;

namespace Photography.Business
{
    public class UnityConfiguration
    {
        public static void ConfigureIoCContainer()
        {
            IUnityContainer container = new UnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            RegisterTypes(container);
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IRepository<Category>, CategoryRepository>(new TransientLifetimeManager());
            container.RegisterType<ICategoryBusiness,  CategoryBusiness>(new TransientLifetimeManager());
            container.RegisterType<ICategoryService, CategoryService>(new TransientLifetimeManager());
            container.RegisterType<IPhotographyContext, PhotographyContext>(new TransientLifetimeManager());
        }
    }
}