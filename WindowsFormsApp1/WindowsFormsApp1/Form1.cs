using comun;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            var dalT = new dalTrabajador();
            var perComun = dalT.seleccionarTrabajador((int)txtIdTraba.Value);
            txtCategoria.Text = perComun.categoria;
            txtSueldo.Text = perComun.sueldo_p.ToString();
            txtApellido.Text = perComun.apellido;
            txtNombre.Text = perComun.nombre;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var perComun = new CTrabajador();
            var dalT = new dalTrabajador();
            perComun.idTraba = (int)txtIdTraba.Value;
            perComun.nombre = txtNombre.Text;
            perComun.apellido = txtApellido.Text;
            perComun.sueldo_p = Convert.ToDecimal(txtSueldo.Text);
            perComun.categoria = txtCategoria.Text;

            MessageBox.Show(perComun.ToString());
            dalT.insertarTrabajador(perComun);
        }

        private void update_Click(object sender, EventArgs e)
        {
            var perComun = new CTrabajador();
            var dalT = new dalTrabajador();
            perComun.idTraba = (int)txtIdTraba.Value;
            perComun.nombre = txtNombre.Text;
            perComun.apellido = txtApellido.Text;
            perComun.sueldo_p = Convert.ToDecimal(txtSueldo.Text);

            MessageBox.Show(perComun.ToString());
            dalT.actualizarTrabajador(perComun);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var dalCli = new dalTrabajador();
            dalCli.eliminarTrabajador((int)txtIdTraba.Value);
        }
    }
}
