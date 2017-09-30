using System;
using System.Collections.Generic;
using System.Windows;
using Autofac;
using Caliburn.Micro;
using Zombicide.Business;
using IContainer = Autofac.IContainer;

namespace Zombicide.Infrastructure
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper() : base()
        {
            Initialize();
        }
        private IContainer _container;

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof(AppBootstrapper).Assembly);
            return builder.Build();
        }

        protected override void Configure()
        {
            _container = BuildContainer();
            base.Configure();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }


        protected override object GetInstance(Type service, string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return _container.Resolve(service);
            }

            return _container.ResolveNamed(key, service);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return new object[] { GetInstance(service, null) };
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            //TODO save game
            //CurrentGame.Save();
        }
    }
}