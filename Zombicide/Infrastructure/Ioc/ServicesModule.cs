using Autofac;
using Services.CardService;

namespace Zombicide.Infrastructure.Ioc
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(typeof(ICardService).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .Where(x => !x.IsInterface)
                .Where(x => !x.IsAbstract)
                .AsImplementedInterfaces();
        }
    }
}