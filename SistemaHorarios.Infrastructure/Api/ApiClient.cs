using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SistemaHorarios.Application.Responses;

namespace SistemaHorarios.Infrastructure.Api
{
    public class ApiClient
    {
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions jsonOptions;

        public ApiClient()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(Config.BaseUrl)
            };

            jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string ruta)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(ruta);
                return await ProcesarRespuesta<T>(response);
            }
            catch (Exception ex)
            {
                return ApiResponse<T>.Error(0, $"No se pudo conectar con la API: {ex.Message}");
            }
        }

        public async Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string ruta, TRequest datos)
        {
            try
            {
                string json = JsonSerializer.Serialize(datos, jsonOptions);
                StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(ruta, contenido);
                return await ProcesarRespuesta<TResponse>(response);
            }
            catch (Exception ex)
            {
                return ApiResponse<TResponse>.Error(0, $"No se pudo conectar con la API: {ex.Message}");
            }
        }

        public async Task<ApiResponse<TResponse>> PutAsync<TRequest, TResponse>(string ruta, TRequest datos)
        {
            try
            {
                string json = JsonSerializer.Serialize(datos, jsonOptions);
                StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PutAsync(ruta, contenido);
                return await ProcesarRespuesta<TResponse>(response);
            }
            catch (Exception ex)
            {
                return ApiResponse<TResponse>.Error(0, $"No se pudo conectar con la API: {ex.Message}");
            }
        }

        public async Task<ApiResponse<bool>> DeleteAsync(string ruta)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(ruta);

                if (response.IsSuccessStatusCode)
                    return ApiResponse<bool>.Ok(true, (int)response.StatusCode);

                string mensajeError = await ObtenerMensajeError(response);
                return ApiResponse<bool>.Error((int)response.StatusCode, mensajeError);
            }
            catch (Exception ex)
            {
                return ApiResponse<bool>.Error(0, $"No se pudo conectar con la API: {ex.Message}");
            }
        }

        private async Task<ApiResponse<T>> ProcesarRespuesta<T>(HttpResponseMessage response)
        {
            string contenido = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                if (string.IsNullOrWhiteSpace(contenido))
                    return ApiResponse<T>.Ok(default, (int)response.StatusCode);

                T datos = JsonSerializer.Deserialize<T>(contenido, jsonOptions);
                return ApiResponse<T>.Ok(datos, (int)response.StatusCode);
            }

            string mensajeError = await ObtenerMensajeError(response);
            return ApiResponse<T>.Error((int)response.StatusCode, mensajeError);
        }

        private async Task<string> ObtenerMensajeError(HttpResponseMessage response)
        {
            string contenido = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrWhiteSpace(contenido))
                return contenido;

            return response.StatusCode switch
            {
                System.Net.HttpStatusCode.BadRequest => "Solicitud incorrecta.",
                System.Net.HttpStatusCode.Unauthorized => "No autorizado.",
                System.Net.HttpStatusCode.NotFound => "Recurso no encontrado.",
                System.Net.HttpStatusCode.InternalServerError => "Error interno del servidor.",
                _ => "Ocurrió un error al consumir la API."
            };
        }
    }
}
