namespace SistemaHorario
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloLogin = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            pnlLoginCard = new Panel();
            BtnIngresar = new Button();
            chkRecordarSesion = new CheckBox();
            lblErrorLogin = new Label();
            lblErrorContrasena = new Label();
            PicLogo = new PictureBox();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            lblErrorUsuario = new Label();
            lblSubtituloLogin = new Label();
            PicCupula = new PictureBox();
            pnlLoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicCupula).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(114, 118);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(253, 41);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "Iniciar sesión";
            lblTituloLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(37, 236);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresa tu usuario";
            txtUsuario.Size = new Size(395, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(34, 205);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 24);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Anchor = AnchorStyles.None;
            pnlLoginCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginCard.Controls.Add(BtnIngresar);
            pnlLoginCard.Controls.Add(chkRecordarSesion);
            pnlLoginCard.Controls.Add(lblErrorLogin);
            pnlLoginCard.Controls.Add(lblErrorContrasena);
            pnlLoginCard.Controls.Add(PicLogo);
            pnlLoginCard.Controls.Add(txtContrasena);
            pnlLoginCard.Controls.Add(lblContrasena);
            pnlLoginCard.Controls.Add(lblErrorUsuario);
            pnlLoginCard.Controls.Add(lblSubtituloLogin);
            pnlLoginCard.Controls.Add(txtUsuario);
            pnlLoginCard.Controls.Add(lblTituloLogin);
            pnlLoginCard.Controls.Add(lblUsuario);
            pnlLoginCard.Location = new Point(1039, 224);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(473, 552);
            pnlLoginCard.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(0, 106, 166);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Modern No. 20", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Image = UI.Properties.Resources.IcIniciar;
            BtnIngresar.Location = new Point(66, 481);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(340, 38);
            BtnIngresar.TabIndex = 12;
            BtnIngresar.Text = "Iniciar sesión";
            BtnIngresar.TextAlign = ContentAlignment.MiddleRight;
            BtnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += btnIngresar_Click;
            // 
            // chkRecordarSesion
            // 
            chkRecordarSesion.AutoSize = true;
            chkRecordarSesion.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRecordarSesion.ForeColor = Color.FromArgb(0, 106, 166);
            chkRecordarSesion.Location = new Point(37, 418);
            chkRecordarSesion.Name = "chkRecordarSesion";
            chkRecordarSesion.Size = new Size(208, 25);
            chkRecordarSesion.TabIndex = 11;
            chkRecordarSesion.Text = "Mantener sesión iniciada";
            chkRecordarSesion.UseVisualStyleBackColor = true;
            // 
            // lblErrorLogin
            // 
            lblErrorLogin.AutoSize = true;
            lblErrorLogin.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorLogin.ForeColor = Color.FromArgb(166, 8, 8);
            lblErrorLogin.Location = new Point(37, 388);
            lblErrorLogin.Name = "lblErrorLogin";
            lblErrorLogin.Size = new Size(240, 21);
            lblErrorLogin.TabIndex = 10;
            lblErrorLogin.Text = "Usuario o contraseña incorrectas.";
            lblErrorLogin.Visible = false;
            // 
            // lblErrorContrasena
            // 
            lblErrorContrasena.AutoSize = true;
            lblErrorContrasena.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorContrasena.ForeColor = Color.FromArgb(166, 8, 8);
            lblErrorContrasena.Location = new Point(37, 361);
            lblErrorContrasena.Name = "lblErrorContrasena";
            lblErrorContrasena.Size = new Size(207, 21);
            lblErrorContrasena.TabIndex = 9;
            lblErrorContrasena.Text = "La contraseña es obligatoria.";
            lblErrorContrasena.Visible = false;
            // 
            // PicLogo
            // 
            PicLogo.Image = UI.Properties.Resources.LogoU;
            PicLogo.Location = new Point(114, 3);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(253, 112);
            PicLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PicLogo.TabIndex = 8;
            PicLogo.TabStop = false;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI Historic", 7F);
            txtContrasena.Location = new Point(37, 327);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Ingresa tu contraseña";
            txtContrasena.Size = new Size(397, 26);
            txtContrasena.TabIndex = 7;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Modern No. 20", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(34, 300);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(109, 24);
            lblContrasena.TabIndex = 6;
            lblContrasena.Text = "Contraseña";
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorUsuario.ForeColor = Color.FromArgb(166, 8, 8);
            lblErrorUsuario.Location = new Point(37, 270);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(180, 21);
            lblErrorUsuario.TabIndex = 5;
            lblErrorUsuario.Text = "El usuario es obligatorio.";
            lblErrorUsuario.Visible = false;
            // 
            // lblSubtituloLogin
            // 
            lblSubtituloLogin.AutoSize = true;
            lblSubtituloLogin.Font = new Font("Segoe UI Historic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloLogin.ForeColor = Color.FromArgb(151, 151, 151);
            lblSubtituloLogin.Location = new Point(84, 159);
            lblSubtituloLogin.Name = "lblSubtituloLogin";
            lblSubtituloLogin.Size = new Size(309, 21);
            lblSubtituloLogin.TabIndex = 4;
            lblSubtituloLogin.Text = "Sistema de gestión de horarios académicos";
            // 
            // PicCupula
            // 
            PicCupula.Image = UI.Properties.Resources.ImgCupula;
            PicCupula.Location = new Point(-305, -11);
            PicCupula.Name = "PicCupula";
            PicCupula.Size = new Size(1828, 972);
            PicCupula.SizeMode = PictureBoxSizeMode.Zoom;
            PicCupula.TabIndex = 4;
            PicCupula.TabStop = false;
            PicCupula.Click += picCupula_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1524, 930);
            Controls.Add(pnlLoginCard);
            Controls.Add(PicCupula);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FrmLogin_Load;
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicCupula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloLogin;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Panel pnlLoginCard;
        private Label lblSubtituloLogin;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Label lblErrorUsuario;
        private PictureBox PicCupula;
        private PictureBox PicLogo;
        private Label lblErrorLogin;
        private Label lblErrorContrasena;
        private CheckBox chkRecordarSesion;
        private Button BtnIngresar;
    }
}
