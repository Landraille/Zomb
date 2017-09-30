using Autofac;
using Caliburn.Micro;

namespace Zombicide.Infrastructure.Ioc
{
    public class CaliburnModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<EventAggregator>()
                .SingleInstance()
                .AsImplementedInterfaces()
                .AsSelf();

            builder.RegisterType<WindowManager>()
                .SingleInstance()
                .AsImplementedInterfaces()
                .AsSelf();

            builder.RegisterAssemblyTypes(typeof(CaliburnModule).Assembly)
                .Where(x => x.Name.EndsWith("View") || x.Name.EndsWith("ViewModel"))
                .InstancePerDependency()
                .AsSelf();

            //builder.RegisterType<ButtonsActionViewModel>()
            //    .SingleInstance();


        }
    }
}