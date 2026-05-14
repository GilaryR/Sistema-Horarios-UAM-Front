using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Controls
{
    public partial class TopBar : UserControl
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorHover = Color.FromArgb(245, 245, 245);

        public event EventHandler MenuUsuarioClick;

        public TopBar()
        {
            InitializeComponent();
            ConfigurarTopBar();
        }

        private void ConfigurarTopBar()
        {
            BackColor = Color.White;
            Height = 75;

            lblTituloSistema.Text = "Sistema de gestión de horarios académicos";
            lblUsuarioMenu.Text = "Administrador";

            ConfigurarZonaUsuario();
        }

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

        private void AplicarHoverUsuario()
        {
            pnlUsuarioMenu.BackColor = colorHover;
        }

        private void QuitarHoverUsuario()
        {
            if (pnlUsuarioMenu.ClientRectangle.Contains(pnlUsuarioMenu.PointToClient(Cursor.Position)))
                return;

            pnlUsuarioMenu.BackColor = colorNormal;
        }

        private void AbrirMenuUsuario(object sender, EventArgs e)
        {
            MenuUsuarioClick?.Invoke(this, EventArgs.Empty);
        }

        public void ConfigurarUsuario(string textoUsuario, Image imagenUsuario = null)
        {
            lblUsuarioMenu.Text = textoUsuario;

            if (imagenUsuario != null)
            {
                picUsuarioMenu.Image = imagenUsuario;
            }
        }
    }
}
