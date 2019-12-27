using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Api.Infra;
using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
 
    [ApiController]
    public class TransferController : ControllerBase
    {

        private readonly ITransferService _transferService = null; 
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        } 

        [HttpGet(ApiRoute.TransferApi.Get)]
        public IActionResult  Get()
        {
            return Ok(_transferService.GetTrasferLogs());
        }

    }
}