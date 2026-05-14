namespace SistemaHorario.UI.Controls
{
    partial class UserMenuDropdown
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
            picUsuarioMenu = new PictureBox();
            lblNombreUsuario = new Label();
            lblCorreoUsuario = new Label();
            pnlLinea1 = new Panel();
            pnlLinea2 = new Panel();
            btnMiPerfil = new Button();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)picUsuarioMenu).BeginInit();
            SuspendLayout();
            // 
            // picUsuarioMenu
            // 
            picUsuarioMenu.Image = Properties.Resources.IcUsuaCircul;
            picUsuarioMenu.Location = new Point(8, 21);
            picUsuarioMenu.Name = "picUsuarioMenu";
            picUsuarioMenu.Size = new Size(65, 65);
            picUsuarioMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuarioMenu.TabIndex = 0;
            picUsuarioMenu.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold);
            lblNombreUsuario.Location = new Point(79, 27);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(205, 38);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Administrador";
            // 
            // lblCorreoUsuario
            // 
            lblCorreoUsuario.AutoSize = true;
            lblCorreoUsuario.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoUsuario.ForeColor = Color.Gray;
            lblCorreoUsuario.Location = new Point(79, 65);
            lblCorreoUsuario.Name = "lblCorreoUsuario";
            lblCorreoUsuario.Size = new Size(242, 21);
            lblCorreoUsuario.TabIndex = 2;
            lblCorreoUsuario.Text = "administrador@autonoma.edu.co";
            // 
            // pnlLinea1
            // 
            pnlLinea1.BackColor = Color.FromArgb(230, 230, 230);
            pnlLinea1.Location = new Point(10, 100);
            pnlLinea1.Name = "pnlLinea1";
            pnlLinea1.Size = new Size(313, 1);
            pnlLinea1.TabIndex = 3;
            // 
            // pnlLinea2
            // 
            pnlLinea2.BackColor = Color.FromArgb(230, 230, 230);
            pnlLinea2.Location = new Point(10, 184);
            pnlLinea2.Name = "pnlLinea2";
            pnlLinea2.Size = new Size(313, 1);
            pnlLinea2.TabIndex = 4;
            // 
            // btnMiPerfil
            // 
            btnMiPerfil.FlatAppearance.BorderSize = 0;
            btnMiPerfil.FlatStyle = FlatStyle.Flat;
            btnMiPerfil.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMiPerfil.Image = Properties.Resources.icPerfilUs;
            btnMiPerfil.Location = new Point(-18, 107);
            btnMiPerfil.Name = "btnMiPerfil";
            btnMiPerfil.Size = new Size(367, 64);
            btnMiPerfil.TabIndex = 4;
            btnMiPerfil.Text = "Mi perfil";
            btnMiPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btnMiPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMiPerfil.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(166, 8, 8);
            btnCerrarSesion.Image = Properties.Resources.IcCerrarsesion;
            btnCerrarSesion.Location = new Point(-18, 191);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(386, 64);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // UserMenuDropdown
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnCerrarSesion);
            Controls.Add(pnlLinea2);
            Controls.Add(btnMiPerfil);
            Controls.Add(pnlLinea1);
            Controls.Add(lblCorreoUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(picUsuarioMenu);
            Name = "UserMenuDropdown";
            Size = new Size(337, 264);
            ((System.ComponentModel.ISupportInitialize)picUsuarioMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUsuarioMenu;
        private Label lblNombreUsuario;
        private Label lblCorreoUsuario;
        private Panel pnlLinea1;
        private Panel pnlLinea2;
        private Button btnMiPerfil;
        private Button btnCerrarSesion;
    }
}
