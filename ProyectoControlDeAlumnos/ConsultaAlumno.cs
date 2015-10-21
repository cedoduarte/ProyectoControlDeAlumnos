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
    public partial class ConsultaAlumno : Form
    {
        public ConsultaAlumno(List<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            MinimumSize = Size;
        }

        private void ConsultaAlumno_Load(object sender, EventArgs e)
        {
            Text = "Consulta de alumno";
            CenterToScreen();
            string[] columnsTitles = { "Id", "Nombre", "Apellido1",
                                     "Apellido2", "Email",
                                     "Fecha de nacimiento",
                                     "Sexo" };
            dataGridView1.ColumnCount = 7;
            for (int ix = 0; ix < columnsTitles.Length; ++ix)
            {
                dataGridView1.Columns[ix].Name = columnsTitles[ix];
            }
            for (int ix = 0; ix < alumnos.Count; ++ix)
            {
                dataGridView1.Rows.Add(alumnos[ix].ConvertToArrayString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            foreach (var ix in alumnos)
            {
                if (ix.Id == id)
                {
                    fotoPictureBox.Image = ix.Foto;
                    fotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
                }
            }
        }

        private List<Alumno> alumnos;
    }
}
