using SistemaHorarios.Application.Requests.Auth;
using SistemaHorarios.Application.Responses;
using SistemaHorarios.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorarios.Application.Interfaces
{
    public interface ISistemaHorariosApiService
    {
        Task<ApiResponse<object>> ProbarConexionAsync();
    }
}
