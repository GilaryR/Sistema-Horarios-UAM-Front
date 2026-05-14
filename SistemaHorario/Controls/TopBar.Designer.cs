namespace SistemaHorario.UI.Controls
{
    partial class TopBar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloSistema = new Label();
            picUsuarioMenu = new PictureBox();
            lblUsuarioMenu = new Label();
            pnlUsuarioMenu = new Panel();
            picFlechaMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUsuarioMenu).BeginInit();
            pnlUsuarioMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlechaMenu).BeginInit();
            SuspendLayout();
            // 
            // lblTituloSistema
            // 
            lblTituloSistema.AutoSize = true;
            lblTituloSistema.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            lblTituloSistema.Location = new Point(31, 21);
            lblTituloSistema.Name = "lblTituloSistema";
            lblTituloSistema.Size = new Size(528, 30);
            lblTituloSistema.TabIndex = 0;
            lblTituloSistema.Text = "Sistema de gestión de horarios académicos";
            // 
            // picUsuarioMenu
            // 
            picUsuarioMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picUsuarioMenu.Image = Properties.Resources.IcUsuaCircul;
            picUsuarioMenu.Location = new Point(23, 3);
            picUsuarioMenu.Name = "picUsuarioMenu";
            picUsuarioMenu.Size = new Size(45, 45);
            picUsuarioMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuarioMenu.TabIndex = 1;
            picUsuarioMenu.TabStop = false;
            // 
            // lblUsuarioMenu
            // 
            lblUsuarioMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuarioMenu.AutoSize = true;
            lblUsuarioMenu.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioMenu.Location = new Point(74, 8);
            lblUsuarioMenu.Name = "lblUsuarioMenu";
            lblUsuarioMenu.Size = new Size(151, 28);
            lblUsuarioMenu.TabIndex = 2;
            lblUsuarioMenu.Text = "Administrador";
            // 
            // pnlUsuarioMenu
            // 
            pnlUsuarioMenu.Controls.Add(picFlechaMenu);
            pnlUsuarioMenu.Controls.Add(lblUsuarioMenu);
            pnlUsuarioMenu.Controls.Add(picUsuarioMenu);
            pnlUsuarioMenu.Location = new Point(1330, 14);
            pnlUsuarioMenu.Name = "pnlUsuarioMenu";
            pnlUsuarioMenu.Size = new Size(300, 58);
            pnlUsuarioMenu.TabIndex = 4;
            // 
            // picFlechaMenu
            // 
            picFlechaMenu.Image = Properties.Resources.flecha;
            picFlechaMenu.Location = new Point(242, 14);
            picFlechaMenu.Name = "picFlechaMenu";
            picFlechaMenu.Size = new Size(32, 22);
            picFlechaMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picFlechaMenu.TabIndex = 3;
            picFlechaMenu.TabStop = false;
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlUsuarioMenu);
            Controls.Add(lblTituloSistema);
            Name = "TopBar";
            Size = new Size(1633, 75);
            ((System.ComponentModel.ISupportInitialize)picUsuarioMenu).EndInit();
            pnlUsuarioMenu.ResumeLayout(false);
            pnlUsuarioMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlechaMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloSistema;
        private PictureBox picUsuarioMenu;
        private Label lblUsuarioMenu;
        private Panel pnlUsuarioMenu;
        private PictureBox picFlechaMenu;
    }
}
