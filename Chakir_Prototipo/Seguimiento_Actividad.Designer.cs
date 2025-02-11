namespace Chakir_Prototipo
{
    partial class Seguimiento_Actividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            planificacionEntrenamientosToolStripMenuItem = new ToolStripMenuItem();
            seguimientoActividadToolStripMenuItem = new ToolStripMenuItem();
            nutricionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, planificacionEntrenamientosToolStripMenuItem, seguimientoActividadToolStripMenuItem, nutricionToolStripMenuItem, ayudaToolStripMenuItem, contactoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // planificacionEntrenamientosToolStripMenuItem
            // 
            planificacionEntrenamientosToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            planificacionEntrenamientosToolStripMenuItem.Name = "planificacionEntrenamientosToolStripMenuItem";
            planificacionEntrenamientosToolStripMenuItem.Size = new Size(173, 20);
            planificacionEntrenamientosToolStripMenuItem.Text = "Planificacion Entrenamientos";
            // 
            // seguimientoActividadToolStripMenuItem
            // 
            seguimientoActividadToolStripMenuItem.ForeColor = SystemColors.Highlight;
            seguimientoActividadToolStripMenuItem.Name = "seguimientoActividadToolStripMenuItem";
            seguimientoActividadToolStripMenuItem.Size = new Size(139, 20);
            seguimientoActividadToolStripMenuItem.Text = "Seguimiento Actividad";
            // 
            // nutricionToolStripMenuItem
            // 
            nutricionToolStripMenuItem.Name = "nutricionToolStripMenuItem";
            nutricionToolStripMenuItem.Size = new Size(69, 20);
            nutricionToolStripMenuItem.Text = "Nutricion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(60, 20);
            ayudaToolStripMenuItem.Text = "Soporte";
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(68, 20);
            contactoToolStripMenuItem.Text = "Contacto";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(129, 154);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(548, 23);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 99);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 4;
            label1.Text = "¡Llevas esto de tu entrenamiento sigue asi!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 136);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 5;
            label2.Text = "X%";
            // 
            // Seguimiento_Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(menuStrip1);
            Name = "Seguimiento_Actividad";
            Text = "Seguimiento_Actividad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem planificacionEntrenamientosToolStripMenuItem;
        private ToolStripMenuItem seguimientoActividadToolStripMenuItem;
        private ToolStripMenuItem nutricionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
    }
}