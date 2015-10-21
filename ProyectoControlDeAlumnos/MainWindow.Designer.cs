namespace ProyectoControlDeAlumnos
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeControlDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeAlumnoToolStripMenuItem,
            this.consultaDeAlumnoToolStripMenuItem,
            this.quitarAplicaciónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeControlDeAlumnosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // altaDeAlumnoToolStripMenuItem
            // 
            this.altaDeAlumnoToolStripMenuItem.Image = global::ProyectoControlDeAlumnos.Properties.Resources.insertar;
            this.altaDeAlumnoToolStripMenuItem.Name = "altaDeAlumnoToolStripMenuItem";
            this.altaDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.altaDeAlumnoToolStripMenuItem.Text = "Alta de alumno";
            this.altaDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaDeAlumnoToolStripMenuItem_Click);
            // 
            // consultaDeAlumnoToolStripMenuItem
            // 
            this.consultaDeAlumnoToolStripMenuItem.Image = global::ProyectoControlDeAlumnos.Properties.Resources.navegar;
            this.consultaDeAlumnoToolStripMenuItem.Name = "consultaDeAlumnoToolStripMenuItem";
            this.consultaDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaDeAlumnoToolStripMenuItem.Text = "Consulta de alumno";
            this.consultaDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.consultaDeAlumnoToolStripMenuItem_Click);
            // 
            // quitarAplicaciónToolStripMenuItem
            // 
            this.quitarAplicaciónToolStripMenuItem.Image = global::ProyectoControlDeAlumnos.Properties.Resources.quitar;
            this.quitarAplicaciónToolStripMenuItem.Name = "quitarAplicaciónToolStripMenuItem";
            this.quitarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quitarAplicaciónToolStripMenuItem.Text = "Quitar aplicación";
            this.quitarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.quitarAplicaciónToolStripMenuItem_Click);
            // 
            // acercaDeControlDeAlumnosToolStripMenuItem
            // 
            this.acercaDeControlDeAlumnosToolStripMenuItem.Image = global::ProyectoControlDeAlumnos.Properties.Resources.nuevo;
            this.acercaDeControlDeAlumnosToolStripMenuItem.Name = "acercaDeControlDeAlumnosToolStripMenuItem";
            this.acercaDeControlDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.acercaDeControlDeAlumnosToolStripMenuItem.Text = "Acerca de Control de alumnos";
            this.acercaDeControlDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.acercaDeControlDeAlumnosToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeControlDeAlumnosToolStripMenuItem;
    }
}