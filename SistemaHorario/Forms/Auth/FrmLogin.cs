using SistemaHorario.UI.Forms.Shell;
using SistemaHorarios.Infrastructure.Api;
using SistemaHorarios.Application.Requests.Auth;
namespace SistemaHorario
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { }

        private void picCupula_Click(object sender, EventArgs e)
        {
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            await ProbarConexionApi();
        }

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
                MessageBox.Show($"No se pudo conectar correctamente con la API: {respuesta.Mensaje}");
            }
        }
    }
}

