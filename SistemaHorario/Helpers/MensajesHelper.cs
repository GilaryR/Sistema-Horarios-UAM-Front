using SistemaHorario.UI.Dialogs.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Helpers
{
    /// <summary>
    /// Proporciona métodos auxiliares para mostrar cuadros de diálogo personalizados del sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase centraliza la apertura de mensajes y confirmaciones reutilizables,
    /// evitando repetir la creación manual de formularios de diálogo en distintas partes
    /// de la aplicación.
    ///
    /// Los métodos de confirmación devuelven un valor booleano para indicar si el usuario
    /// aceptó o canceló la acción solicitada.
    /// </remarks>
    public static class MensajesHelper
    {
        /// <summary>
        /// Muestra un cuadro de diálogo de éxito con el mensaje especificado.
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje que se mostrará al usuario dentro del cuadro de diálogo.
        /// </param>
        /// <remarks>
        /// Este método utiliza <see cref="FrmMensajeExitoDialog"/> para informar al usuario
        /// que una operación se completó correctamente.
        ///
        /// El formulario se abre de forma modal mediante <see cref="Form.ShowDialog()"/>,
        /// por lo que la ejecución se detiene hasta que el usuario cierre el mensaje.
        ///
        /// La instrucción <see langword="using"/> garantiza que los recursos del formulario
        /// sean liberados correctamente después de cerrarlo.
        /// </remarks>
        public static void MostrarExito(string mensaje)
        {
            using FrmMensajeExitoDialog frm = new FrmMensajeExitoDialog(mensaje);
            frm.ShowDialog();
        }

        /// <summary>
        /// Muestra un cuadro de diálogo de confirmación general.
        /// </summary>
        /// <param name="titulo">
        /// Título que se mostrará en el cuadro de diálogo.
        /// </param>
        /// <param name="mensaje">
        /// Mensaje principal que se mostrará al usuario.
        /// </param>
        /// <param name="textoConfirmar">
        /// Texto que se mostrará en el botón de confirmación.
        /// Si no se proporciona un valor, se usará "Confirmar".
        /// </param>
        /// <returns>
        /// <see langword="true"/> si el usuario confirma la acción;
        /// de lo contrario, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Este método utiliza <see cref="FrmConfirmacionDialog"/> para confirmar acciones
        /// generales del sistema, como guardar, crear, actualizar o continuar con una operación.
        ///
        /// Se considera que el usuario confirmó la acción cuando el formulario devuelve
        /// <see cref="DialogResult.OK"/>.
        /// </remarks>
        public static bool Confirmar(string titulo, string mensaje, string textoConfirmar = "Confirmar")
        {
            using FrmConfirmacionDialog frm = new FrmConfirmacionDialog(titulo, mensaje, textoConfirmar);
            return frm.ShowDialog() == DialogResult.OK;
        }

        /// <summary>
        /// Muestra un cuadro de diálogo para confirmar la eliminación de un elemento.
        /// </summary>
        /// <param name="elemento">
        /// Nombre o descripción del elemento que se desea eliminar.
        /// Si no se proporciona un valor, se mostrará el mensaje predeterminado
        /// definido en el formulario de eliminación.
        /// </param>
        /// <returns>
        /// <see langword="true"/> si el usuario confirma la eliminación;
        /// de lo contrario, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Este método utiliza <see cref="FrmEliminarConfirmacionDialog"/> para solicitar
        /// una confirmación explícita antes de ejecutar una acción destructiva.
        ///
        /// Se considera que la eliminación fue confirmada cuando el formulario devuelve
        /// <see cref="DialogResult.OK"/>.
        /// </remarks>
        public static bool ConfirmarEliminacion(string elemento = "")
        {
            using FrmEliminarConfirmacionDialog frm = new FrmEliminarConfirmacionDialog(elemento);
            return frm.ShowDialog() == DialogResult.OK;
        }

        /// <summary>
        /// Muestra un cuadro de diálogo para confirmar el cierre de sesión del usuario.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> si el usuario confirma el cierre de sesión;
        /// de lo contrario, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Este método utiliza <see cref="FrmCerrarSesionDialog"/> para solicitar confirmación
        /// antes de finalizar la sesión actual.
        ///
        /// Se considera que el usuario confirmó el cierre de sesión cuando el formulario devuelve
        /// <see cref="DialogResult.OK"/>.
        /// </remarks>
        public static bool ConfirmarCerrarSesion()
        {
            using FrmCerrarSesionDialog frm = new FrmCerrarSesionDialog();
            return frm.ShowDialog() == DialogResult.OK;
        }
    }
}
