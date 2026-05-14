using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Controls
{
    public partial class UserMenuDropdown : UserControl
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorHover = Color.FromArgb(226, 243, 253);
        private readonly Color colorClick = Color.FromArgb(226, 243, 253);

        public event EventHandler MiPerfilClick;
        public event EventHandler CerrarSesionClick;

        public UserMenuDropdown()
        {
            InitializeComponent();

            ConfigurarBotonMenu(btnMiPerfil);
            ConfigurarBotonMenu(btnCerrarSesion);

            btnMiPerfil.Click += (s, e) => MiPerfilClick?.Invoke(this, EventArgs.Empty);
            btnCerrarSesion.Click += (s, e) => CerrarSesionClick?.Invoke(this, EventArgs.Empty);

            Visible = false;
        }

        private void ConfigurarBotonMenu(Button boton)
        {
            boton.BackColor = colorNormal;
            boton.Cursor = Cursors.Hand;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = colorHover;
            boton.FlatAppearance.MouseDownBackColor = colorClick;
        }
    }}