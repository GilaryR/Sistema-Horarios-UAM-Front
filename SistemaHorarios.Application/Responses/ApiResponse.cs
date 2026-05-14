using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorarios.Application.Responses
{
    public class ApiResponse<T>
    {
        public bool Exitoso { get; set; }
        public int CodigoEstado { get; set; }
        public string Mensaje { get; set; }
        public T Datos { get; set; }

        public static ApiResponse<T> Ok(T datos, int codigoEstado = 200)
        {
            return new ApiResponse<T>
            {
                Exitoso = true,
                CodigoEstado = codigoEstado,
                Mensaje = "Operación exitosa.",
                Datos = datos
            };
        }

        public static ApiResponse<T> Error(int codigoEstado, string mensaje)
        {
            return new ApiResponse<T>
            {
                Exitoso = false,
                CodigoEstado = codigoEstado,
                Mensaje = mensaje,
                Datos = default
            };
        }
    }
}