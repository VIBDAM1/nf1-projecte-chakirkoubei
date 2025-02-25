using System;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void Contacto_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta al cargar el formulario
        }

        // Evento para el botón "Enviar Mensaje"
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de enviar el mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación
            MessageBox.Show("Se ha enviado tu mensaje.", "Mensaje Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para el menú "Home"
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de inicio
            Inicio inicioForm = new Inicio();
            inicioForm.Show();  // Muestra el formulario de inicio
            this.Hide();       // Oculta el formulario actual (opcional)
        }

        // Evento para el menú "Planificación Entrenamientos"
        private void planificacionEntrenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de planificación de entrenamientos
            Planifiacion_Entrenamientos planificacionForm = new Planifiacion_Entrenamientos();
            planificacionForm.Show();  // Muestra el formulario
            this.Hide();               // Oculta el formulario actual (opcional)
        }

        // Evento para el menú "Seguimiento Actividad"
        private void seguimientoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de seguimiento de actividad
            Seguimiento_Actividad seguimientoForm = new Seguimiento_Actividad();
            seguimientoForm.Show();  // Muestra el formulario
            this.Hide();             // Oculta el formulario actual (opcional)
        }

        // Evento para el menú "Nutrición"
        private void nutricionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de nutrición
            Nutricion nutricionForm = new Nutricion();
            nutricionForm.Show();  // Muestra el formulario
            this.Hide();          // Oculta el formulario actual (opcional)
        }

        // Evento para el menú "Ayuda"
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No es necesario hacer nada, ya estamos en este formulario
        }
    }
}