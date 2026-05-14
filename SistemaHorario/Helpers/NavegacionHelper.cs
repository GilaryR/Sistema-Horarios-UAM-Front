using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHorario.UI.Helpers
{
    internal class NavegacionHelper
    {
        public static void CargarControl(Panel panel, UserControl control)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
        }
    }
}
