using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaHorarios.Application.Requests.Auth
{
    public class LoginRequest
    {
        [JsonPropertyName("correoInstitucional")]
        public string CorreoInstitucional { get; set; }

        [JsonPropertyName("contrasena")]
        public string Contrasena { get; set; }
    }
}
