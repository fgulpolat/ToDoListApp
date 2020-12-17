using Business.Abstract;
using Business.Concrete;
using Ninject;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ToDoListApp.Data.Concrete.EntityFramework;

namespace ToDoListApp.NinjectController
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private readonly IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBusinessBinding();
        }

        private void AddBusinessBinding()
        {
            ninjectKernel.Bind<ITaskService>().To<TaskManager>().WithConstructorArgument("taskDal", new EfTaskDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}