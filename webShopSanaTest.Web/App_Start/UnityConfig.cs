using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace webShopSanaTest.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterTypes(
               AllClasses.FromLoadedAssemblies(),
               WithMappings.FromMatchingInterface,
               WithName.Default);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}

