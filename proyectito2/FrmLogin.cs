using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectito2
{
    public partial class FrmLogin : Form
    {
        // 1. Declaramos los controles que usaremos en la pantalla
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnRegistrar;

        public FrmLogin()
        {
            // Inicializamos el formulario y cargamos los componentes dinámicamente
            ConfigurarFormulario();
            InicializarControles();
        }

        // Configuración estética básica de la ventana principal
        private void ConfigurarFormulario()
        {
            this.Text = "Control de Acceso - Sistema Médico";
            this.Size = new Size(400, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 244, 248); // Un gris azulado muy limpio y profesional
        }

        // Aquí creamos y posicionamos cada control usando coordenadas (X, Y)
        private void InicializarControles()
        {
            // Fuente compartida para que todo se vea uniforme
            Font fuenteGeneral = new Font("Segoe UI", 10F, FontStyle.Regular);

            // --- ETIQUETA Y CAMPO DE USUARIO ---
            lblUsuario = new Label();
            lblUsuario.Text = "Usuario:";
            lblUsuario.Font = fuenteGeneral;
            lblUsuario.Location = new Point(50, 40);
            lblUsuario.Size = new Size(300, 20);

            txtUser = new TextBox();
            txtUser.Font = fuenteGeneral;
            txtUser.Location = new Point(50, 65);
            txtUser.Size = new Size(280, 25);

            // --- ETIQUETA Y CAMPO DE CONTRASEÑA ---
            lblContrasena = new Label();
            lblContrasena.Text = "Contraseña:";
            lblContrasena.Font = fuenteGeneral;
            lblContrasena.Location = new Point(50, 105);
            lblContrasena.Size = new Size(300, 20);

            txtPass = new TextBox();
            txtPass.Font = fuenteGeneral;
            txtPass.Location = new Point(50, 130);
            txtPass.Size = new Size(280, 25);
            txtPass.PasswordChar = '*'; // Oculta el texto escrito

            // --- BOTÓN INICIAR SESIÓN ---
            btnLogin = new Button();
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(50, 180);
            btnLogin.Size = new Size(280, 35);
            btnLogin.BackColor = Color.FromArgb(14, 165, 233); // Azul moderno (#0EA5E9)
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += new EventHandler(BtnLogin_Click); // Enlace al evento

            // --- BOTÓN REGISTRAR PACIENTE ---
            btnRegistrar = new Button();
            btnRegistrar.Text = "Registrarse como Paciente";
            btnRegistrar.Font = fuenteGeneral;
            btnRegistrar.Location = new Point(50, 225);
            btnRegistrar.Size = new Size(280, 30);
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.FlatAppearance.BorderSize = 1;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 230, 242);
            btnRegistrar.Click += new EventHandler(BtnRegistrar_Click); // Enlace al evento

            // --- AGREGAR CONTROLES AL FORMULARIO ---
            this.Controls.Add(lblUsuario);
            this.Controls.Add(txtUser);
            this.Controls.Add(lblContrasena);
            this.Controls.Add(txtPass);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnRegistrar);
        }

        // --- LÓGICA DE INTERACCIÓN (FRONTEND) ---

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Validación visual en Frontend
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUser.Text.Trim().ToLower();

            // Simulación de ruteo para el equipo de Backend
            if (usuario == "admin")
            {
                MessageBox.Show("¡Acceso correcto! Abriendo panel de Administrador...", "Simulación Frontend");
            }
            else if (usuario == "psico")
            {
                MessageBox.Show("¡Acceso correcto! Abriendo portal de Psicólogos...", "Simulación Frontend");
            }
            else
            {
                MessageBox.Show("¡Acceso correcto! Abriendo portal de Pacientes...", "Simulación Frontend");
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo ventana de registro de pacientes...", "Simulación Frontend");
        }
    }
}