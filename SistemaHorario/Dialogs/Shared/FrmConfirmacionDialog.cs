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
    /// Representa un cuadro de diálogo modal reutilizable para solicitar confirmación al usuario.
    /// </summary>
    /// <remarks>
    /// Este formulario puede utilizarse para confirmar acciones generales del sistema,
    /// como crear, guardar, actualizar, continuar con una operación o ejecutar una acción
    /// que requiera aprobación previa del usuario.
    ///
    /// Devuelve <see cref="DialogResult.OK"/> cuando el usuario confirma la acción.
    /// Devuelve <see cref="DialogResult.Cancel"/> cuando el usuario cancela la operación.
    ///
    /// También permite confirmar con la tecla Enter y cancelar con la tecla Esc.
    /// </remarks>
    public partial class FrmConfirmacionDialog : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmConfirmacionDialog"/>
        /// usando los textos definidos por defecto en el diseñador del formulario.
        /// </summary>
        /// <remarks>
        /// Durante la inicialización se cargan los componentes visuales del formulario
        /// y se configuran los eventos de los botones principales.
        /// </remarks>
        public FrmConfirmacionDialog()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmConfirmacionDialog"/>
        /// con un título, mensaje y texto personalizado para el botón de confirmación.
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
        /// <remarks>
        /// Este constructor permite reutilizar el mismo formulario para distintos tipos
        /// de confirmaciones, modificando dinámicamente el título, el mensaje y el texto
        /// del botón principal.
        /// </remarks>
        public FrmConfirmacionDialog(string titulo, string mensaje, string textoConfirmar = "Confirmar")
        {
            InitializeComponent();
            ConfigurarEventos();

            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
            btnConfirmar.Text = textoConfirmar;
        }

        /// <summary>
        /// Configura los eventos y botones predeterminados del cuadro de diálogo.
        /// </summary>
        /// <remarks>
        /// Asocia los eventos Click de los botones Cancelar y Confirmar con sus respectivos
        /// métodos manejadores.
        ///
        /// También establece <see cref="Form.AcceptButton"/> para permitir confirmar con
        /// la tecla Enter y <see cref="Form.CancelButton"/> para permitir cancelar con
        /// la tecla Esc.
        /// </remarks>
        private void ConfigurarEventos()
        {
            btnCancelar.Click += btnCancelar_Click;
            btnConfirmar.Click += btnConfirmar_Click;

            AcceptButton = btnConfirmar;
            CancelButton = btnCancelar;
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
        /// y cierra el formulario cuando el usuario decide cancelar la operación.
        /// </remarks>
        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Controla el evento Click del botón Confirmar.
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
        /// y cierra el formulario cuando el usuario confirma la operación.
        /// </remarks>
        private void btnConfirmar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
