using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MicroRabbit.MVC.Models;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {

        private readonly HttpClient _httpClient = null;
        public TransferService(HttpClient apiClient)
        {
            _httpClient = apiClient;
        }

        public async  Task Tarnsfer(TransferDto transferDto)
        {
            var uri = "http://localhost:5001/api/v1/Banking/TransferFund";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), System.Text.Encoding.UTF8, "application/json");
            var response  = await   _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
