using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Services;
using MicroRabbit.MVC.ViewModels;

namespace MicroRabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITransferService _transferService = null;
        public HomeController(ILogger<HomeController> logger , ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        } 

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel transferViewModel )
        {
            TransferDto transferDto = new TransferDto() {  
             FromAccount  = transferViewModel.FromAccount,
             ToAccount = transferViewModel.ToAccount,
             TransferAmount = transferViewModel.TransferAmount,
            };
            await _transferService.Tarnsfer(transferDto);
            return View("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
