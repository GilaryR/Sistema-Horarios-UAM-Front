namespace SistemaHorario.UI.Dialogs.Shared
{
    partial class FrmEliminarConfirmacionDialog
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
            picIcon = new PictureBox();
            lblTitulo = new Label();
            lblMensaje = new Label();
            txtConfirmacion = new TextBox();
            btnCancelar = new Button();
            btnConfirmarEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // picIcon
            // 
            picIcon.Image = Properties.Resources.IcAdvertenciaR;
            picIcon.Location = new Point(168, 12);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(88, 61);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Modern No. 20", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(128, 76);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Eliminar";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.Location = new Point(69, 117);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(289, 50);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "¿Estás seguro que deseas eliminar?\r\n Debes escribir la palabra eliminar.";
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Location = new Point(128, 180);
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.PlaceholderText = "Escribir";
            txtConfirmacion.Size = new Size(179, 31);
            txtConfirmacion.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Gray;
            btnCancelar.Location = new Point(42, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEliminar
            // 
            btnConfirmarEliminar.BackColor = Color.FromArgb(0, 106, 166);
            btnConfirmarEliminar.FlatStyle = FlatStyle.Flat;
            btnConfirmarEliminar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarEliminar.ForeColor = Color.White;
            btnConfirmarEliminar.Location = new Point(246, 228);
            btnConfirmarEliminar.Name = "btnConfirmarEliminar";
            btnConfirmarEliminar.Size = new Size(112, 34);
            btnConfirmarEliminar.TabIndex = 5;
            btnConfirmarEliminar.Text = "Guardar";
            btnConfirmarEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmEliminarConfirmacionDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 280);
            Controls.Add(btnConfirmarEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(txtConfirmacion);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Controls.Add(picIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEliminarConfirmacionDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEliminarConfirmacionDialog";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picIcon;
        private Label lblTitulo;
        private Label lblMensaje;
        private TextBox txtConfirmacion;
        private Button btnCancelar;
        private Button btnConfirmarEliminar;
    }
}