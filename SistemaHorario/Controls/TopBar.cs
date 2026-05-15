using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Controls
{
    /// <summary>
    /// Representa la barra superior principal del sistema.
    /// </summary>
    /// <remarks>
    /// Muestra el título de la aplicación, la información del usuario
    /// y permite abrir el menú desplegable de opciones del usuario.
    /// </remarks>
    public partial class TopBar : UserControl
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorHover = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Evento que se ejecuta al hacer clic en la zona del usuario.
        /// </summary>
        public event EventHandler? MenuUsuarioClick;

        /// <summary>
        /// Inicializa una nueva instancia de la barra superior.
        /// </summary>
        public TopBar()
        {
            InitializeComponent();
            ConfigurarTopBar();
        }

        /// <summary>
        /// Configura los elementos visuales principales de la barra superior.
        /// </summary>
        private void ConfigurarTopBar()
        {
            BackColor = Color.White;
            Height = 75;

            lblTituloSistema.Text = "Sistema de gestión de horarios académicos";
            lblUsuarioMenu.Text = "Administrador";

            ConfigurarZonaUsuario();
        }

        /// <summary>
        /// Configura el comportamiento visual e interactivo de la zona del usuario.
        /// </summary>
        private void ConfigurarZonaUsuario()
        {
            pnlUsuarioMenu.BackColor = colorNormal;
            pnlUsuarioMenu.Cursor = Cursors.Hand;

            picUsuarioMenu.Cursor = Cursors.Hand;
            lblUsuarioMenu.Cursor = Cursors.Hand;
            picFlechaMenu.Cursor = Cursors.Hand;

            pnlUsuarioMenu.MouseEnter += (s, e) => AplicarHoverUsuario();
            picUsuarioMenu.MouseEnter += (s, e) => AplicarHoverUsuario();
            lblUsuarioMenu.MouseEnter += (s, e) => AplicarHoverUsuario();
            picFlechaMenu.MouseEnter += (s, e) => AplicarHoverUsuario();

            pnlUsuarioMenu.MouseLeave += (s, e) => QuitarHoverUsuario();
            picUsuarioMenu.MouseLeave += (s, e) => QuitarHoverUsuario();
            lblUsuarioMenu.MouseLeave += (s, e) => QuitarHoverUsuario();
            picFlechaMenu.MouseLeave += (s, e) => QuitarHoverUsuario();

            pnlUsuarioMenu.Click += AbrirMenuUsuario;
            picUsuarioMenu.Click += AbrirMenuUsuario;
            lblUsuarioMenu.Click += AbrirMenuUsuario;
            picFlechaMenu.Click += AbrirMenuUsuario;
        }

        /// <summary>
        /// Aplica el color de hover a la zona del usuario.
        /// </summary>
        private void AplicarHoverUsuario()
        {
            pnlUsuarioMenu.BackColor = colorHover;
        }

        /// <summary>
        /// Restaura el color normal cuando el cursor sale de la zona del usuario.
        /// </summary>
        private void QuitarHoverUsuario()
        {
            if (pnlUsuarioMenu.ClientRectangle.Contains(pnlUsuarioMenu.PointToClient(Cursor.Position)))
                return;

            pnlUsuarioMenu.BackColor = colorNormal;
        }

        /// <summary>
        /// Ejecuta el evento encargado de abrir el menú desplegable del usuario.
        /// </summary>
        private void AbrirMenuUsuario(object? sender, EventArgs e)
        {
            MenuUsuarioClick?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Configura el texto y la imagen del usuario mostrados en la barra superior.
        /// </summary>
        /// <param name="textoUsuario">Nombre o rol del usuario que se mostrará.</param>
        /// <param name="imagenUsuario">Imagen opcional del usuario.</param>
        public void ConfigurarUsuario(string textoUsuario, Image? imagenUsuario = null)
        {
            lblUsuarioMenu.Text = textoUsuario;

            if (imagenUsuario != null)
            {
                picUsuarioMenu.Image = imagenUsuario;
            }
        }
    }
}
