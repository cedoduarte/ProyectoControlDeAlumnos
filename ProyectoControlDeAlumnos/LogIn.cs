using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoControlDeAlumnos
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Text = "Ingresar al sistema";
            CenterToScreen();
            MinimumSize = Size;
            MaximumSize = Size;
            usuarioComboBox.Items.Add("cedo");
            usuarioComboBox.SelectedIndex = 0;
            contrasenyaTextBox.UseSystemPasswordChar = true;
            contrasenyaTextBox.Text = "cedo";
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            string usuario = usuarioComboBox.Text;
            string contrasenya = contrasenyaTextBox.Text;
            if (!(usuario.Equals("cedo") && contrasenya.Equals("cedo")))
            {
                MessageBox.Show("Error de acceso", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var mainWindow = new MainWindow(this);
            mainWindow.Show();
            Hide();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
