using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CTrabajador
    {
        public int idTraba { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal sueldo_p { get; set; }
        public string categoria { get; set; }

        public override string ToString()
        {
            return string.Format("Trabajador (idTraba={0}, Nombre={1}, Apellido={2}, Sueldo={3}, Categoría={4})",
                                  idTraba, nombre, apellido, sueldo_p, categoria);
        }
    }
}
