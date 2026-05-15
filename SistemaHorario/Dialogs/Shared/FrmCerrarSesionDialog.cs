using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Dialogs.Shared
{
    /// <summary>
    /// Representa un cuadro de diálogo modal utilizado para confirmar el cierre de sesión del usuario.
    /// </summary>
    /// <remarks>
    /// Este formulario muestra una confirmación antes de finalizar la sesión actual.
    /// 
    /// Devuelve <see cref="DialogResult.OK"/> cuando el usuario confirma el cierre de sesión.
    /// Devuelve <see cref="DialogResult.Cancel"/> cuando el usuario cancela la operación.
    /// 
    /// También permite confirmar la acción con la tecla Enter y cancelarla con la tecla Esc.
    /// </remarks>
    public partial class FrmCerrarSesionDialog : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmCerrarSesionDialog"/>.
        /// </summary>
        /// <remarks>
        /// Durante la inicialización se configuran los eventos de los botones principales
        /// y se asignan los botones predeterminados para las teclas Enter y Esc.
        /// </remarks>
        public FrmCerrarSesionDialog()
        {
            InitializeComponent();

            btnCancelar.Click += btnCancelar_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;

            CancelButton = btnCancelar;
            AcceptButton = btnCerrarSesion;
        }

        /// <summary>
        /// Controla el evento Click del botón Cancelar.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Establece el resultado del diálogo como <see cref="DialogResult.Cancel"/>
        /// y cierra el formulario cuando el usuario decide no cerrar sesión.
        /// </remarks>
        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Controla el evento Click del botón Cerrar sesión.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Establece el resultado del diálogo como <see cref="DialogResult.OK"/>
        /// y cierra el formulario cuando el usuario confirma el cierre de sesión.
        /// </remarks>
        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
 