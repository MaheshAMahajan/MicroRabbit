using MicroRabbit.Transfer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Interfaces
{ 
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void  Add(TransferLog transferLog); 
    }
}
