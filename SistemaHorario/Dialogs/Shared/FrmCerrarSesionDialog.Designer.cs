namespace SistemaHorario.UI.Dialogs.Shared
{
    partial class FrmCerrarSesionDialog
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
            picIcono = new PictureBox();
            lblCerrarSesion = new Label();
            lblMensaje = new Label();
            btnCancelar = new Button();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            SuspendLayout();
            // 
            // picIcono
            // 
            picIcono.Image = Properties.Resources.IcAdvertencia;
            picIcono.Location = new Point(163, 12);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(135, 69);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 0;
            picIcono.TabStop = false;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCerrarSesion.Location = new Point(130, 84);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(219, 37);
            lblCerrarSesion.TabIndex = 1;
            lblCerrarSesion.Text = "Cerrar sesión";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.Location = new Point(36, 130);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(398, 75);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "¿Estás seguro que deseas cerrar tu sesión actual?\r\nDeberás iniciar sesión nuevamente para acceder \r\n                              al sistema.";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Gray;
            btnCancelar.Location = new Point(36, 223);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(171, 42);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(166, 8, 8);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = Properties.Resources.IcCerrar;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(258, 223);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 42);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.TopCenter;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // FrmCerrarSesionDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 303);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnCancelar);
            Controls.Add(lblMensaje);
            Controls.Add(lblCerrarSesion);
            Controls.Add(picIcono);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCerrarSesionDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCerrarSesionDialog";
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picIcono;
        private Label lblCerrarSesion;
        private Label lblMensaje;
        private Button btnCancelar;
        private Button btnCerrarSesion;


    }
}