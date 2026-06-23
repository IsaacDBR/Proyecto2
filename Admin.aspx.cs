using System;
using System.Data;
using System.Web.UI;
using proyectito2.Model;
using proyectito2.Presenter;

namespace proyectito2
{
    public partial class Admin : System.Web.UI.Page
    {
        // Instanciamos el Presenter de Administración
        private WAdmin presenter = new WAdmin();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Mostramos el nombre del Administrador que inició sesión globalmente
            lblNombreAdmin.Text = CUsuario.UsuarioLogueadoNombre;

            // Page.IsPostBack evita que la tabla se recargue innecesariamente al presionar botones
            if (!IsPostBack)
            {
                ActualizarGridPsicologos();
            }
        }

        /// <summary>
        /// Método encargado de solicitar los datos al Presenter y llenar el GridView
        /// </summary>
        private void ActualizarGridPsicologos()
        {
            DataTable dt = presenter.ObtenerPsicologos();
            dgvPsicologos.DataSource = dt;
            dgvPsicologos.DataBind(); // En Web Forms es obligatorio usar DataBind() para renderizar la tabla
        }

        protected void btnGuardarPsico_Click(object sender, EventArgs e)
        {
            // Validamos campos vacíos en el servidor
            if (string.IsNullOrWhiteSpace(txtNombrePsico.Text) || string.IsNullOrWhiteSpace(txtUserPsico.Text) || string.IsNullOrWhiteSpace(txtPassPsico.Text))
            {
                Response.Write("<script>alert('Por favor, completa todos los campos del psicólogo.');</script>");
                return;
            }

            // Enviamos los datos al Presenter para que los guarde en la Base de Datos
            bool exito = presenter.RegistrarPsicologo(txtNombrePsico.Text, txtUserPsico.Text, txtPassPsico.Text);

            if (exito)
            {
                // Alerta de éxito nativa del navegador
                Response.Write("<script>alert('Psicólogo registrado con éxito en la Base de Datos.');</script>");

                // Limpieza de cajas de texto
                txtNombrePsico.Text = string.Empty;
                txtUserPsico.Text = string.Empty;
                txtPassPsico.Text = string.Empty;

                // Refrescamos la tabla al instante
                ActualizarGridPsicologos();
            }
            else
            {
                Response.Write("<script>alert('Error al registrar. Es posible que el correo ya esté en uso.');</script>");
            }
        }
    }
}