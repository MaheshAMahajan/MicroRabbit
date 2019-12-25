using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository = null;
        private readonly IEventBus _bus = null;
        public TransferService(ITransferRepository transferRepository , IEventBus bus )
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTrasferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
