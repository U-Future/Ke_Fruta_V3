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
    public partial class RegistrarSieCos : Form
    {
        public RegistrarSieCos()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarSec.Text.Length < 3)
            {
                MessageBox.Show("Complete el ID correctamente para continuar","Aviso");
                txtBuscarSec.Focus();
            }
            else
            {
                try
                {
                    Negocios.Sector sector = new Negocios.Sector();
                    sector.idSec = txtBuscarSec.Text;
                    sector.BuscarSector();

                    if (sector.ExisteSector == true)
                    {
                        txtBuscarSec.Enabled = false;
                        btnBuscar.Enabled = false;
                        gpboxFechas.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El sector no existe", "Aviso");
                        txtBuscarSec.Focus();
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string fechaSiembra, fechaCosecha, tipo = "";

            fechaSiembra = dtimepickerSiembra.Value.ToString("yyyy-MM-dd");
            fechaCosecha = dtimepickerCosecha.Value.ToString("yyyy-MM-dd");

            if (rdbtnCebada.Checked == true)
            {
                tipo = "Cebada";
            }
            else if (rdbtnTrigo.Checked == true)
            {
                tipo = "Trigo";
            }
            else if (rdbtnManzana.Checked == true)
            {
                tipo = "Manzana";
            }
            else if (rdbtnLimon.Checked == true)
            {
                tipo = "Limon";
            }
            else if (rdbtnNaranja.Checked == true)
            {
                tipo = "Naranja";
            }
            else if (rdbtnPapa.Checked == true)
            {
                tipo = "Papa Rosada";
            }
            else if (rdbtnZapallo.Checked == true)
            {
                tipo = "Zapallo Criollo";
            }

            try
            {
                Negocios.Sector sector = new Negocios.Sector();
                Negocios.SiembraCosecha siembracosecha = new Negocios.SiembraCosecha();
                siembracosecha.IdSec = txtBuscarSec.Text;
                siembracosecha.BuscarSiembraCosecha();
                if (siembracosecha.Existe == true)
                {
                    siembracosecha.IdSec = txtBuscarSec.Text;
                    siembracosecha.BuscarSiembraCosecha();

                    siembracosecha.FSie = fechaSiembra;
                    siembracosecha.FCos = fechaCosecha;
                    siembracosecha.Cultivo = tipo;
                    sector.Cultivo = tipo;
                    siembracosecha.ModificarSiembraCosecha();
                    sector.idSec = txtBuscarSec.Text;
                    sector.Actualizar();
                    MessageBox.Show("Se modifico correctamente la siembra y cosecha ya registrada", "Aviso");
                }
                else
                {
                    sector.idSec = txtBuscarSec.Text;
                    sector.BuscarSector();

                    siembracosecha.FSie = fechaSiembra;
                    siembracosecha.FCos = fechaCosecha;
                    siembracosecha.Cultivo = tipo;
                    siembracosecha.IdSec = txtBuscarSec.Text;
                    siembracosecha.IdPro = sector.idPro;
                    sector.Cultivo = tipo;
                    siembracosecha.RegistrarSiembraCosecha();
                    sector.idSec = txtBuscarSec.Text;
                    sector.Actualizar();
                    MessageBox.Show("Se registro correctamente la siembra y cosecha.", "Aviso");
                }
                gpboxFechas.Enabled = false;
                txtBuscarSec.Enabled = true;
                btnBuscar.Enabled = true;
                txtBuscarSec.Clear();
                txtBuscarSec.Focus();
            }
            catch
            {
                MessageBox.Show("Hubo problemas al registrar la siembra y cosecha", "Aviso");
                return;
            }
        }
        private void txtBuscarSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscarSec.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
            this.Hide();
        }
    }
}
