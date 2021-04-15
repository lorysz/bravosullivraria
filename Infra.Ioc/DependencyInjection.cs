using Application.Interfaces;
using Application.Services;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infra.Ioc
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped<ILivroApplication, LivroApplication>();
            svcCollection.AddScoped<IClienteApplication, ClienteApplication>();

            //Domínio
            svcCollection.AddScoped<ILivroService, LivroService>();
            svcCollection.AddScoped<IClienteService, ClienteService>();

            //Repositorio
            svcCollection.AddScoped<ILivroRepository, LivroRepository>();
            svcCollection.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}
