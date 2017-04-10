using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this._kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}