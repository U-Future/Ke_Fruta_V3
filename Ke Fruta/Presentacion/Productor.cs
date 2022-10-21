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
    public partial class Productor : Form
    {
        public Productor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Tienda tienda = new Compra.Tienda();
            tienda.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
      

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestionar.GestInsumos gestInsumos = new Gestionar.GestInsumos();
            gestInsumos.CargarInsumos();
            gestInsumos.Show();
            this.Hide();
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductorPersonas.MisDatos misDatos = new ProductorPersonas.MisDatos();
            misDatos.CargarMisDatos();
            misDatos.Show();
            this.Hide();

        }

        private void criteriosDeFertilizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestionar.GestFertilizacion gestFertilizacion = new Gestionar.GestFertilizacion();
            gestFertilizacion.Show();
            this.Hide();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.ProductorActividades.Vender vender = new Presentacion.ProductorActividades.Vender();
            vender.CargarMisInsumos();
            vender.Show();
            this.Hide();
        }

        private void tiendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ke_Fruta.Compra.Tienda tienda = new Compra.Tienda();
            tienda.Show();
            this.Hide();
        }
    }
}
