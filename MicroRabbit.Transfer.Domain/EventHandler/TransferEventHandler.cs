using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly IEventBus _bus = null;

        private readonly ITransferRepository _transferRepository = null; 
        public TransferEventHandler(ITransferRepository  transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new Model.TransferLog { FromAccount = @event.From ,  
              ToAccount = @event.To, 
              TransferAmount = @event.Amount
            }); 

            return Task.CompletedTask;
        }
    }
}
