namespace ProyectoControlDeAlumnos
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contrasenyaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // contrasenyaTextBox
            // 
            this.contrasenyaTextBox.Location = new System.Drawing.Point(79, 37);
            this.contrasenyaTextBox.Name = "contrasenyaTextBox";
            this.contrasenyaTextBox.Size = new System.Drawing.Size(193, 20);
            this.contrasenyaTextBox.TabIndex = 4;
            // 
            // usuarioComboBox
            // 
            this.usuarioComboBox.FormattingEnabled = true;
            this.usuarioComboBox.Location = new System.Drawing.Point(79, 6);
            this.usuarioComboBox.Name = "usuarioComboBox";
            this.usuarioComboBox.Size = new System.Drawing.Size(193, 21);
            this.usuarioComboBox.TabIndex = 5;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Image = global::ProyectoControlDeAlumnos.Properties.Resources.aceptar;
            this.aceptarButton.Location = new System.Drawing.Point(214, 63);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(25, 24);
            this.aceptarButton.TabIndex = 2;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::ProyectoControlDeAlumnos.Properties.Resources.cancelar;
            this.cancelarButton.Location = new System.Drawing.Point(245, 63);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(27, 24);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 92);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.usuarioComboBox);
            this.Controls.Add(this.contrasenyaTextBox);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.TextBox contrasenyaTextBox;
        private System.Windows.Forms.ComboBox usuarioComboBox;
        private System.Windows.Forms.Button cancelarButton;
    }
}