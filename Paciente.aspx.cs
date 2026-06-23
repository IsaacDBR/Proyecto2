using System;
using System.Data;
using System.Web.UI;
using proyectito2.Model;
using proyectito2.Presenter;

namespace proyectito2
{
    public partial class Paciente : System.Web.UI.Page
    {
        // Instanciamos el Presenter del Paciente
        private WPacientes presenter = new WPacientes();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Mostramos el nombre del Paciente que inició sesión globalmente
            lblNombrePaciente.Text = CUsuario.UsuarioLogueadoNombre;

            // Evitamos que la tabla se recargue de más si ocurre una acción posterior
            if (!IsPostBack)
            {
                CargarCatalogoPsicologos();
            }
        }

        /// <summary>
        /// Solicita los datos al Presenter y renderiza la tabla en la interfaz web
        /// </summary>
        private void CargarCatalogoPsicologos()
        {
            DataTable dt = presenter.ObtenerCatalogoPsicologos();
            dgvPsicologosDisponibles.DataSource = dt;
            dgvPsicologosDisponibles.DataBind(); // Obligatorio en Web Forms para pintar los datos
        }
    }
}