using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta
{
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta.Ventas ventas = new Venta.Ventas();
            ventas.Show();
            this.Hide();
        }

        private void aBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC abmc = new ABMC();
            abmc.Show();
            this.Hide();
        }

        private void registrarSiembraYCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion.RegistrarSieCos registrarSieCos = new Gestion.RegistrarSieCos();
            registrarSieCos.Show();
            this.Hide();
        }

        private void consultarSiembraOCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion.ConSiembra_Cosecha conSiembra_Cosecha = new Gestion.ConSiembra_Cosecha();
            conSiembra_Cosecha.Show();
            this.Hide();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Gestionar.AgregarProductos agregarProductos = new Presentacion.Gestionar.AgregarProductos();
            agregarProductos.Show();
            this.Hide();
        }
    }
}
