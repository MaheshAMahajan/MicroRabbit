using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Api.Infra
{
    public class ApiRoute
    {
        public const string Root = "api";
        public const string Versoin = "v1";
        public const string Base = Root + "/" + Versoin;
        public class TransferApi
        {
            public const string Get = Base + "/Transfer/Get";
            public const string TransferLog = Base + "/Transfer/TransferLog";
        }
    }
}
