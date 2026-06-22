using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectito2
{
    public partial class FrmPaciente : Form
    {
        // Controles de la Interfaz
        private Label lblTitulo;
        private Label lblStatusVinculo;
        private Label lblSeleccionarPsico;
        private ComboBox cmbPsicologos;
        private Button btnVincular;

        private GroupBox grpCitas;
        private Label lblFecha;
        private DateTimePicker dtpFechaCita;
        private Button btnAgendarCita;

        // Variable de simulación para el Frontend (Controla si ya está vinculado o no)
        private bool estaVinculado = false;

        public FrmPaciente()
        {
            ConfigurarFormulario();
            InicializarControles();
            ActualizarEstadoInterfaz();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Portal del Paciente - Mi Agenda Virtual";
            this.Size = new Size(500, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void InicializarControles()
        {
            Font fuenteTitulo = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font fuenteGeneral = new Font("Segoe UI", 10F, FontStyle.Regular);

            // --- TÍTULO ---
            lblTitulo = new Label();
            lblTitulo.Text = "Panel de Control de Pacientes";
            lblTitulo.Font = fuenteTitulo;
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(400, 30);

            // --- ESTADO DE VÍNCULO ---
            lblStatusVinculo = new Label();
            lblStatusVinculo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblStatusVinculo.ForeColor = Color.Firebrick;
            lblStatusVinculo.Location = new Point(30, 60);
            lblStatusVinculo.Size = new Size(420, 25);

            // --- SELECCIÓN DE PSICÓLOGO ---
            lblSeleccionarPsico = new Label();
            lblSeleccionarPsico.Text = "Selecciona un Psicólogo Disponible:";
            lblSeleccionarPsico.Font = fuenteGeneral;
            lblSeleccionarPsico.Location = new Point(30, 100);
            lblSeleccionarPsico.Size = new Size(300, 20);

            cmbPsicologos = new ComboBox();
            cmbPsicologos.Font = fuenteGeneral;
            cmbPsicologos.Location = new Point(30, 125);
            cmbPsicologos.Size = new Size(260, 25);
            cmbPsicologos.DropDownStyle = ComboBoxStyle.DropDownList;

            // Elementos de prueba para simular la lista del Frontend
            cmbPsicologos.Items.Add("Dr. Sigmund Freud");
            cmbPsicologos.Items.Add("Dra. Melanie Klein");
            cmbPsicologos.Items.Add("Dr. Carl Rogers");
            if (cmbPsicologos.Items.Count > 0) cmbPsicologos.SelectedIndex = 0;

            // --- BOTÓN VINCULAR ---
            btnVincular = new Button();
            btnVincular.Text = "Vincularme";
            btnVincular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVincular.Location = new Point(310, 123);
            btnVincular.Size = new Size(140, 30);
            btnVincular.BackColor = Color.FromArgb(14, 165, 233); // Azul
            btnVincular.ForeColor = Color.White;
            btnVincular.FlatStyle = FlatStyle.Flat;
            btnVincular.FlatAppearance.BorderSize = 0;
            btnVincular.Click += new EventHandler(BtnVincular_Click);

            // --- CONTENEDOR (GROUPBOX) PARA AGENDAR CITAS ---
            grpCitas = new GroupBox();
            grpCitas.Text = "Agendar Cita Médica";
            grpCitas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCitas.Location = new Point(30, 190);
            grpCitas.Size = new Size(420, 200);

            lblFecha = new Label();
            lblFecha.Text = "Selecciona la Fecha y Hora:";
            lblFecha.Font = fuenteGeneral;
            lblFecha.Location = new Point(20, 40);
            lblFecha.Size = new Size(200, 20);

            dtpFechaCita = new DateTimePicker();
            dtpFechaCita.Font = fuenteGeneral;
            dtpFechaCita.Location = new Point(20, 65);
            dtpFechaCita.Size = new Size(380, 25);
            dtpFechaCita.Format = DateTimePickerFormat.Custom;
            dtpFechaCita.CustomFormat = "dd/MM/yyyy hh:mm tt";

            btnAgendarCita = new Button();
            btnAgendarCita.Text = "Confirmar y Agendar Cita";
            btnAgendarCita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgendarCita.Location = new Point(20, 120);
            btnAgendarCita.Size = new Size(380, 40);
            btnAgendarCita.BackColor = Color.FromArgb(20, 184, 166); // Teal
            btnAgendarCita.ForeColor = Color.White;
            btnAgendarCita.FlatStyle = FlatStyle.Flat;
            btnAgendarCita.FlatAppearance.BorderSize = 0;
            btnAgendarCita.Click += new EventHandler(BtnAgendarCita_Click);

            // Añadir elementos al contenedor de citas
            grpCitas.Controls.Add(lblFecha);
            grpCitas.Controls.Add(dtpFechaCita);
            grpCitas.Controls.Add(btnAgendarCita);

            // Añadir al formulario principal
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblStatusVinculo);
            this.Controls.Add(lblSeleccionarPsico);
            this.Controls.Add(cmbPsicologos);
            this.Controls.Add(btnVincular);
            this.Controls.Add(grpCitas);
        }

        // Método encargado de bloquear o desbloquear la UI según las reglas del negocio
        private void ActualizarEstadoInterfaz()
        {
            if (estaVinculado)
            {
                string psicoSeleccionado = cmbPsicologos.SelectedItem?.ToString() ?? "Tu Psicólogo";
                lblStatusVinculo.Text = $"Estado: Vinculado correctamente con [{psicoSeleccionado}]";
                lblStatusVinculo.ForeColor = Color.DarkGreen;

                // Regreso del requerimiento: Bloquear combobox y botón para no ver otros psicólogos
                cmbPsicologos.Enabled = false;
                btnVincular.Enabled = false;

                // Permitir agendar citas
                grpCitas.Enabled = true;
            }
            else
            {
                lblStatusVinculo.Text = "Estado: No estás vinculado a ningún psicólogo. (Acción requerida)";
                lblStatusVinculo.ForeColor = Color.Firebrick;

                cmbPsicologos.Enabled = true;
                btnVincular.Enabled = true;

                // REQUERIMIENTO COMPLIDO: No permite agendar citas si no hay vínculo
                grpCitas.Enabled = false;
            }
        }

        // --- LÓGICA FRONTEND ---
        private void BtnVincular_Click(object sender, EventArgs e)
        {
            estaVinculado = true;
            MessageBox.Show("Vínculo establecido con éxito. A partir de ahora podrás agendar tus citas.", "Frontend Exitoso");
            ActualizarEstadoInterfaz();
        }

        private void BtnAgendarCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cita agendada correctamente para el: {dtpFechaCita.Text}", "Confirmación de Cita");
        }
    }
}