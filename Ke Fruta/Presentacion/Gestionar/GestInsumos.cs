using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Gestionar
{
    public partial class GestInsumos : Form
    {
        public GestInsumos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.Show();
            this.Hide();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMisInsumos_Click(object sender, EventArgs e)
        {
            CargarInsumos();
        }

        private void txtKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtKg.MaxLength = 5;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidad.MaxLength = 10;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Agregar();
        }

        private void btnAgrMiPro_Click(object sender, EventArgs e)
        {
            pnlAgrMiPro.Visible = true;
            pnlAdd.Visible = false;
            pnlDel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlAgrMiPro.Visible = false;
            pnlDel.Visible = false;
        }

        private void btnAgregarAdd_Click(object sender, EventArgs e)
        {
            AgregarAdd();
        }

        private void btnQuitarDel_Click(object sender, EventArgs e)
        {
            QuitarDel();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pnlDel.Visible = true;
            pnlAgrMiPro.Visible = false;
            pnlAdd.Visible = false;
        }
        public void CargarInsumos()
        {
            try
            {
                Negocios.Insumos insumos = new Negocios.Insumos();
                insumos.BuscarMisInsumos();
                if (insumos.Tengo == true)
                {
                    dataViewMyInsumos.DataSource = insumos.dt;
                }
                else
                {
                    MessageBox.Show("Usted no posee insumos.", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Agregar()
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete el Nombre", "Aviso");
                txtNombre.Focus();
            }
            else if (txtKg.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo de KG", "Aviso");
                txtKg.Focus();
            }
            else if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Cantidad", "Aviso");
                txtCantidad.Focus();
            }
            else
            {
                try
                {
                    Negocios.Usuario usuario = new Negocios.Usuario();
                    Negocios.Metodos metodos = new Negocios.Metodos();
                    Negocios.Insumos insumos = new Negocios.Insumos();
                    usuario.nombre = metodos.nombre;
                    usuario.BusquedaXNombre();
                    insumos.IdCliente = usuario.id;
                    insumos.NombreProducto = txtNombre.Text;
                    insumos.Kg = Convert.ToInt32(txtKg.Text);
                    insumos.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    insumos.AgregarInsumoNoExistente();
                    if (insumos.Realizado == true)
                    {
                        CargarInsumos();
                        MessageBox.Show("Se agrego correctamente el insumo", "Aviso");
                        txtNombre.Clear();
                        txtKg.Clear();
                        txtCantidad.Clear();
                        pnlAgrMiPro.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hubo problemas al agregar el insumo", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        public void AgregarAdd()
        {
            if (txtIDAdd.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID", "Aviso");
                txtIDAdd.Focus();
            }
            else if (txtCantAdd.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo de Cantidad", "Aviso");
                txtCantAdd.Focus();
            }
            else
            {
                try
                {
                    Negocios.Metodos metodos = new Negocios.Metodos();
                    Negocios.Usuario usuario = new Negocios.Usuario();
                    Negocios.Insumos insumos = new Negocios.Insumos();
                    usuario.nombre = metodos.nombre;
                    usuario.BusquedaXNombre();
                    insumos.IdCliente = usuario.id;
                    insumos.IdInsumo = txtIDAdd.Text;
                    insumos.VerificarExistencia();
                    if (insumos.Tengo == true)
                    {
                        insumos.IdCliente = usuario.id;
                        insumos.IdInsumo = txtIDAdd.Text;
                        insumos.Cantidad = Convert.ToInt32(txtCantAdd.Text);
                        insumos.AgregarProductoExistente();
                        if (insumos.Realizado == true)
                        {
                            txtCantAdd.Clear();
                            txtIDAdd.Clear();
                            pnlAdd.Visible = false;
                            MessageBox.Show("Se agrego correctamente el insumo", "Aviso");
                            CargarInsumos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo problemas al agregar el insumo", "Aviso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usted no posee el producto que desea agregar.", "Aviso");
                        txtIDAdd.Clear();
                        txtCantAdd.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        public void QuitarDel()
        {
            if (txtIDDel.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID", "Aviso");
                txtIDAdd.Focus();
            }
            else if (txtCantDel.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo de Cantidad", "Aviso");
                txtCantAdd.Focus();
            }
            else
            {
                try
                {
                    Negocios.Metodos metodos = new Negocios.Metodos();
                    Negocios.Usuario usuario = new Negocios.Usuario();
                    Negocios.Insumos insumos = new Negocios.Insumos();
                    usuario.nombre = metodos.nombre;
                    usuario.BusquedaXNombre();
                    insumos.IdCliente = usuario.id;
                    insumos.IdInsumo = txtIDDel.Text;
                    insumos.VerificarExistencia();
                    if (insumos.Tengo == true)
                    {
                        if (insumos.Cantidad < Convert.ToInt32(txtCantDel.Text))
                        {
                            MessageBox.Show("Usted no posee la cantidad que desea quitar. Usted posee: " + insumos.Cantidad, "Aviso");
                            txtCantDel.Focus();
                        }
                        else
                        {
                            insumos.IdCliente = usuario.id;
                            insumos.IdInsumo = txtIDDel.Text;
                            insumos.Cantidad = Convert.ToInt32(txtCantDel.Text);
                            insumos.QuitarProductoExistente();
                            if (insumos.Realizado == true)
                            {
                                txtCantDel.Clear();
                                txtIDDel.Clear();
                                pnlDel.Visible = false;
                                MessageBox.Show("Se quito correctamente el insumo", "Aviso");
                                CargarInsumos();
                            }
                            else
                            {
                                MessageBox.Show("Hubo problemas al quitar el insumo", "Aviso");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no posee el insumo que desea quitar", "Aviso");
                        txtIDDel.Clear();
                        txtCantDel.Clear();
                        txtIDDel.Focus();
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            pnlAgrMiPro.Visible = false;
            txtNombre.Clear();
            txtKg.Clear();
            txtCantidad.Clear();
        }

        private void btnCancelarQuitar_Click(object sender, EventArgs e)
        {
            txtIDAdd.Clear();
            txtCantAdd.Clear();
            pnlDel.Visible = false;
        }

        private void btnCancelarAgre_Click(object sender, EventArgs e)
        {
            txtIDAdd.Clear();
            txtCantAdd.Clear();
            pnlAdd.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.Show();
            this.Hide();
        }
    }
}
