using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.ProductorPersonas
{
    public partial class MisDatos : Form
    {
        public MisDatos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.Show();
            this.Hide();
        }
        public void CargarMisDatos()
        {
            try
            {
                Negocios.Usuario usuario = new Negocios.Usuario();
                usuario.BuscarDatosProductor();
                usuario.BuscarSectoresProductor();
                usuario.BuscarTelefonosProductor();

                txtID.Text = usuario.id;
                txtEmail.Text = usuario.email;
                txtNom.Text = usuario.nombre;
                txtRut.Text = usuario.rut;
                txtTipo.Text = usuario.tipoCultivo;

                foreach (string tel in usuario.telefonos)
                {
                    int rowEscribir = dataViewTelefonos.Rows.Count - 1;
                    dataViewTelefonos.Rows.Add(1);
                    dataViewTelefonos.Rows[rowEscribir].Cells[0].Value = tel;
                }
                foreach (string sec in usuario.sector)
                {
                    int rowEscribir = dataViewSectores.Rows.Count - 1;
                    dataViewSectores.Rows.Add(1);
                    dataViewSectores.Rows[rowEscribir].Cells[0].Value = sec;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
