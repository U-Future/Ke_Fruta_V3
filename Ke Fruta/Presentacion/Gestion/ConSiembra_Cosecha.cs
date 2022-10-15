using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Gestion
{
    public partial class ConSiembra_Cosecha : Form
    {
        public ConSiembra_Cosecha()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //dataViewConSieCos.Rows.Clear();
            //dataViewConSieCos.Columns.Clear();

            dataViewConSieCos.DataSource = null;

            if (rdbtnSector.Checked == true)
            {
                if (txtBuscar.Text.Length < 7)
                {
                    MessageBox.Show("La cantidad minima de digitos en una ID es de 7 digitos, " +
                        "completelos para continar.", "Aviso");
                    txtBuscar.Focus();
                }
                else
                {
                    Negocios.SiembraCosecha siembraCosecha = new Negocios.SiembraCosecha();
                    siembraCosecha.IdSec = txtBuscar.Text;
                    siembraCosecha.ConsultarSiembraID();
                    if (siembraCosecha.Existe == true)
                    {
                        dataViewConSieCos.DataSource = siembraCosecha.dt;
                        txtBuscar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una siembra ni cosecha para este Sector", "Aviso");
                        txtBuscar.Focus();
                    }
                }
            }
            else if (rdbtnUsuario.Checked == true)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("Complete el campo de ID", "Aviso");
                    txtBuscar.Focus();
                }
                else
                {
                    Negocios.SiembraCosecha siembraCosecha = new Negocios.SiembraCosecha();
                    siembraCosecha.IdPro = txtBuscar.Text;
                    siembraCosecha.ConsultarSiembraIDPro();
                    if (siembraCosecha.Existe == true)
                    {
                        dataViewConSieCos.DataSource = siembraCosecha.dt;
                        txtBuscar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No exite ninguna siembra ni cosecha para este usuario", "Aviso");
                        txtBuscar.Focus();
                    }

                }
            }
            
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
            this.Hide();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
