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
    /// Representa un cuadro de diálogo modal utilizado para mostrar un mensaje de operación exitosa.
    /// </summary>
    /// <remarks>
    /// Este formulario se utiliza para informar al usuario que una acción se completó correctamente,
    /// por ejemplo, guardar, actualizar o registrar información.
    /// 
    /// El mensaje mostrado puede personalizarse mediante el constructor.
    /// 
    /// Devuelve <see cref="DialogResult.OK"/> cuando el usuario cierra el diálogo
    /// mediante el botón Salir o la tecla Enter.
    /// </remarks>
    public partial class FrmMensajeExitoDialog : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmMensajeExitoDialog"/>.
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje que se mostrará al usuario dentro del cuadro de diálogo.
        /// Si no se proporciona un valor, se mostrará el mensaje predeterminado:
        /// "Se ha guardado exitosamente".
        /// </param>
        /// <remarks>
        /// Durante la inicialización se asigna el texto recibido al control de mensaje,
        /// se conecta el evento Click del botón Salir y se configura dicho botón como
        /// botón de aceptación del formulario.
        /// 
        /// Al establecer <see cref="Form.AcceptButton"/>, el usuario puede cerrar el diálogo
        /// presionando la tecla Enter.
        /// </remarks>
        public FrmMensajeExitoDialog(string mensaje = "Se ha guardado exitosamente")
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
            btnSalir.Click += btnSalir_Click;
            AcceptButton = btnSalir;
        }
        /// <summary>
        /// Controla el evento Click del botón Salir.
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
        /// y cierra el formulario.
        /// </remarks>
        private void btnSalir_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
