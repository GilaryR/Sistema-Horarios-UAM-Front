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
    /// Representa el menú lateral principal del sistema.
    /// </summary>
    /// <remarks>
    /// Permite navegar entre los diferentes módulos de la aplicación,
    /// gestionar el estado visual del elemento seleccionado y emitir eventos
    /// cuando el usuario selecciona una opción del menú.
    /// </remarks>
    public partial class Sidebar : UserControl
    {
        private readonly Color colorNormal = Color.FromArgb(76, 94, 113);
        private readonly Color colorHover = Color.FromArgb(0, 106, 166);
        private readonly Color colorActivo = Color.FromArgb(0, 106, 166);


        /// <summary>
        /// Panel actualmente seleccionado dentro del menú lateral.
        /// </summary>
        private Panel? panelActivo;

        /// <summary>
        /// Conjunto de paneles que representan las opciones del menú.
        /// </summary>
        private Panel[] itemsMenu;

        /// <summary>Evento que se ejecuta al seleccionar Inicio.</summary>
        public event EventHandler? InicioClick;

        /// <summary>Evento que se ejecuta al seleccionar Plan Académico.</summary>
        public event EventHandler? PlanAcademicoClick;

        /// <summary>Evento que se ejecuta al seleccionar Materias.</summary>
        public event EventHandler? MateriasClick;

        /// <summary>Evento que se ejecuta al seleccionar Docentes.</summary>
        public event EventHandler? DocentesClick;

        /// <summary>Evento que se ejecuta al seleccionar Grupos Académicos.</summary>
        public event EventHandler? GruposAcademicosClick;

        /// <summary>Evento que se ejecuta al seleccionar Coordinadores.</summary>
        public event EventHandler? CoordinadoresClick;

        /// <summary>Evento que se ejecuta al seleccionar Horarios.</summary>
        public event EventHandler? HorariosClick;

        /// <summary>Evento que se ejecuta al seleccionar Reportes.</summary>
        public event EventHandler? ReportesClick;

        /// <summary>Evento que se ejecuta al seleccionar Historial de Cambios.</sumary>
        public event EventHandler? HistorialCambiosClick;

        /// <summary>Evento que se ejecuta al seleccionar Manual.</summary>
        public event EventHandler? ManualClick;

        /// <summary>
        /// Inicializa una nueva instancia del menú lateral.
        /// </summary>
        /// <remarks>
        /// Configura las opciones del menú, sus eventos y deja seleccionada
        /// la opción Inicio por defecto.
        /// </remarks>
        public Sidebar()
        {
            InitializeComponent();

            itemsMenu = new Panel[]
            {
                pnlInicio,
                pnlPlanAcademico,
                pnlMaterias,
                pnlDocentes,
                pnlGruposAcademicos,
                pnlCoordinadores,
                pnlHorarios,
                pnlReportes,
                pnlHistorialCambios,
                pnlManual
            };

            ConfigurarItemMenu(pnlInicio, () => InicioClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlPlanAcademico, () => PlanAcademicoClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlMaterias, () => MateriasClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlDocentes, () => DocentesClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlGruposAcademicos, () => GruposAcademicosClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlCoordinadores, () => CoordinadoresClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlHorarios, () => HorariosClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlReportes, () => ReportesClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlHistorialCambios, () => HistorialCambiosClick?.Invoke(this, EventArgs.Empty));
            ConfigurarItemMenu(pnlManual, () => ManualClick?.Invoke(this, EventArgs.Empty));

            SeleccionarItem(pnlInicio, null);
        }

        /// <summary>
        /// Configura el comportamiento visual y funcional de un elemento del menú.
        /// </summary>
        /// <param name="panel">Panel visual asociado a la opción del menú.</param>
        /// <param name="accionClick">Acción ejecutada al seleccionar la opción.</param>
        private void ConfigurarItemMenu(Panel panel, Action? accionClick)
        {
            panel.BackColor = colorNormal;
            panel.Cursor = Cursors.Hand;

            panel.MouseEnter += (s, e) => AplicarHover(panel);
            panel.MouseLeave += (s, e) => QuitarHover(panel);
            panel.Click += (s, e) => SeleccionarItem(panel, accionClick);

            foreach (Control control in panel.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.MouseEnter += (s, e) => AplicarHover(panel);
                control.MouseLeave += (s, e) => QuitarHover(panel);
                control.Click += (s, e) => SeleccionarItem(panel, accionClick);
            }
        }

        /// <summary>
        /// Aplica el color de hover cuando el cursor pasa sobre una opción.
        /// </summary>
        private void AplicarHover(Panel panel)
        {
            if (panelActivo == panel)
                return;

            panel.BackColor = colorHover;
        }

        /// <summary>
        /// Restaura el color normal cuando el cursor sale de una opción.
        /// </summary>
        private void QuitarHover(Panel panel)
        {
            if (panelActivo == panel)
                return;

            if (panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                return;

            panel.BackColor = colorNormal;
        }

        /// <summary>
        /// Marca visualmente una opción como seleccionada y ejecuta su acción asociada.
        /// </summary>
        /// <param name="panelSeleccionado">Panel que será marcado como activo.</param>
        /// <param name="accionClick">Acción asociada a la opción seleccionada.</param>
        private void SeleccionarItem(Panel panelSeleccionado, Action? accionClick)
        {
            foreach (Panel panel in itemsMenu)
            {
                panel.BackColor = colorNormal;
            }

            panelActivo = panelSeleccionado;
            panelActivo.BackColor = colorActivo;

            accionClick?.Invoke();
        }
    }
}
