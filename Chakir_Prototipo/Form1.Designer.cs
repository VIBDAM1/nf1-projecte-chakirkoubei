namespace Chakir_Prototipo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            planificacionEntrenamientosToolStripMenuItem = new ToolStripMenuItem();
            seguimientoActividadToolStripMenuItem = new ToolStripMenuItem();
            nutricionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.125F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5121956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.49864F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.98916F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 21F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 310);
            label1.Name = "label1";
            label1.Size = new Size(276, 59);
            label1.TabIndex = 3;
            label1.Text = "Supera tu limites";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, planificacionEntrenamientosToolStripMenuItem, seguimientoActividadToolStripMenuItem, nutricionToolStripMenuItem, ayudaToolStripMenuItem, contactoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 369);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(245, 24);
            menuStrip1.TabIndex = 4;
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
            ayudaToolStripMenuItem.Size = new Size(60, 20);
            ayudaToolStripMenuItem.Text = "Soporte";
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(68, 20);
            contactoToolStripMenuItem.Text = "Contacto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem planificacionEntrenamientosToolStripMenuItem;
        private ToolStripMenuItem seguimientoActividadToolStripMenuItem;
        private ToolStripMenuItem nutricionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
    }
}