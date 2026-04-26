using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroExamen
{
    public class Taller
    {
        string codigo;
        string nombretaller;
        decimal costo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombretaller { get => nombretaller; set => nombretaller = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}
