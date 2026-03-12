using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroExamen
{
    internal class Inscripcion
    {
        string dpiestudiante;
        string codigotaller;
        DateTime fechainscripcion;

        public string Dpiestudiante { get => dpiestudiante; set => dpiestudiante = value; }
        public string Codigotaller { get => codigotaller; set => codigotaller = value; }
        public DateTime Fechainscripcion { get => fechainscripcion; set => fechainscripcion = value; }
    }
}
