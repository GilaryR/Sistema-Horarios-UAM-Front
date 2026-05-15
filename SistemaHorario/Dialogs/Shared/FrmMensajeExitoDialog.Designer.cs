namespace SistemaHorario.UI.Dialogs.Shared
{
    partial class FrmMensajeExitoDialog
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
            lblMensaje = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            SuspendLayout();
            // 
            // picIcono
            // 
            picIcono.Image = Properties.Resources.IcCorrecto;
            picIcono.Location = new Point(136, 12);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(160, 87);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 0;
            picIcono.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(68, 137);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(298, 28);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Se ha guardado exitosamente";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Gray;
            btnSalir.Location = new Point(136, 201);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 32);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMensajeExitoDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 260);
            Controls.Add(btnSalir);
            Controls.Add(lblMensaje);
            Controls.Add(picIcono);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMensajeExitoDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMensajeExitoDialog";
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picIcono;
        private Label lblMensaje;
        private Button btnSalir;
    }
}