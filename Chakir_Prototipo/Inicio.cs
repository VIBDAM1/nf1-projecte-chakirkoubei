using System;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // C�digo que se ejecuta al cargar el formulario
        }

        // Evento para el men� "Planificaci�n Entrenamientos"
        private void planificacionEntrenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de planificaci�n de entrenamientos
            Planifiacion_Entrenamientos planificacionForm = new Planifiacion_Entrenamientos();
            planificacionForm.Show();  // Muestra el formulario
            this.Hide();               // Oculta el formulario actual (opcional)
        }

        // Evento para el men� "Seguimiento Actividad"
        private void seguimientoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de seguimiento de actividad
            Seguimiento_Actividad seguimientoForm = new Seguimiento_Actividad();
            seguimientoForm.Show();  // Muestra el formulario
            this.Hide();             // Oculta el formulario actual (opcional)
        }

        // Evento para el men� "Nutrici�n"
        private void nutricionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de nutrici�n
            Nutricion nutricionForm = new Nutricion();
            nutricionForm.Show();  // Muestra el formulario
            this.Hide();           // Oculta el formulario actual (opcional)
        }

        // Evento para el men� "Ayuda"
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}