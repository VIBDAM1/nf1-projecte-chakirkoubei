## Snippet de Seguimiento de Actividad

```csharp
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
