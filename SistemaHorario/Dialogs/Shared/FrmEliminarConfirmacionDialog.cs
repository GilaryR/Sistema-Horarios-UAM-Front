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
    /// Representa un cuadro de diálogo modal utilizado para confirmar la eliminación de un elemento.
    /// </summary>
    /// <remarks>
    /// Este formulario solicita una confirmación explícita antes de permitir una acción de eliminación.
    /// 
    /// Para habilitar el botón de eliminación, el usuario debe escribir la palabra
    /// "eliminar" en el campo de confirmación.
    /// 
    /// Devuelve <see cref="DialogResult.OK"/> cuando el usuario confirma la eliminación.
    /// Devuelve <see cref="DialogResult.Cancel"/> cuando el usuario cancela la operación.
    /// 
    /// También permite confirmar la acción con la tecla Enter y cancelar con la tecla Esc.
    /// </remarks>
    public partial class FrmEliminarConfirmacionDialog : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmEliminarConfirmacionDialog"/>.
        /// </summary>
        /// <param name="elemento">
        /// Nombre o descripción del elemento que se desea eliminar.
        /// Si se proporciona un valor, se incluye dentro del mensaje de confirmación.
        /// Si se omite o está vacío, se conserva el mensaje definido por defecto en el formulario.
        /// </param>
        /// <remarks>
        /// Durante la inicialización se configuran los eventos del campo de texto y de los botones
        /// del formulario.
        /// 
        /// El botón de confirmación permanece deshabilitado hasta que el usuario escriba
        /// correctamente la palabra "eliminar".
        /// 
        /// Se establece <see cref="Form.AcceptButton"/> para permitir confirmar con la tecla Enter
        /// y <see cref="Form.CancelButton"/> para permitir cancelar con la tecla Esc.
        /// </remarks>
        public FrmEliminarConfirmacionDialog(string elemento = "")
        {
            InitializeComponent();

            txtConfirmacion.TextChanged += txtConfirmacion_TextChanged;
            btnCancelar.Click += btnCancelar_Click;
            btnConfirmarEliminar.Click += btnConfirmarEliminar_Click;

            AcceptButton = btnConfirmarEliminar;
            CancelButton = btnCancelar;

            btnConfirmarEliminar.Text = "Eliminar";
            btnConfirmarEliminar.Enabled = false;

            if (!string.IsNullOrWhiteSpace(elemento))
            {
                lblMensaje.Text = $"¿Estás seguro que deseas eliminar {elemento}?\nDebes escribir la palabra eliminar.";
            }
        }

        /// <summary>
        /// Controla el evento <see cref="Control.TextChanged"/> del campo de confirmación.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/> si el evento
        /// es invocado manualmente.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Habilita el botón de confirmación únicamente cuando el texto ingresado por el usuario
        /// coincide con la palabra "eliminar".
        /// 
        /// La comparación ignora espacios al inicio o al final y no distingue entre mayúsculas
        /// y minúsculas.
        /// </remarks>
        private void txtConfirmacion_TextChanged(object? sender, EventArgs e)
        {
            btnConfirmarEliminar.Enabled =
                txtConfirmacion.Text.Trim().Equals("eliminar", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Controla el evento Click del botón Cancelar.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/> si el evento
        /// es invocado manualmente.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento Click.
        /// </param>
        /// <remarks>
        /// Establece el resultado del diálogo como <see cref="DialogResult.Cancel"/>
        /// y cierra el formulario cuando el usuario decide no continuar con la eliminación.
        /// </remarks>
        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Controla el evento Click del botón Confirmar eliminar.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/> si el evento
        /// es invocado manualmente.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento Click.
        /// </param>
        /// <remarks>
        /// Establece el resultado del diálogo como <see cref="DialogResult.OK"/>
        /// y cierra el formulario cuando el usuario confirma la eliminación del elemento.
        /// </remarks>
        private void btnConfirmarEliminar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}