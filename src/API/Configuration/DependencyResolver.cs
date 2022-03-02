using Application.Commands.AddMap;
using Application.Commands.ImportMapDropFile;
using Application.Commands.ImportMonsterListFile;
using Application.Queries.GetMapList;
using Application.Services;
using Domain.Data;
using Infrastructure.Repositories;
using MediatR;
using System.Reflection;

namespace API.Configuration
{
    public static class DependencyResolver
    {
        public static void ResolveDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IXmlDeserializer, XmlDeserializer>();

            ResolveMediatorDependencies(builder);
            ResolveRepositoryDependencies(builder);
        }

        private static void ResolveMediatorDependencies(WebApplicationBuilder builder)
        {
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            builder.Services.AddScoped<IMediator, Mediator>();

            builder.Services.AddMediatR(typeof(GetMapListQueryHandler).Assembly);

            builder.Services.AddMediatR(typeof(AddMapCommandHandler).Assembly);

            builder.Services.AddMediatR(typeof(ImportMonsterListFileCommandHandler).Assembly);
        }

        private static void ResolveRepositoryDependencies(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IMapListRepository, MapListRepository>();
            builder.Services.AddScoped<IMapDropRepository, MapDropRepository>();
            builder.Services.AddScoped<IMonsterRepository, MonsterRepository>();
        }
    }
}
