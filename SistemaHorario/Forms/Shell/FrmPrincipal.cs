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

    /// <summary>
    /// Representa el formulario principal del sistema de horarios.
    /// </summary>
    /// <remarks>
    /// Este formulario funciona como contenedor principal de la aplicación.
    /// 
    /// Se encarga de configurar la ventana principal, administrar los eventos de la barra superior,
    /// controlar la navegación del menú lateral y cargar dinámicamente las pantallas internas
    /// dentro del panel de contenido.
    /// 
    /// También gestiona acciones relacionadas con el usuario, como acceder al perfil
    /// y cerrar sesión.
    /// </remarks>
    public partial class FrmPrincipal : Form
    {

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmPrincipal"/>.
        /// </summary>
        /// <remarks>
        /// Durante la inicialización se configuran la ventana principal, los eventos de la barra superior,
        /// los eventos del menú lateral y se carga la pantalla de inicio.
        /// </remarks>
        public FrmPrincipal()
        {
            InitializeComponent();

            ConfigurarVentana();
            ConfigurarEventosTopBar();
            ConfigurarEventosSidebar();

            CargarInicio();
        }

        /// <summary>
        /// Configura las propiedades iniciales de la ventana principal y del menú desplegable de usuario.
        /// </summary>
        /// <remarks>
        /// Maximiza la ventana principal, oculta inicialmente el menú desplegable del usuario,
        /// establece su tamaño, color de fondo y lo posiciona al frente de los controles visuales.
        /// </remarks>
        private void ConfigurarVentana()
        {
            WindowState = FormWindowState.Maximized;
            userMenuDropdown.Visible = false;
            userMenuDropdown.Size = new Size(370, 285);
            userMenuDropdown.BackColor = Color.White;
            userMenuDropdown.BringToFront();
        }

        /// <summary>
        /// Configura los eventos relacionados con la barra superior del formulario.
        /// </summary>
        /// <remarks>
        /// Asocia los eventos del menú de usuario con sus respectivos métodos manejadores.
        /// 
        /// Estos eventos permiten mostrar u ocultar el menú desplegable del usuario,
        /// acceder a la pantalla de perfil y ejecutar el proceso de cierre de sesión.
        /// </remarks>
        private void ConfigurarEventosTopBar()
        {
            topBar.MenuUsuarioClick += TopBar_MenuUsuarioClick;
            userMenuDropdown.MiPerfilClick += UserMenuDropdown_MiPerfilClick;
            userMenuDropdown.CerrarSesionClick += UserMenuDropdown_CerrarSesionClick;
        }

        /// <summary>
        /// Configura los eventos de navegación del menú lateral.
        /// </summary>
        /// <remarks>
        /// Asocia cada opción del menú lateral con la pantalla correspondiente del sistema.
        /// 
        /// Cada opción carga un control de usuario dentro del panel principal de contenido.
        /// También oculta el menú desplegable del usuario cuando se realiza una navegación.
        /// </remarks>

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

        /// <summary>
        /// Carga la pantalla inicial del sistema.
        /// </summary>
        /// <remarks>
        /// Utiliza el método <see cref="CargarPantalla(UserControl)"/> para mostrar
        /// el control de inicio dentro del panel principal de contenido.
        /// </remarks>
        private void CargarInicio()
        {
            CargarPantalla(new UcInicio());
        }

        /// <summary>
        /// Carga un control de usuario dentro del panel principal de contenido.
        /// </summary>
        /// <param name="control">
        /// Control de usuario que se mostrará en el panel de contenido principal.
        /// </param>
        /// <remarks>
        /// Antes de cargar la nueva pantalla, oculta el menú desplegable del usuario.
        /// 
        /// La carga del control se delega al helper de navegación del sistema.
        /// </remarks>
        private void CargarPantalla(UserControl control)
        {
            userMenuDropdown.Visible = false;
            NavegacionHelper.CargarControl(pnlContenido, control);
        }

        /// <summary>
        /// Controla el evento de clic del menú de usuario ubicado en la barra superior.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Muestra u oculta el menú desplegable del usuario.
        /// 
        /// Si el menú desplegable no pertenece directamente al formulario principal,
        /// se remueve de su contenedor actual y se agrega al formulario.
        /// 
        /// También recalcula su tamaño, color de fondo y posición para mostrarlo
        /// alineado hacia la parte superior derecha de la ventana.
        /// </remarks>
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

        /// <summary>
        /// Controla el evento de clic de la opción Mi perfil del menú desplegable de usuario.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Carga la pantalla de perfil del usuario dentro del panel principal de contenido.
        /// </remarks>
        private void UserMenuDropdown_MiPerfilClick(object sender, EventArgs e)
        {
            CargarPantalla(new UcPerfil());
        }

        /// <summary>
        /// Controla el evento de clic de la opción Cerrar sesión del menú desplegable de usuario.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento.
        /// </param>
        /// <remarks>
        /// Oculta el menú desplegable del usuario y solicita confirmación antes de cerrar la sesión.
        /// 
        /// Si el usuario cancela la operación, no se realiza ningún cambio.
        /// 
        /// Si el usuario confirma el cierre de sesión, se oculta el formulario principal,
        /// se muestra nuevamente el formulario de inicio de sesión y se cierra la instancia actual
        /// del formulario principal.
        /// </remarks>
        private void UserMenuDropdown_CerrarSesionClick(object sender, EventArgs e)
        {
            userMenuDropdown.Visible = false;

            bool confirmar = MensajesHelper.ConfirmarCerrarSesion();

            if (!confirmar)
                return;

            this.Hide();

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }
    }
}
