using System;
using System.Collections.Generic;
using System.Windows.Forms;
using simulacroExamen;

namespace preExamenRober
{
    public partial class FormInscripciones : Form
    {
        List<Alumno> alumnos;
        List<Taller> talleres;
        List<Inscripcion> inscripciones;
        Form1 mainForm;

        public FormInscripciones(Form1 mainForm, List<Alumno> alumnos, List<Taller> talleres, List<Inscripcion> inscripciones)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.alumnos = alumnos;
            this.talleres = talleres;
            this.inscripciones = inscripciones;
        }

        private void FormInscripciones_Load(object sender, EventArgs e)
        {
            comboBoxEstudiante.DataSource = alumnos;
            comboBoxEstudiante.DisplayMember = "Nombre";
            comboBoxEstudiante.ValueMember = "Dpi";

            comboBoxTaller.DataSource = talleres;
            comboBoxTaller.DisplayMember = "Nombretaller";
            comboBoxTaller.ValueMember = "Codigo";
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Dpiestudiante = comboBoxEstudiante.SelectedValue.ToString();
            inscripcion.Codigotaller = comboBoxTaller.SelectedValue.ToString();
            inscripcion.Fechainscripcion = DateTime.Now;
            inscripciones.Add(inscripcion);
            mainForm.GuardarInscripcion();
            MessageBox.Show("Inscripción guardada correctamente");
        }
    }
}
