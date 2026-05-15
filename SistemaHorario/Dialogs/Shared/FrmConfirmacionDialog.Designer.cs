namespace SistemaHorario.UI.Dialogs.Shared
{
    partial class FrmConfirmacionDialog
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
            lblTitulo = new Label();
            lblMensaje = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            SuspendLayout();
            // 
            // picIcono
            // 
            picIcono.Image = Properties.Resources.IcAdvertencia;
            picIcono.Location = new Point(158, 12);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(88, 61);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 0;
            picIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(99, 86);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear Docente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.Location = new Point(41, 135);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(352, 25);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "¿Estás seguro que deseas crear al docente?";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(166, 8, 8);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(41, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 37);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(104, 159, 6);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(249, 196);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(119, 37);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FrmConfirmacionDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 260);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Controls.Add(picIcono);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfirmacionDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfirmacionDialog";
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picIcono;
        private Label lblTitulo;
        private Label lblMensaje;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}