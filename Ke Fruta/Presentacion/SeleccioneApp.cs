using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Presentacion
{
    public partial class SeleccioneApp : Form
    {
        public SeleccioneApp()
        {
            InitializeComponent();
        }
      

        private void btnProductor_Click_1(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.Show();
            this.Dispose();
        }

        private void btnTienda_Click_1(object sender, EventArgs e)
        {
            Compra.Tienda tienda = new Compra.Tienda();
            tienda.Show();
            this.Dispose();

            //this.Hide();
        }
    }
}
