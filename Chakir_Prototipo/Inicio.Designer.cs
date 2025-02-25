namespace Chakir_Prototipo
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            planificacionEntrenamientosToolStripMenuItem = new ToolStripMenuItem();
            seguimientoActividadToolStripMenuItem = new ToolStripMenuItem();
            nutricionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, planificacionEntrenamientosToolStripMenuItem, seguimientoActividadToolStripMenuItem, nutricionToolStripMenuItem, ayudaToolStripMenuItem, contactoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = SystemColors.Desktop;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // planificacionEntrenamientosToolStripMenuItem
            // 
            planificacionEntrenamientosToolStripMenuItem.Name = "planificacionEntrenamientosToolStripMenuItem";
            planificacionEntrenamientosToolStripMenuItem.Size = new Size(173, 20);
            planificacionEntrenamientosToolStripMenuItem.Text = "Planificacion Entrenamientos";
            planificacionEntrenamientosToolStripMenuItem.Click += planificacionEntrenamientosToolStripMenuItem_Click;
            // 
            // seguimientoActividadToolStripMenuItem
            // 
            seguimientoActividadToolStripMenuItem.Name = "seguimientoActividadToolStripMenuItem";
            seguimientoActividadToolStripMenuItem.Size = new Size(139, 20);
            seguimientoActividadToolStripMenuItem.Text = "Seguimiento Actividad";
            seguimientoActividadToolStripMenuItem.Click += seguimientoActividadToolStripMenuItem_Click;
            // 
            // nutricionToolStripMenuItem
            // 
            nutricionToolStripMenuItem.Name = "nutricionToolStripMenuItem";
            nutricionToolStripMenuItem.Size = new Size(69, 20);
            nutricionToolStripMenuItem.Text = "Nutricion";
            nutricionToolStripMenuItem.Click += nutricionToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(68, 20);
            ayudaToolStripMenuItem.Text = "Contacto";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(12, 20);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 334);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 2;
            label1.Text = "Supera tu limites";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}
