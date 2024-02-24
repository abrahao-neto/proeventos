using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Service;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Domain.Interfaces.Services;
using ProEventos.Domain.Services;
using ProEventos.Infra.Data.Contexts;
using ProEventos.Infra.Data.Repositories;

namespace ProEventos.Infra.CrossCutting.Ioc
{
    public class DependencyInjection
    {
        public static void Registrar(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
              options.UseSqlServer(configuration.GetConnectionString("Default"))
           );

            // Evento
            services.AddTransient<IEventoAppService, EventoAppService>();
            services.AddTransient<IEventoDomainService, EventoDomainService>();
            services.AddTransient<IEventoRepository, EventoRepository>();
        }
    }
}