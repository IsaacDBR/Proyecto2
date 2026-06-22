using System;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectito2
{
    public partial class FrmAdmin : Form
    {
        // Controles para el alta de psicólogos
        private Label lblTitulo;
        private Label lblNombrePsico;
        private Label lblUserPsico;
        private Label lblPassPsico;
        private TextBox txtNombrePsico;
        private TextBox txtUserPsico;
        private TextBox txtPassPsico;
        private Button btnGuardarPsico;
        private DataGridView dgvPsicologos;
        private Label lblLista;

        public FrmAdmin()
        {
            ConfigurarFormulario();
            InicializarControles();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Panel de Administración - Gestión de Psicólogos";
            this.Size = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void InicializarControles()
        {
            Font fuenteTitulo = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font fuenteGeneral = new Font("Segoe UI", 10F, FontStyle.Regular);

            // --- TÍTULO PRINCIPAL ---
            lblTitulo = new Label();
            lblTitulo.Text = "Registrar Nuevo Psicólogo";
            lblTitulo.Font = fuenteTitulo;
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(300, 30);

            // --- CAMPO: NOMBRE COMPLETO ---
            lblNombrePsico = new Label();
            lblNombrePsico.Text = "Nombre Completo:";
            lblNombrePsico.Font = fuenteGeneral;
            lblNombrePsico.Location = new Point(30, 70);
            lblNombrePsico.Size = new Size(250, 20);

            txtNombrePsico = new TextBox();
            txtNombrePsico.Font = fuenteGeneral;
            txtNombrePsico.Location = new Point(30, 95);
            txtNombrePsico.Size = new Size(250, 25);

            // --- CAMPO: USUARIO ---
            lblUserPsico = new Label();
            lblUserPsico.Text = "Usuario de Acceso:";
            lblUserPsico.Font = fuenteGeneral;
            lblUserPsico.Location = new Point(30, 140);
            lblUserPsico.Size = new Size(250, 20);

            txtUserPsico = new TextBox();
            txtUserPsico.Font = fuenteGeneral;
            txtUserPsico.Location = new Point(30, 165);
            txtUserPsico.Size = new Size(250, 25);

            // --- CAMPO: CONTRASEÑA ---
            lblPassPsico = new Label();
            lblPassPsico.Text = "Contraseña:";
            lblPassPsico.Font = fuenteGeneral;
            lblPassPsico.Location = new Point(30, 210);
            lblPassPsico.Size = new Size(250, 20);

            txtPassPsico = new TextBox();
            txtPassPsico.Font = fuenteGeneral;
            txtPassPsico.Location = new Point(30, 235);
            txtPassPsico.Size = new Size(250, 25);
            txtPassPsico.PasswordChar = '*';

            // --- BOTÓN: GUARDAR PSICÓLOGO ---
            btnGuardarPsico = new Button();
            btnGuardarPsico.Text = "Registrar Psicólogo";
            btnGuardarPsico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarPsico.Location = new Point(30, 290);
            btnGuardarPsico.Size = new Size(250, 40);
            btnGuardarPsico.BackColor = Color.FromArgb(20, 184, 166); // Color Teal/Esmeralda profesional
            btnGuardarPsico.ForeColor = Color.White;
            btnGuardarPsico.FlatStyle = FlatStyle.Flat;
            btnGuardarPsico.FlatAppearance.BorderSize = 0;
            btnGuardarPsico.Click += new EventHandler(BtnGuardarPsico_Click);

            // --- TABLA DE PSICÓLOGOS (DGV) ---
            lblLista = new Label();
            lblLista.Text = "Psicólogos Registrados en el Sistema:";
            lblLista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLista.Location = new Point(330, 25);
            lblLista.Size = new Size(400, 25);

            dgvGridConfig();

            // --- AGREGAR CONTROLES A LA INTERFAZ ---
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblNombrePsico);
            this.Controls.Add(txtNombrePsico);
            this.Controls.Add(lblUserPsico);
            this.Controls.Add(txtUserPsico);
            this.Controls.Add(lblPassPsico);
            this.Controls.Add(txtPassPsico);
            this.Controls.Add(btnGuardarPsico);
            this.Controls.Add(lblLista);
            this.Controls.Add(dgvPsicologos);
        }

        private void dgvGridConfig()
        {
            dgvPsicologos = new DataGridView();
            dgvPsicologos.Location = new Point(330, 60);
            dgvPsicologos.Size = new Size(420, 320);
            dgvPsicologos.BackgroundColor = Color.White;
            dgvPsicologos.BorderStyle = BorderStyle.Fixed3D;
            dgvPsicologos.AllowUserToAddRows = false;
            dgvPsicologos.ReadOnly = true;
            dgvPsicologos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- INTERACCIÓN FRONTEND ---
        private void BtnGuardarPsico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePsico.Text) || string.IsNullOrWhiteSpace(txtUserPsico.Text) || string.IsNullOrWhiteSpace(txtPassPsico.Text))
            {
                MessageBox.Show("Por favor, completa todos los datos del psicólogo.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí interactuará el backend agregando a la lista o base de datos.
            MessageBox.Show($"Frontend listo: El psicólogo '{txtNombrePsico.Text}' se mandará al proceso de guardado de tus compañeros.", "Simulación Guardar");

            // Limpieza básica de interfaz tras la acción
            txtNombrePsico.Clear();
            txtUserPsico.Clear();
            txtPassPsico.Clear();
        }
    }
}