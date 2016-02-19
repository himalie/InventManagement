using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Owin;
using Autofac.Integration.Mvc;
using AutofacSerilogIntegration;
using System.Web.Mvc;

namespace InventManagement.Client.Web.App_Start
{
    public partial class Startup
    {
        public void ConfigureAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var logger = ConfigureLogging();
            builder.RegisterLogger(logger);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterType<CarManager>().As<ICarManager>();
            //builder.RegisterType<EnquiryManager>().As<IEnquiryManager>();
            //builder.RegisterType<CommentManager>().As<ICommentManager>();

            //builder.RegisterType<CarContext>().As<CarContext>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}