using System;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Seguimiento_Actividad : Form
    {
        // Variable para llevar el control del progreso
        private int progreso = 0;

        public Seguimiento_Actividad()
        {
            InitializeComponent();
        }

        private void Seguimiento_Actividad_Load(object sender, EventArgs e)
        {
            // Inicializar el ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100; // 100% de progreso
            progressBar1.Value = 0;    // Empezar en 0%
        }

        // Evento para el botón que avanza el ProgressBar
        private void button1_Click(object sender, EventArgs e)
        {
            // Aumentar el progreso en un 10% (simulando un día de entrenamiento)
            progreso += 10;

            // Verificar que no se exceda el máximo
            if (progreso > 100)
            {
                progreso = 100; // No superar el 100%
                MessageBox.Show("¡Has completado tu rutina semanal!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar el ProgressBar
            progressBar1.Value = progreso;

            // Mostrar el progreso en un Label (opcional)
            label2.Text = $"Progreso: {progreso}%";
        }

        // Evento para el menú "Home"
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de inicio
            Inicio inicioForm = new Inicio();
            inicioForm.Show();  // Muestra el formulario de inicio
            this.Hide();         // Oculta el formulario actual (opcional)
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
            // No es necesario hacer nada, ya estamos en este formulario
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
            // Abrir el formulario de ayuda
            Contacto ayudaForm = new Contacto();
            ayudaForm.Show();  // Muestra el formulario
            this.Hide();      // Oculta el formulario actual (opcional)
        }
    }
}