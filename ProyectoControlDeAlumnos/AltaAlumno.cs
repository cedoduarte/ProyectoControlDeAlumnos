using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProyectoControlDeAlumnos
{
    public partial class AltaAlumno : Form
    {
        public AltaAlumno(List<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            MinimumSize = Size;
        }

        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            Text = "Alta de alumno";
            CenterToScreen();
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo ix in captureDevice)
            {
                deviceComboBox.Items.Add(ix.Name);
            }
            deviceComboBox.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();

            string[] sexos = { "Masculino", "Femenino" };
            foreach (var sexo in sexos)
            {
                sexoComboBox.Items.Add(sexo);
            }
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var alumno = new Alumno(Convert.ToInt32(idTextBox.Text), nombreTextBox.Text, apellido1TextBox.Text,
                    apellido2TextBox.Text, emailTextBox.Text, fechaNacimientoDateTimePicker.Value,
                    sexoComboBox.SelectedIndex == 0 ? Alumno.Genero.Masculino
                    : Alumno.Genero.Femenino);
                alumno.Foto = fotoPictureBox.Image;
                if (alumno.Nombre.Equals("")
                    || alumno.Apellido1.Equals("")
                    || alumno.Apellido2.Equals("")
                    || alumno.Email.Equals("")
                    || sexoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("No debe haber campos vacíos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                alumnos.Add(alumno);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }
                
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void examinarButton_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "Imagen PNG|*.png|Imagen JPG|*.jpg|All files (*.*)|*.*";
            d.Title = "Abrir imagen";
            if (d.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var nombreArchivo = d.FileName;
            if (nombreArchivo.Length == 0)
            {
                return;
            }
            fotoPictureBox.Image = Image.FromFile(nombreArchivo);
            fotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void iniciarCamaraButton_Click(object sender, EventArgs e)
        {
            finalFrame = new VideoCaptureDevice(captureDevice[deviceComboBox.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(finalFrame_NewFrame);
            finalFrame.Start();
        }

        void finalFrame_NewFrame(object sender, NewFrameEventArgs e)
        {
            camaraPictureBox.Image = (Bitmap) e.Frame.Clone();
        }

        private void tomarFotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                fotoPictureBox.Image = (Bitmap)camaraPictureBox.Image.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de cámara");
            }
        }

        private void AltaAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finalFrame.IsRunning)
            {
                finalFrame.Stop();
            }
        }

        private List<Alumno> alumnos;
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice finalFrame;
    }
}
