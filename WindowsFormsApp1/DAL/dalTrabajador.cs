using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalTrabajador
    {
        public void insertarTrabajador(CTrabajador pTrabajador)
        {
            using (var bd = new EMPRESAEntities())
            {
                var per = new TRABAJADOR();
                per.id_tra = pTrabajador.idTraba;
                per.nombre = pTrabajador.nombre;
                per.apellido = pTrabajador.apellido;
                per.sueldo_b = pTrabajador.sueldo_p;
                per.categoria = pTrabajador.categoria;
                bd.TRABAJADOR.Add(per);
                bd.SaveChanges();
            }
        }

        public void actualizarTrabajador(CTrabajador pTrabajador)
        {
            using (var bd = new EMPRESAEntities())
            {
                var per = bd.TRABAJADOR.First(s => s.id_tra == pTrabajador.idTraba);
                per.nombre = pTrabajador.nombre;
                per.apellido = pTrabajador.apellido;
                per.sueldo_b = Convert.ToDecimal(pTrabajador.sueldo_p);
                per.categoria = pTrabajador.categoria;
                bd.SaveChanges();
            }
        }

        public void eliminarTrabajador(int id_traba)
        {
            using (var bd = new EMPRESAEntities())
            {
                var per = bd.TRABAJADOR.First(s => s.id_tra == id_traba);
                bd.TRABAJADOR.Remove(per);
                bd.SaveChanges();
            }
        }

        public CTrabajador seleccionarTrabajador(int id_traba)
        {
            using (var bd = new EMPRESAEntities())
            {
                var per = new CTrabajador();
                var pTrabajador = bd.TRABAJADOR.First(s => s.id_tra == id_traba);
                per.idTraba = pTrabajador.id_tra;
                per.nombre = pTrabajador.nombre;
                per.apellido = pTrabajador.apellido;
                per.sueldo_p = pTrabajador.sueldo_b;
                per.categoria = pTrabajador.categoria;
                return per;
            }
        }
    }
}
