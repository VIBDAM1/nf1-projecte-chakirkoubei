using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al hacer clic en el botón "Registrarse"
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // Campo 1
                string.IsNullOrWhiteSpace(textBox2.Text) ||  // Campo 2
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // Campo 3
                string.IsNullOrWhiteSpace(textBox4.Text))    // Campo 4
            {
                // Mostrar un mensaje de error si algún campo está vacío
                MessageBox.Show("Por favor, complete todos los campos antes de registrarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Salir del método sin continuar
            }

            // Si todos los campos están llenos, continuar con el registro
            // Crear una instancia del formulario de inicio
            Inicio inicioForm = new Inicio();

            // Mostrar el formulario de inicio
            inicioForm.Show();

            // Cerrar el formulario de registro
            this.Hide();  // Puedes usar 'this.Close()' si deseas cerrar completamente la ventana actual.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Evento de cambio de texto en el TextBox1
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento de clic en el Label1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento de clic en el Label2
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Evento de cambio de texto en el TextBox4
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // Evento de carga del formulario
        }
    }
}