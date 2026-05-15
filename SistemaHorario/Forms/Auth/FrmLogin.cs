using SistemaHorario.UI.Forms.Shell;
using SistemaHorarios.Infrastructure.Api;

namespace SistemaHorario
{
    /// <summary>
    /// Representa el formulario de inicio de sesión del sistema.
    /// </summary>
    /// <remarks>
    /// Este formulario permite al usuario ingresar sus credenciales para acceder
    /// a la aplicación.
    ///
    /// Se encarga de validar los campos obligatorios, ocultar visualmente la contraseña,
    /// mostrar mensajes de error y verificar la conexión con la API antes de abrir
    /// el formulario principal.
    ///
    /// Actualmente utiliza una validación temporal local con las credenciales:
    /// usuario "admin" y contraseña "1234".
    /// </remarks>
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FrmLogin"/>.
        /// </summary>
        /// <remarks>
        /// Durante la inicialización se cargan los componentes visuales,
        /// se configura el campo de contraseña para ocultar los caracteres escritos
        /// y se limpian los mensajes de error del formulario.
        /// </remarks>
        public FrmLogin()
        {
            InitializeComponent();
            // Oculta la contraseña con puntos/asteriscos.
            txtContrasena.UseSystemPasswordChar = true;

            // Oculta los mensajes de error al iniciar.
            LimpiarErrores();
        }

        /// <summary>
        /// Controla el evento Load del formulario de inicio de sesión.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/>.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento Load.
        /// </param>
        /// <remarks>
        /// Actualmente no ejecuta ninguna acción al cargar el formulario.
        /// Se conserva para futuras configuraciones iniciales si son necesarias.
        /// </remarks>
        private void FrmLogin_Load(object? sender, EventArgs e)
        { }

        /// <summary>
        /// Controla el evento Click de la imagen de la cúpula.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/>.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento Click.
        /// </param>
        /// <remarks>
        /// Actualmente no ejecuta ninguna acción.
        /// Se conserva en caso de que posteriormente se requiera agregar interacción
        /// sobre la imagen.
        /// </remarks>
        private void picCupula_Click(object? sender, EventArgs e)
        {
        }

        /// <summary>
        /// Controla el evento Click del botón Ingresar.
        /// </summary>
        /// <param name="sender">
        /// Objeto que generó el evento. Puede ser <see langword="null"/>.
        /// </param>
        /// <param name="e">
        /// Datos asociados al evento Click.
        /// </param>
        /// <remarks>
        /// Primero valida que los campos de usuario y contraseña no estén vacíos.
        ///
        /// Luego obtiene los datos ingresados por el usuario y realiza una validación
        /// temporal local.
        ///
        /// Si las credenciales son incorrectas, muestra un mensaje de error visual.
        /// Si las credenciales son correctas, prueba la conexión con la API.
        /// </remarks>

        private async void btnIngresar_Click(object? sender, EventArgs e)
        {
            // Primero valida que usuario y contraseña no estén vacíos.
            if (!ValidarCampos())
                return;
            LimpiarErrores();
            // Datos escritos por el usuario.
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validación temporal utilizada únicamente durante desarrollo.
            // Será reemplazada posteriormente por autenticación real mediante API.
            bool credencialesCorrectas =
                usuario == "admin" &&
                contrasena == "1234";

            // Si las credenciales no coinciden, muestra error visual.
            if (!credencialesCorrectas)
            {
                lblErrorLogin.Text = "Credenciales incorrectas.";
                lblErrorLogin.Visible = true;
                return;
            }
            await ProbarConexionApi();
        }

        /// <summary>
        /// Prueba la conexión con la API del sistema antes de permitir el acceso al formulario principal.
        /// </summary>
        /// <returns>
        /// Una tarea que representa la operación asincrónica de conexión con la API.
        /// </returns>
        /// <remarks>
        /// Crea una instancia de <see cref="SistemaHorariosApiService"/> y ejecuta
        /// la prueba de conexión mediante el método correspondiente.
        ///
        /// Si la respuesta es exitosa, muestra un mensaje de confirmación,
        /// abre <see cref="FrmPrincipal"/> y oculta el formulario de inicio de sesión.
        ///
        /// Si la respuesta no es exitosa, muestra un mensaje de error en el formulario
        /// y notifica al usuario que no fue posible conectarse correctamente con la API.
        /// </remarks>

        private async Task ProbarConexionApi()
        {
            SistemaHorariosApiService apiService = new SistemaHorariosApiService();

            var respuesta = await apiService.ProbarConexionAsync();

            if (respuesta.Exitoso)
            {
                MessageBox.Show("Conexión exitosa con la API.");

                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                lblErrorLogin.Text = "No se pudo conectar con la API.";
                lblErrorLogin.Visible = true;

                MessageBox.Show($"No se pudo conectar correctamente con la API: {respuesta.Mensaje}");
            }
        }


        /// <summary>
        /// Valida que los campos obligatorios del formulario contengan información.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> si los campos de usuario y contraseña contienen datos;
        /// de lo contrario, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// Antes de validar, limpia los mensajes de error existentes.
        ///
        /// Si el campo de usuario está vacío, muestra un mensaje indicando que el usuario
        /// es obligatorio.
        ///
        /// Si el campo de contraseña está vacío, muestra un mensaje indicando que la contraseña
        /// es obligatoria.
        /// </remarks>
        private bool ValidarCampos()
        {
            LimpiarErrores();

            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                lblErrorUsuario.Text = "El usuario es obligatorio.";
                lblErrorUsuario.Visible = true;
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                lblErrorContrasena.Text = "La contraseña es obligatoria.";
                lblErrorContrasena.Visible = true;
                esValido = false;
            }

            return esValido;
        }

        /// <summary>
        /// Limpia y oculta los mensajes de error del formulario de inicio de sesión.
        /// </summary>
        /// <remarks>
        /// Borra el texto de las etiquetas de error asociadas al usuario,
        /// la contraseña y el inicio de sesión general.
        ///
        /// También oculta las etiquetas para que no se muestren hasta que ocurra
        /// una nueva validación o un nuevo error.
        /// </remarks>
        private void LimpiarErrores()
        {
            lblErrorUsuario.Text = "";
            lblErrorContrasena.Text = "";
            lblErrorLogin.Text = "";

            lblErrorUsuario.Visible = false;
            lblErrorContrasena.Visible = false;
            lblErrorLogin.Visible = false;
        }
    }
}

