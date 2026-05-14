using SistemaHorario.UI.Helpers;
using SistemaHorario.UI.UserControls.Coordinadores;
using SistemaHorario.UI.UserControls.Docentes;
using SistemaHorario.UI.UserControls.GruposAcademicos;
using SistemaHorario.UI.UserControls.HistorialCambios;
using SistemaHorario.UI.UserControls.Horarios;
using SistemaHorario.UI.UserControls.Inicio;
using SistemaHorario.UI.UserControls.Materias;
using SistemaHorario.UI.UserControls.Perfil;
using SistemaHorario.UI.UserControls.PlanAcademico;
using SistemaHorario.UI.UserControls.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Forms.Shell
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            ConfigurarVentana();
            ConfigurarEventosTopBar();
            ConfigurarEventosSidebar();

            CargarInicio();
        }

        private void ConfigurarVentana()
        {
            WindowState = FormWindowState.Maximized;
            userMenuDropdown.Visible = false;
            userMenuDropdown.Size = new Size(370, 285);
            userMenuDropdown.BackColor = Color.White;
            userMenuDropdown.BringToFront();
        }

        private void ConfigurarEventosTopBar()
        {
            topBar.MenuUsuarioClick += TopBar_MenuUsuarioClick;
            userMenuDropdown.MiPerfilClick += UserMenuDropdown_MiPerfilClick;
            userMenuDropdown.CerrarSesionClick += UserMenuDropdown_CerrarSesionClick;
        }

        private void ConfigurarEventosSidebar()
        {
            sidebar.InicioClick += (s, e) => CargarInicio();

            sidebar.PlanAcademicoClick += (s, e) =>
                CargarPantalla(new UcPlanAcademico());

            sidebar.MateriasClick += (s, e) =>
                CargarPantalla(new UcMaterias());

            sidebar.DocentesClick += (s, e) =>
                CargarPantalla(new UcDocentes());

            sidebar.GruposAcademicosClick += (s, e) =>
                CargarPantalla(new UcGruposAcademicos());

            sidebar.CoordinadoresClick += (s, e) =>
                CargarPantalla(new UcCoordinadores());

            sidebar.HorariosClick += (s, e) =>
                CargarPantalla(new UcHorarios());

            sidebar.ReportesClick += (s, e) =>
                CargarPantalla(new UcReportes());

            sidebar.HistorialCambiosClick += (s, e) =>
                CargarPantalla(new UcHistorialCambios());

            sidebar.ManualClick += (s, e) =>
            {
                userMenuDropdown.Visible = false;
                MessageBox.Show("Manual pendiente de agregar.");
            };
        }

        private void CargarInicio()
        {
            CargarPantalla(new UcInicio());
        }

        private void CargarPantalla(UserControl control)
        {
            userMenuDropdown.Visible = false;
            NavegacionHelper.CargarControl(pnlContenido, control);
        }

        private void TopBar_MenuUsuarioClick(object sender, EventArgs e)
        {
            if (userMenuDropdown.Parent != this)
            {
                userMenuDropdown.Parent?.Controls.Remove(userMenuDropdown);
                this.Controls.Add(userMenuDropdown);
            }

            userMenuDropdown.Size = new Size(370, 285);
            userMenuDropdown.BackColor = Color.White;

            userMenuDropdown.Location = new Point(
                this.ClientSize.Width - userMenuDropdown.Width - 35,
                pnlTopBar.Bottom - 5
            );

            userMenuDropdown.Visible = !userMenuDropdown.Visible;
            userMenuDropdown.BringToFront();
        }


        private void UserMenuDropdown_MiPerfilClick(object sender, EventArgs e)
        {
            CargarPantalla(new UcPerfil());
        }

        private void UserMenuDropdown_CerrarSesionClick(object sender, EventArgs e)
        {
            userMenuDropdown.Visible = false;
            MessageBox.Show("Cerrar sesión pendiente de conectar.");
        }
    }
}
