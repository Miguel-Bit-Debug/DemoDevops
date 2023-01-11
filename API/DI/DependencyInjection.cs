using Domain.Commands.AddProduct;
using MediatR;
using System.Reflection;

namespace API.DI;

public static class DependencyInjection
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
        builder.Services.AddMediatR(typeof(AddProductCommand));
    }
}
