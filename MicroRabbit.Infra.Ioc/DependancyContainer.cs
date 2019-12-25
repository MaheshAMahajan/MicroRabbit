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
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;

namespace MicroRabbit.Infra.Ioc
{
    public  class DependancyContainer
    { 
        public static void RegisteredServices(IServiceCollection services)
        {


            // services.AddMediatR(new Assembly[] { Assembly.GetExecutingAssembly() });
            //Domain Rabbit MQ Bus
            services.AddTransient<IEventBus, RabbitMQBus>();  
            
            //Banking Service CommandHandler 
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool> ,TransferCommandHandler>();

            //Apllication Services 
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data repository
            services.AddTransient<IAccountRepository, AccountRepository>(); 
            services.AddTransient<ITransferRepository, TransferRepository>();
            
            services.AddTransient<BankingDBContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
