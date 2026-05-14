using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorarios.Infrastructure.Api
{
    public static class Config
    {
        public const string ApiHost = "https://localhost:7208";
        public const string ApiPrefix = "/api";

        public static string BaseUrl => $"{ApiHost}{ApiPrefix}/";
    }
}
