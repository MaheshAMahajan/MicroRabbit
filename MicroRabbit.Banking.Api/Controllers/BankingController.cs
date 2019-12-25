using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Api.Infra;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService = null;
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        } 

        [HttpGet(ApiRoutes.BankingApi.GetAccounts)] 
        public  IActionResult Get()
        {
            return Ok(_accountService.GetAccounts());
        }  
    }
}