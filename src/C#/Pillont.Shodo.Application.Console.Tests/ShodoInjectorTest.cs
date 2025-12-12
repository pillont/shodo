using Microsoft.Extensions.DependencyInjection;
using Pillont.Shodo.Application.Injector;

namespace Pillont.Shodo.Application.Console.Tests;

public class ShodoInjectorTest
{
    [Fact]
    public void InjectionTest()
    {
        var services = new ServiceCollection();
        ShodoInjector.AddShodo(services);

        AssertInjectionIsValid(services);
    }

    private static IServiceProvider AssertInjectionIsValid(IServiceCollection services)
    {
        var provider = services
            .BuildServiceProvider();

        var instances = services
            .Where(t =>
                // NOTE : skip microsoft extensions && MediatR
                !t.ServiceType.FullName!.StartsWith("MediatR.IPipelineBehavior")
                && !t.ServiceType.FullName!.StartsWith("Microsoft.Extensions")

            ).Select(desc => new
            {
                Description = desc,
                Instances = provider.GetServices(desc.ServiceType),
            })
            .ToList();

        foreach (var inst in instances)
        {
            if (inst.Instances.Any(i => i is null))
            {
                throw new Exception($"Some implementations are null : {inst.Description}");
            }
        }

        return provider;
    }
}
