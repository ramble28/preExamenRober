using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using simulacroExamen;

namespace preExamenRober
{
    public partial class FormReportes : Form
    {
        List<Inscripcion> inscripciones;
        List<Reporte> reportes = new List<Reporte>();
        List<Alumno> alumnos;
        List<Taller> talleres;

        public FormReportes(List<Inscripcion> inscripciones, List<Alumno> alumnos, List<Taller> talleres)
        {
            InitializeComponent();
            this.inscripciones = inscripciones;
            this.alumnos = alumnos;
            this.talleres = talleres;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            reportes.Clear();
            foreach (var item in inscripciones)
            {
                Reporte reporte = new Reporte();
                // Buscamos los nombres reales basados en los IDs para el reporte
                var alumno = alumnos.FirstOrDefault(a => a.Dpi == item.Dpiestudiante);
                var taller = talleres.FirstOrDefault(t => t.Codigo == item.Codigotaller);
                
                reporte.Nombre = alumno != null ? alumno.Nombre : item.Dpiestudiante;
                reporte.Taller = taller != null ? taller.Nombretaller : item.Codigotaller;
                reportes.Add(reporte);
            }
            dataGridView1.DataSource = reportes;
        }

        private void buttoncCantidad_Click(object sender, EventArgs e)
        {
            int total = inscripciones.Count;
            MessageBox.Show("Total de estudiantes inscritos: " + total);
        }

        private void buttonOrdenar_Click_1(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(c => c.Taller).ToList();
            dataGridView1.DataSource = reportes;
        }
    }
}
