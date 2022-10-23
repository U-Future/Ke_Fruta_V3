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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
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
                    try
                    {
                        Negocios.Metodos metodos = new Negocios.Metodos();
                        Negocios.Gestiona gestiona = new Negocios.Gestiona();
                        Negocios.Usuario usuario = new Negocios.Usuario();
                        Negocios.SiembraCosecha siembraCosecha = new Negocios.SiembraCosecha();
                        siembraCosecha.IdSec = txtBuscar.Text;
                        siembraCosecha.ConsultarSiembraID();
                        if (siembraCosecha.Existe == true)
                        {
                            dataViewConSieCos.DataSource = siembraCosecha.dt;
                            usuario.nombre = metodos.nombre;
                            usuario.BusquedaXNombre();
                            gestiona.IdAdm = Convert.ToInt32(usuario.id);
                            gestiona.IdPro = Convert.ToInt32(siembraCosecha.IdPro);
                            gestiona.IdSec = Convert.ToString(txtBuscar.Text);
                            gestiona.RegistrarGestion();
                            txtBuscar.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro una siembra ni cosecha para este Sector", "Aviso");
                            txtBuscar.Focus();
                        }
                    }
                    catch
                    {
                        return;
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
                    try
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
                    catch
                    {
                        return;
                    }
                }
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
