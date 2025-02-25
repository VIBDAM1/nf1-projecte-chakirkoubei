namespace Chakir_Prototipo
{
    partial class Planifiacion_Entrenamientos
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, planificacionEntrenamientosToolStripMenuItem, seguimientoActividadToolStripMenuItem, nutricionToolStripMenuItem, ayudaToolStripMenuItem, contactoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
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
            planificacionEntrenamientosToolStripMenuItem.ForeColor = SystemColors.Highlight;
            planificacionEntrenamientosToolStripMenuItem.Name = "planificacionEntrenamientosToolStripMenuItem";
            planificacionEntrenamientosToolStripMenuItem.Size = new Size(173, 20);
            planificacionEntrenamientosToolStripMenuItem.Text = "Planificacion Entrenamientos";
            // 
            // seguimientoActividadToolStripMenuItem
            // 
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
            ayudaToolStripMenuItem.Size = new Size(68, 20);
            ayudaToolStripMenuItem.Text = "Contacto";
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(12, 20);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de entreno" });
            comboBox1.Location = new Point(94, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 63);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 3;
            label1.Text = "Selecciona tipo de entrenamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 63);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 5;
            label2.Text = "Cuantos dias quieres entrenar";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de entreno" });
            comboBox2.Location = new Point(329, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 63);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Objetivo";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Tipo de entreno" });
            comboBox3.Location = new Point(567, 92);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 173);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 9;
            label4.Text = "Rutina recomendada";
            // 
            // button1
            // 
            button1.Location = new Point(352, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(431, 121);
            textBox1.TabIndex = 11;
            // 
            // Planifiacion_Entrenamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            Name = "Planifiacion_Entrenamientos";
            Text = "Planifiacion_Entrenamientos";
            Load += Planifiacion_Entrenamientos_Load;
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
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
    }
}