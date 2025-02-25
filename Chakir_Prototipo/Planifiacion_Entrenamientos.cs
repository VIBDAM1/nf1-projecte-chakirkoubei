using System;
using System.Text;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Planifiacion_Entrenamientos : Form
    {
        public Planifiacion_Entrenamientos()
        {
            InitializeComponent();
        }

        private void Planifiacion_Entrenamientos_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox1 con tipos de entrenamiento
            comboBox1.Items.AddRange(new string[] { "Cardio", "Fuerza", "Flexibilidad", "Resistencia" });

            // Llenar ComboBox2 con días de entrenamiento
            comboBox2.Items.AddRange(new string[] { "2 días", "3 días", "4 días", "5 días", "6 días" });

            // Llenar ComboBox3 con objetivos
            comboBox3.Items.AddRange(new string[] { "Bajar de peso", "Ganar masa muscular", "Mejorar resistencia", "Tonificar" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se han seleccionado opciones en todos los ComboBox
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona todas las opciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener las selecciones de los ComboBox
            string tipoEntrenamiento = comboBox1.SelectedItem.ToString();
            string diasEntrenamiento = comboBox2.SelectedItem.ToString();
            string objetivo = comboBox3.SelectedItem.ToString();

            // Mensaje de depuración
            MessageBox.Show($"Selecciones: {tipoEntrenamiento}, {diasEntrenamiento}, {objetivo}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Generar la rutina recomendada basada en las selecciones
            string rutina = GenerarRutinaRecomendada(tipoEntrenamiento, diasEntrenamiento, objetivo);

            // Mostrar la rutina en el TextBox
            textBox1.Text = rutina;

            // Mensaje de depuración
            MessageBox.Show("Rutina generada correctamente.", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerarRutinaRecomendada(string tipoEntrenamiento, string diasEntrenamiento, string objetivo)
        {
            StringBuilder rutina = new StringBuilder();

            // Encabezado de la rutina
            rutina.AppendLine($"Rutina recomendada para {tipoEntrenamiento} ({diasEntrenamiento} por semana, objetivo: {objetivo}):");
            rutina.AppendLine();

            // Rutina basada en el tipo de entrenamiento
            switch (tipoEntrenamiento)
            {
                case "Cardio":
                    rutina.AppendLine("- 20-40 minutos de carrera, bicicleta o elíptica.");
                    rutina.AppendLine("- Incluye intervalos de alta intensidad (HIIT) si tu objetivo es bajar de peso.");
                    break;

                case "Fuerza":
                    rutina.AppendLine("- 3-5 series de 8-12 repeticiones de ejercicios como sentadillas, press de banca y peso muerto.");
                    rutina.AppendLine("- Aumenta el peso gradualmente para ganar masa muscular.");
                    break;

                case "Flexibilidad":
                    rutina.AppendLine("- 15-30 minutos de estiramientos estáticos y dinámicos.");
                    rutina.AppendLine("- Incluye yoga o pilates para mejorar la flexibilidad y la postura.");
                    break;

                case "Resistencia":
                    rutina.AppendLine("- 30-60 minutos de entrenamiento en circuito o carrera continua.");
                    rutina.AppendLine("- Combina ejercicios de fuerza y cardio para mejorar la resistencia.");
                    break;
            }

            // Ajustar la rutina según los días de entrenamiento
            switch (diasEntrenamiento)
            {
                case "2 días":
                    rutina.AppendLine("\nDistribución semanal: 2 días de entrenamiento y 5 días de descanso activo (caminar, estiramientos).");
                    break;

                case "3 días":
                    rutina.AppendLine("\nDistribución semanal: 3 días de entrenamiento y 4 días de descanso activo.");
                    break;

                case "4 días":
                    rutina.AppendLine("\nDistribución semanal: 4 días de entrenamiento y 3 días de descanso activo.");
                    break;

                case "5 días":
                    rutina.AppendLine("\nDistribución semanal: 5 días de entrenamiento y 2 días de descanso activo.");
                    break;

                case "6 días":
                    rutina.AppendLine("\nDistribución semanal: 6 días de entrenamiento y 1 día de descanso activo.");
                    break;
            }

            // Ajustar la rutina según el objetivo
            switch (objetivo)
            {
                case "Bajar de peso":
                    rutina.AppendLine("\nRecomendación adicional: Mantén una dieta baja en calorías y aumenta la intensidad del cardio.");
                    break;

                case "Ganar masa muscular":
                    rutina.AppendLine("\nRecomendación adicional: Consume proteínas suficientes y aumenta la carga en los ejercicios de fuerza.");
                    break;

                case "Mejorar resistencia":
                    rutina.AppendLine("\nRecomendación adicional: Incrementa gradualmente la duración y la intensidad de los ejercicios.");
                    break;

                case "Tonificar":
                    rutina.AppendLine("\nRecomendación adicional: Combina ejercicios de fuerza con cardio y mantén una dieta equilibrada.");
                    break;
            }

            return rutina.ToString();
        }
    }
}