namespace SistemaHorario.UI.Forms.Shell
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            sidebar = new SistemaHorario.UI.Controls.Sidebar();
            pnlTopBar = new Panel();
            topBar = new SistemaHorario.UI.Controls.TopBar();
            pnlContenido = new Panel();
            userMenuDropdown = new SistemaHorario.UI.Controls.UserMenuDropdown();
            pnlSidebar.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(76, 94, 113);
            pnlSidebar.Controls.Add(sidebar);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(276, 644);
            pnlSidebar.TabIndex = 0;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(76, 94, 113);
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(276, 644);
            sidebar.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(topBar);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(276, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(802, 75);
            pnlTopBar.TabIndex = 1;
            // 
            // topBar
            // 
            topBar.BackColor = Color.White;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1678, 75);
            topBar.TabIndex = 0;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.Silver;
            pnlContenido.Controls.Add(userMenuDropdown);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(276, 75);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(802, 569);
            pnlContenido.TabIndex = 2;
            // 
            // userMenuDropdown
            // 
            userMenuDropdown.BackColor = Color.White;
            userMenuDropdown.BorderStyle = BorderStyle.FixedSingle;
            userMenuDropdown.Location = new Point(1300, 3);
            userMenuDropdown.Name = "userMenuDropdown";
            userMenuDropdown.Size = new Size(337, 264);
            userMenuDropdown.TabIndex = 0;
            userMenuDropdown.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 238);
            ClientSize = new Size(1078, 644);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1100, 700);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de gestión de horarios académicos";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlTopBar;
        private Panel pnlContenido;
        private Controls.Sidebar sidebar;
        private Controls.TopBar topBar;
        private Controls.UserMenuDropdown userMenuDropdown;
    }
}