using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api.Infra
{
    public   class ApiRoutes
    {

        public const string Root = "api";
        public const string Versoin = "v1";
        public const string Base = Root + "/" + Versoin;
        public class BankingApi
        {
            public const string GetAccounts = Base +   "/Banking/GetAccounts" ;
        }
    }
}
