using SistemaHorarios.Application.Interfaces;
using SistemaHorarios.Application.Requests.Auth;
using SistemaHorarios.Application.Responses;
using SistemaHorarios.Application.ViewModels;
using SistemaHorarios.Infrastructure.DTOs.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorarios.Infrastructure.Api
{
    public class SistemaHorariosApiService : ISistemaHorariosApiService
    {
        private readonly ApiClient apiClient;

        public SistemaHorariosApiService()
        {
            apiClient = new ApiClient();
        }

        public Task<ApiResponse<object>> ProbarConexionAsync()
        {
            return apiClient.GetAsync<object>(ApiRoutes.Catalogos.Jornadas);
        }
    }
}
