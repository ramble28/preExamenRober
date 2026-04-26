using simulacroExamen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace preExamenRober
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerAlumnos();
            LeerTalleres();
        }

        private void LeerAlumnos()
        {
            string fileName = "Alumnos.txt";
            if (!File.Exists(fileName)) return;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.Peek() > -1)
                {
                    Alumno leeralumno = new Alumno();
                    leeralumno.Dpi = reader.ReadLine();
                    leeralumno.Nombre = reader.ReadLine();
                    leeralumno.Direccion = reader.ReadLine();
                    alumnos.Add(leeralumno);
                }
            }
        }

        private void LeerTalleres()
        {
            string fileName = "Talleres.txt";
            if (!File.Exists(fileName)) return;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.Peek() > -1)
                {
                    Taller leertaller = new Taller();
                    leertaller.Codigo = reader.ReadLine();
                    leertaller.Nombretaller = reader.ReadLine();
                    string costoStr = reader.ReadLine();
                    if (!string.IsNullOrEmpty(costoStr))
                        leertaller.Costo = Convert.ToDecimal(costoStr);
                    talleres.Add(leertaller);
                }
            }
        }

        public void GuardarInscripcion()
        {
            using (StreamWriter writer = new StreamWriter("Inscripciones.txt", false))
            {
                foreach (var item in inscripciones)
                {
                    writer.WriteLine(item.Dpiestudiante);
                    writer.WriteLine(item.Codigotaller);
                    writer.WriteLine(item.Fechainscripcion);
                }
            }
        }

        private void buttonAbrirInscripciones_Click(object sender, EventArgs e)
        {
            FormInscripciones form = new FormInscripciones(this, alumnos, talleres, inscripciones);
            form.Show();
        }

        private void buttonAbrirReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes(inscripciones, alumnos, talleres);
            form.Show();
        }
    }
}
