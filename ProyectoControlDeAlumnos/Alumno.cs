using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoControlDeAlumnos
{
    public class Alumno
    {
        public Alumno(int id, string nombre, string apellido1, string apellido2,
            string email, DateTime fechaNacimiento, Genero sexo)
        {
            Id = id;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
        }

        public Alumno()
        {
            Id = -1;
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Email = "";
            FechaNacimiento = new DateTime();
            Sexo = Genero.Masculino;
        }

        public string ConvertToString()
        {
            return "Id:" + Id + "Nombre:" + Nombre + ",Apellido1:" + Apellido1
                + ",Apellido2:" + Apellido2 + ",Email:" + Email + ",FechaNacimiento:"
                + FechaNacimiento + ",Sexo:" + Sexo;
        }

        public string[] ConvertToArrayString()
        {
            string[] array = new string[7];
            array[0] = Id.ToString();
            array[1] = Nombre;
            array[2] = Apellido1;
            array[3] = Apellido2;
            array[4] = Email;
            array[5] = FechaNacimiento.ToString();
            array[6] = Sexo == Genero.Masculino ? "Masculino"
                : "Femenino";
            return array;
        }

        public enum Genero
        {
            Masculino,
            Femenino
        }

        public int Id
        {
            set;
            get;
        }

        public string Nombre
        {
            set;
            get;
        }

        public string Apellido1
        {
            set;
            get;
        }

        public string Apellido2
        {
            set;
            get;
        }

        public string Email
        {
            set;
            get;
        }

        public DateTime FechaNacimiento
        {
            set;
            get;
        }

        public Genero Sexo
        {
            set;
            get;
        }

        public Image Foto
        {
            set;
            get;
        }
    }
}
