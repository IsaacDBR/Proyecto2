using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectito2
{
    public partial class FrmPsicologo : Form
    {
        // Declaración de controles para el portal médico
        private Label lblTitulo;
        private Label lblPacientesAsignados;
        private DataGridView dgvPacientesAsignados;

        private GroupBox grpAgendarPorMedico;
        private Label lblFechaPsico;
        private DateTimePicker dtpFechaPsico;
        private Button btnAgendarCitaMedico;

        public FrmPsicologo()
        {
            ConfigurarFormulario();
            InicializarControles();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Portal del Especialista - Gestión de Agenda Médica";
            this.Size = new Size(820, 460);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void InicializarControles()
        {
            Font fuenteTitulo = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font fuenteGeneral = new Font("Segoe UI", 10F, FontStyle.Regular);

            // --- TÍTULO DEL PORTAL ---
            lblTitulo = new Label();
            lblTitulo.Text = "Panel de Control Clínico";
            lblTitulo.Font = fuenteTitulo;
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(300, 30);

            // --- SECCIÓN: PACIENTES VINCULADOS ---
            lblPacientesAsignados = new Label();
            lblPacientesAsignados.Text = "Tus Pacientes Vinculados:";
            lblPacientesAsignados.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPacientesAsignados.Location = new Point(30, 65);
            lblPacientesAsignados.Size = new Size(300, 25);

            // Configuración de la tabla de pacientes asignados
            dgvPacientesAsignados = new DataGridView();
            dgvPacientesAsignados.Location = new Point(30, 95);
            dgvPacientesAsignados.Size = new Size(400, 290);
            dgvPacientesAsignados.BackgroundColor = Color.White;
            dgvPacientesAsignados.BorderStyle = BorderStyle.Fixed3D;
            dgvPacientesAsignados.AllowUserToAddRows = false;
            dgvPacientesAsignados.ReadOnly = true;
            dgvPacientesAsignados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientesAsignados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- SECCIÓN: CONTENEDOR PARA AGENDAR CITA A PACIENTE ---
            grpAgendarPorMedico = new GroupBox();
            grpAgendarPorMedico.Text = "Asignar Nueva Cita a Paciente";
            grpAgendarPorMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAgendarPorMedico.Location = new Point(455, 85);
            grpAgendarPorMedico.Size = new Size(320, 300);

            lblFechaPsico = new Label();
            lblFechaPsico.Text = "1. Selecciona Fecha y Hora:";
            lblFechaPsico.Font = fuenteGeneral;
            lblFechaPsico.Location = new Point(20, 45);
            lblFechaPsico.Size = new Size(250, 20);

            dtpFechaPsico = new DateTimePicker();
            dtpFechaPsico.Font = fuenteGeneral;
            dtpFechaPsico.Location = new Point(20, 75);
            dtpFechaPsico.Size = new Size(280, 25);
            dtpFechaPsico.Format = DateTimePickerFormat.Custom;
            dtpFechaPsico.CustomFormat = "dd/MM/yyyy hh:mm tt";

            btnAgendarCitaMedico = new Button();
            btnAgendarCitaMedico.Text = "Agendar Cita a Selección";
            btnAgendarCitaMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgendarCitaMedico.Location = new Point(20, 140);
            btnAgendarCitaMedico.Size = new Size(280, 45);
            btnAgendarCitaMedico.BackColor = Color.FromArgb(79, 70, 229); // Un Indigo/Morado muy elegante
            btnAgendarCitaMedico.ForeColor = Color.White;
            btnAgendarCitaMedico.FlatStyle = FlatStyle.Flat;
            btnAgendarCitaMedico.FlatAppearance.BorderSize = 0;
            btnAgendarCitaMedico.Click += new EventHandler(BtnAgendarCitaMedico_Click);

            // Agregar elementos dentro del contenedor
            grpAgendarPorMedico.Controls.Add(lblFechaPsico);
            grpAgendarPorMedico.Controls.Add(dtpFechaPsico);
            grpAgendarPorMedico.Controls.Add(btnAgendarCitaMedico);

            // Agregar todo al formulario
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblPacientesAsignados);
            this.Controls.Add(dgvPacientesAsignados);
            this.Controls.Add(grpAgendarPorMedico);
        }

        // --- INTERACCIÓN FRONTEND ---
        private void BtnAgendarCitaMedico_Click(object sender, EventArgs e)
        {
            // Simulación en el Frontend: Validar que el psicólogo haya seleccionado a alguien de la tabla
            // (Para efectos de prueba, el backend procesará el renglón activo de la DataGridView)

            MessageBox.Show($"Frontend verificado: Cita agendada por el psicólogo para la fecha: {dtpFechaPsico.Text}.\n\nTus compañeros del backend conectarán la tabla para jalar el nombre exacto del paciente.", "Cita Registrada por Médico");
        }
    }
}