using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaHorario.UI.Controls
{
    public partial class Sidebar : UserControl
    {
        private readonly Color colorNormal = Color.FromArgb(76, 94, 113);
        private readonly Color colorHover = Color.FromArgb(0, 106, 166);
        private readonly Color colorActivo = Color.FromArgb(0, 106, 166);

        private Panel panelActivo;
        private Panel[] itemsMenu;

        public event EventHandler InicioClick;
        public event EventHandler PlanAcademicoClick;
        public event EventHandler MateriasClick;
        public event EventHandler DocentesClick;
        public event EventHandler GruposAcademicosClick;
        public event EventHandler CoordinadoresClick;
        public event EventHandler HorariosClick;
        public event EventHandler ReportesClick;
        public event EventHandler HistorialCambiosClick;
        public event EventHandler ManualClick;

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

        private void ConfigurarItemMenu(Panel panel, Action accionClick)
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

        private void AplicarHover(Panel panel)
        {
            if (panelActivo == panel)
                return;

            panel.BackColor = colorHover;
        }

        private void QuitarHover(Panel panel)
        {
            if (panelActivo == panel)
                return;

            if (panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                return;

            panel.BackColor = colorNormal;
        }

        private void SeleccionarItem(Panel panelSeleccionado, Action accionClick)
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
