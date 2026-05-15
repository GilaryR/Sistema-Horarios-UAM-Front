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
    /// Representa el menú desplegable del usuario.
    /// </summary>
    /// <remarks>
    /// Permite acceder a opciones relacionadas con la cuenta,
    /// como visualizar el perfil o cerrar sesión.
    /// </remarks>
    public partial class UserMenuDropdown : UserControl
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorHover = Color.FromArgb(226, 243, 253);
        private readonly Color colorClick = Color.FromArgb(226, 243, 253);

        /// <summary>
        /// Evento que se ejecuta al seleccionar la opción Mi perfil.
        /// </summary>
        public event EventHandler? MiPerfilClick;

        /// <summary>
        /// Evento que se ejecuta al seleccionar la opción Cerrar sesión.
        /// </summary>
        public event EventHandler? CerrarSesionClick;


        /// <summary>
        /// Inicializa una nueva instancia del menú desplegable del usuario.
        /// </summary>
        public UserMenuDropdown()
        {
            InitializeComponent();

            ConfigurarBotonMenu(btnMiPerfil);
            ConfigurarBotonMenu(btnCerrarSesion);

            btnMiPerfil.Click += (s, e) => MiPerfilClick?.Invoke(this, EventArgs.Empty);
            btnCerrarSesion.Click += (s, e) => CerrarSesionClick?.Invoke(this, EventArgs.Empty);

            Visible = false;
        }

        /// <summary>
        /// Configura el estilo visual y comportamiento interactivo de un botón del menú.
        /// </summary>
        /// <param name="boton">Botón que será configurado.</param>
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