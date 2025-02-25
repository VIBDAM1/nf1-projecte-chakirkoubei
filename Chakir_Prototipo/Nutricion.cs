using System;
using System.Text;
using System.Windows.Forms;

namespace Chakir_Prototipo
{
    public partial class Nutricion : Form
    {
        public Nutricion()
        {
            InitializeComponent();
            this.Load += new EventHandler(Nutricion_Load);
            button1.Click += new EventHandler(button1_Click_1);
        }

        private void Nutricion_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox1 con objetivos
            comboBox1.Items.AddRange(new string[] { "Bajar de peso", "Ganar masa muscular", "Mejorar resistencia", "Tonificar" });

            // Llenar ComboBox2 con niveles de actividad física
            comboBox2.Items.AddRange(new string[] { "Sedentario", "Ligero", "Moderado", "Activo", "Muy activo" });

            // Llenar ComboBox3 con días de entrenamiento
            comboBox3.Items.AddRange(new string[] { "2 días", "3 días", "4 días", "5 días", "6 días" });

            // Llenar ComboBox4 con tipos de dieta
            comboBox4.Items.AddRange(new string[] { "Vegano", "Vegetariano", "Pescatariano", "Omnívoro" });
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedItem == null || comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los TextBox
            string altura = textBox1.Text;
            string peso = textBox2.Text;
            string sexo = textBox3.Text;
            string edad = textBox4.Text;

            // Obtener las selecciones de los ComboBox
            string objetivo = comboBox1.SelectedItem.ToString();
            string actividadFisica = comboBox2.SelectedItem.ToString();
            string diasEntrenamiento = comboBox3.SelectedItem.ToString();
            string tipoDieta = comboBox4.SelectedItem.ToString();

            // Generar la dieta recomendada basada en los valores
            string dietaRecomendada = GenerarDietaRecomendada(altura, peso, sexo, edad, objetivo, actividadFisica, diasEntrenamiento, tipoDieta);

            // Mostrar la dieta recomendada en el TextBox5
            textBox5.Text = dietaRecomendada;
       
        }
        // Evento para el botón que genera la dieta recomendada
        private void button1_Click(object sender, EventArgs e)
        { }


        private string GenerarDietaRecomendada(string altura, string peso, string sexo, string edad, string objetivo, string actividadFisica, string diasEntrenamiento, string tipoDieta)
        {
            StringBuilder dietaRecomendada = new StringBuilder();

            // Encabezado de la dieta
            dietaRecomendada.AppendLine($"Dieta recomendada para:");
            dietaRecomendada.AppendLine($"- Altura: {altura} cm");
            dietaRecomendada.AppendLine($"- Peso: {peso} kg");
            dietaRecomendada.AppendLine($"- Sexo: {sexo}");
            dietaRecomendada.AppendLine($"- Edad: {edad} años");
            dietaRecomendada.AppendLine($"- Objetivo: {objetivo}");
            dietaRecomendada.AppendLine($"- Actividad física: {actividadFisica}");
            dietaRecomendada.AppendLine($"- Días de entrenamiento: {diasEntrenamiento}");
            dietaRecomendada.AppendLine($"- Tipo de dieta: {tipoDieta}");
            dietaRecomendada.AppendLine();

            // Recomendaciones basadas en el objetivo
            switch (objetivo)
            {
                case "Bajar de peso":
                    dietaRecomendada.AppendLine("Recomendaciones para bajar de peso:");
                    dietaRecomendada.AppendLine("- Reduce la ingesta de calorías.");
                    dietaRecomendada.AppendLine("- Aumenta el consumo de proteínas magras y vegetales.");
                    dietaRecomendada.AppendLine("- Evita alimentos procesados y azúcares refinados.");
                    break;

                case "Ganar masa muscular":
                    dietaRecomendada.AppendLine("Recomendaciones para ganar masa muscular:");
                    dietaRecomendada.AppendLine("- Aumenta la ingesta de proteínas (carnes, huevos, legumbres).");
                    dietaRecomendada.AppendLine("- Consume carbohidratos complejos (arroz integral, quinoa, avena).");
                    dietaRecomendada.AppendLine("- Incluye grasas saludables (aguacate, frutos secos, aceite de oliva).");
                    break;

                case "Mejorar resistencia":
                    dietaRecomendada.AppendLine("Recomendaciones para mejorar resistencia:");
                    dietaRecomendada.AppendLine("- Consume carbohidratos de liberación lenta (pasta integral, batata).");
                    dietaRecomendada.AppendLine("- Mantén una hidratación adecuada.");
                    dietaRecomendada.AppendLine("- Incluye proteínas para la recuperación muscular.");
                    break;

                case "Tonificar":
                    dietaRecomendada.AppendLine("Recomendaciones para tonificar:");
                    dietaRecomendada.AppendLine("- Combina proteínas magras con carbohidratos moderados.");
                    dietaRecomendada.AppendLine("- Incluye grasas saludables y vegetales en cada comida.");
                    dietaRecomendada.AppendLine("- Evita excesos de azúcar y alimentos procesados.");
                    break;
            }

            // Ajustar la dieta según el tipo de dieta seleccionado
            switch (tipoDieta)
            {
                case "Vegano":
                    dietaRecomendada.AppendLine("\nRecomendaciones para dieta vegana:");
                    dietaRecomendada.AppendLine("- Consume legumbres, tofu, tempeh y seitán como fuentes de proteína.");
                    dietaRecomendada.AppendLine("- Incluye frutos secos, semillas y aguacate para grasas saludables.");
                    dietaRecomendada.AppendLine("- Asegúrate de obtener suficiente vitamina B12 y hierro.");
                    break;

                case "Vegetariano":
                    dietaRecomendada.AppendLine("\nRecomendaciones para dieta vegetariana:");
                    dietaRecomendada.AppendLine("- Incluye huevos y lácteos como fuentes de proteína.");
                    dietaRecomendada.AppendLine("- Consume legumbres, quinoa y frutos secos.");
                    dietaRecomendada.AppendLine("- Asegúrate de obtener suficiente hierro y omega-3.");
                    break;

                case "Pescatariano":
                    dietaRecomendada.AppendLine("\nRecomendaciones para dieta pescatariana:");
                    dietaRecomendada.AppendLine("- Incluye pescado y mariscos como fuentes de proteína.");
                    dietaRecomendada.AppendLine("- Consume vegetales, legumbres y cereales integrales.");
                    dietaRecomendada.AppendLine("- Asegúrate de obtener suficiente omega-3 y vitamina D.");
                    break;

                case "Omnívoro":
                    dietaRecomendada.AppendLine("\nRecomendaciones para dieta omnívora:");
                    dietaRecomendada.AppendLine("- Incluye carnes magras, pescado, huevos y lácteos.");
                    dietaRecomendada.AppendLine("- Consume una variedad de vegetales, frutas y cereales integrales.");
                    dietaRecomendada.AppendLine("- Limita el consumo de carnes rojas y alimentos procesados.");
                    break;
            }

            return dietaRecomendada.ToString();
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
            // No es necesario hacer nada, ya estamos en este formulario
        }

        // Evento para el menú "Ayuda"
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de ayuda
            Contacto ayudaForm = new Contacto();
            ayudaForm.Show();  // Muestra el formulario
            this.Hide();       // Oculta el formulario actual (opcional)
        }

        
    }
}