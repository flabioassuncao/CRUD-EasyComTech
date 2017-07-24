using AutoMapper;
using GTE.Application.Interfaces;
using GTE.Application.Services;
using GTE.Domain.Interfaces;
using GTE.Infra.Data.Context;
using GTE.Infra.Data.Repository;
using GTE.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IProgrammerAppService, ProgrammerAppService>();
            services.AddScoped<IBankInformationAppService, BankInformationAppService>();
            services.AddScoped<IOccupationAreaAppService, OccupationAreaAppService>();
            services.AddScoped<IKnowledgeAppService, KnowledgeAppService>();

            //Infra - DATA
            services.AddScoped<IProgrammerRepository, ProgrammerRepository>();
            services.AddScoped<IOccupationAreaRepository, OccupationAreaRepository>();
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IBankInformationRepository, BankInformationRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<GTEContext>();
        }
    }
}
