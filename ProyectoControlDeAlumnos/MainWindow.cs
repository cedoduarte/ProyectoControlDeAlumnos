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
    public partial class MainWindow : Form
    {
        public MainWindow(LogIn parent)
        {
            InitializeComponent();
            logInParent = parent;
            alumnos = new List<Alumno>();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = "Control de alumnos";
            CenterToScreen();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            logInParent.Close();
        }
        
        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaAlumno = new AltaAlumno(alumnos);
            altaAlumno.Show();
        }

        private void consultaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultaAlumno = new ConsultaAlumno(alumnos);
            consultaAlumno.Show();
        }

        private void quitarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void acercaDeControlDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Carlos Enrique Duarte Ortiz",
                            "Acerca de Control de alumnos");
        }
        
        private LogIn logInParent;
        private List<Alumno> alumnos;
    }
}
