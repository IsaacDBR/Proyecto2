using System;
using proyectito2.Model;
using proyectito2.Presenter;

namespace proyectito2
{
    public partial class Login : System.Web.UI.Page
    {
        // Instanciamos el Presenter encargado de los usuarios
        private WUsuarios presenter = new WUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            // El Page_Load se puede quedar vacío por ahora
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMensajeError.Text = "Por favor, ingresa tu correo y contraseña.";
                return;
            }

            // Llamamos a la lógica del Presenter
            bool loginExitoso = presenter.IniciarSesion(txtEmail.Text, txtPassword.Text);

            if (loginExitoso)
            {
                // Evaluamos el rol guardado en la sesión global (CUsuario) para redireccionar
                string rol = CUsuario.UsuarioLogueadoRol.ToLower();

                if (rol == "administrador" || rol == "admin")
                {
                    Response.Redirect("Admin.aspx");
                }
                else if (rol == "psicologo" || rol == "medico")
                {
                    Response.Redirect("Psicologo.aspx");
                }
                else if (rol == "paciente")
                {
                    Response.Redirect("Paciente.aspx");
                }
                else
                {
                    lblMensajeError.Text = "El rol asignado a este usuario no es válido.";
                }
            }
            else
            {
                // Si el Presenter devuelve false, mostramos el error en la etiqueta del HTML
                lblMensajeError.Text = "Correo o contraseña incorrectos.";
            }
        }
    }
}