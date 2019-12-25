using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Reflection;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.CommandHandlers;

namespace MicroRabbit.Infra.Ioc
{
    public  class DependancyContainer
    { 
        public static void RegisteredServices(IServiceCollection services)
        {
            //Domain Bus 

           // services.AddMediatR(new Assembly[] { Assembly.GetExecutingAssembly() });

            services.AddTransient<IEventBus, RabbitMQBus>();  
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool> ,TransferCommandHandler>();

            //Apllication Services 5
            services.AddTransient<IAccountService, AccountService>();

            //Application Data repository
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>(); 
        }
    }
}
