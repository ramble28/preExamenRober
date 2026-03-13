using simulacroExamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preExamenRober
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
            LeerAlumnos();
            LeerTalleres();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerAlumnos();
            LeerTalleres();

        }
        private void LeerAlumnos()
        {

            string fileName = "Alumnos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);



            while (reader.Peek() > -1)

            {
                Alumno leeralumno = new Alumno();
                leeralumno.Dpi = reader.ReadLine();
                leeralumno.Nombre = reader.ReadLine();
                leeralumno.Direccion = reader.ReadLine();


                alumnos.Add(leeralumno);


            }
            reader.Close();
            comboBoxEstudiante.ValueMember = "Nombre";
            comboBoxEstudiante.SelectedValue = "Dpi";
            comboBoxEstudiante.DataSource = alumnos;



        }

        private void LeerTalleres()
        {

            string fileName = "Talleres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);



            while (reader.Peek() > -1)

            {
                Taller leertaller = new Taller();
                leertaller.Codigo = reader.ReadLine();
                leertaller.Nombretaller = reader.ReadLine();
                leertaller.Costo = Convert.ToInt16(reader.ReadLine());



                talleres.Add(leertaller);
            }
            reader.Close();
            comboBoxTaller.ValueMember = "Nombretaller";
            comboBoxTaller.SelectedValue = "Codigo";
            comboBoxTaller.DataSource = talleres;



        }

        private void GuardarInscripcion()
        {
            FileStream stream = new FileStream("Inscripciones.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in inscripciones)
            {
                writer.WriteLine(item.Dpiestudiante);
                writer.WriteLine(item.Codigotaller);
                writer.WriteLine(item.Fechainscripcion);
            }
            writer.Close();
        }





        private void buttonIngreso_Click_1(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Dpiestudiante = comboBoxEstudiante.SelectedValue.ToString();
            inscripcion.Codigotaller = comboBoxTaller.SelectedValue.ToString();
            inscripcion.Fechainscripcion = DateTime.Now;
            inscripciones.Add(inscripcion);
            GuardarInscripcion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Reporte reporte = new Reporte();
            foreach (var item in inscripciones)
            {
                reporte.Nombre = comboBoxEstudiante.SelectedValue.ToString();
                reporte.Taller = comboBoxTaller.SelectedValue.ToString();
                reportes.Add(reporte);

            }
            dataGridView1.DataSource = reportes;
        }

        private void buttoncCantidad_Click(object sender, EventArgs e)
        {
            int total = inscripciones.Count;
            MessageBox.Show("Total de estudiantes inscritos" + total);
        }

        private void buttonOrdenar_Click_1(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(c => c.Taller).ToList();
            dataGridView1.DataSource = reportes;

        }
    }
}
