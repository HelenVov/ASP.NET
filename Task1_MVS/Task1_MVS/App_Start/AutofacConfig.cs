﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using DataAccess.Models;
using Task1_MVC.WorkWithData;

namespace Task1_MVC.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<WorkWithDatabase>().As<WorkWithDatabase>();
            builder.RegisterType<SetBlogDataContext>().As<SetBlogDataContext>().InstancePerRequest();
            builder.RegisterType<Сonverter>().As<Сonverter>().SingleInstance();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}