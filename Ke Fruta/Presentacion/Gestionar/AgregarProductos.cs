using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Presentacion.Gestionar
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }
        public static string Tipo;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataViewProductos.DataSource = null;
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID","Aviso");
                txtID.Focus();
            }
            else
            {
                Negocios.Productos productos = new Negocios.Productos();
                productos.IdProducto = txtID.Text;
                productos.BuscarProducto();

                if (productos.Existe == true)
                {
                    dataViewProductos.DataSource = productos.dt;
                    gpboxAgregar.Visible = true;
                    btnBajaProducto.Enabled = true;
                    btnAltaProducto.Enabled = false;
                    btnBuscar.Enabled = false;
                    txtID.Enabled = false;
                    btnListarTodo.Enabled = false;
                }
                else
                {
                    if (MessageBox.Show("No existe producto registrado con este ID. ¿Desea registrar uno?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        gpboxAgregarProducto.Visible = true;
                        btnBuscar.Enabled = false;
                        txtID.Enabled = false;
                        gpboxAgregarProducto.BringToFront();
                    }
                    else
                    {
                        txtID.Focus();
                        txtID.Clear();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpboxAgregarProducto.Visible = false;
            txtID.Clear();
            txtID.Focus();
            txtID.Enabled = true;
            btnBuscar.Enabled = true;
            btnListarTodo.Enabled = true;
            btnAltaProducto.Enabled = true;
            btnBajaProducto.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtNom.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos correctamente para continuar","Aviso");
                txtNom.Focus();
            }
            else if (txtFabricante.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos correctamente para continuar", "Aviso");
                txtFabricante.Focus();
            }
            else if (txtPrecio.Text.Length < 2)
            {
                MessageBox.Show("Complete todos los campos correctamente para continuar", "Aviso");
                txtPrecio.Focus();
            }
            else if (cboxTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un tipo de producto", "Aviso");
                cboxTipo.Focus();
            }
            else if (numUpDownKG.Value.Equals(0))
            {
                MessageBox.Show("Ingrese contenido en KG del producto", "Aviso");
                numUpDownKG.Focus();
            }
            else
            {
                string Tipo = "";

                if (cboxTipo.SelectedIndex == 1)
                {
                    Tipo = "Fertilizante";
                }
                else if (cboxTipo.SelectedIndex == 2)
                {
                    Tipo = "Herbicida";
                }
                else if (cboxTipo.SelectedIndex == 3)
                {
                    Tipo = "Fungicida";
                }
                else if (cboxTipo.SelectedIndex == 4)
                {
                    Tipo = "Semilla";
                }
                try
                {
                    Negocios.Productos productos = new Negocios.Productos();
                    productos.Nombre = txtNom.Text;
                    productos.Tipo = Tipo;
                    productos.Fabricante = txtFabricante.Text;
                    productos.Precio = Convert.ToInt32(txtPrecio.Text);
                    productos.KG = Convert.ToInt32(numUpDownKG.Value);
                    productos.Registrar();
                    if(productos.Registrado == true)
                    {
                        productos.BuscarUltimo();
                        MessageBox.Show("Se registro correctamente el producto. " +
                            "Datos: " +
                            "ID: " + productos.IdProducto + " " +
                            "Nombre: " + productos.Nombre + " " +
                            "Tipo: " + productos.Tipo + " " +
                            "Fabricante: " + productos.Fabricante + " " +
                            "KG: " + productos.KG + " " +
                            "Precio: " + productos.Precio, "Aviso");
                        txtNom.Clear();
                        txtFabricante.Clear();
                        txtPrecio.Clear();
                        numUpDownKG.Value = 0;
                        cboxTipo.SelectedIndex = 0;
                        gpboxAgregarProducto.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se logro registrar el producto", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Negocios.Productos productos = new Negocios.Productos();
            if (rdbtnAgregar.Checked == true)
            {
                if (numUpDownCantidad.Value != 0)
                {
                    productos.Cantidad = Convert.ToInt32(numUpDownCantidad.Value);
                    productos.IdProducto = Convert.ToString(txtID.Text);
                    productos.Agregar();
                    if(productos.Agregado == true)
                    {
                        MessageBox.Show("Se agrego correctamente el producto.", "Aviso");
                        dataViewProductos.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Hubo problemas al agregar el producto.", "Aviso");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad a agregar debe ser mayor de 0");
                    numUpDownCantidad.Focus();
                }
            }
            else if (rdbtnQuitar.Checked == true)
            {
                if (numUpDownCantidad.Value != 0)
                {
                    productos.Cantidad = Convert.ToInt32(numUpDownCantidad.Value);
                    productos.IdProducto = Convert.ToString(txtID.Text);
                    productos.Quitar();
                    if (productos.Suficiente == true)
                    {
                        if(productos.Quitado == true)
                        {
                            MessageBox.Show("Se quito correctamente el producto", "Aviso");
                            dataViewProductos.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Hubo problemas al quitar el producto", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad que desea quitar es mayor a la cantidad en inventario.", "Aviso");
                        numUpDownCantidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad a quitar debe ser mayor de 0");
                    numUpDownCantidad.Focus();
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.MaxLength = 15;
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.MaxLength = 15;
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNom.MaxLength = 30;
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtFabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFabricante.MaxLength = 30;
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            gpboxAgregar.Visible = false;
            txtID.Focus();
            txtID.Clear();
            txtID.Enabled = true;
            btnBuscar.Enabled = true;
            btnListarTodo.Enabled = true;
            btnAltaProducto.Enabled = true;
            btnBajaProducto.Enabled = false;
        }

        private void btnListarTodo_Click_1(object sender, EventArgs e)
        {
            dataViewProductos.DataSource = null;
            Negocios.Productos productos = new Negocios.Productos();
            productos.ListarTodo();
            dataViewProductos.DataSource = productos.dt;
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            gpboxAgregarProducto.Visible = true;
            gpboxAgregarProducto.BringToFront();
            btnAltaProducto.Enabled = false;
            btnListarTodo.Enabled = false;
            btnBuscar.Enabled = false;
            txtID.Enabled = false;
        }

        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            Negocios.Productos productos = new Negocios.Productos();
            try
            {
                productos.IdProducto = txtID.Text;
                productos.BajaProducto();
                if (productos.Quitado == true)
                {
                    MessageBox.Show("Se dio la baja del producto correctamente.", "Aviso");
                    txtID.Clear();
                    txtID.Focus();
                    btnBajaProducto.Enabled = false;
                    btnListarTodo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnAltaProducto.Enabled = true;
                    txtID.Enabled = true;
                    gpboxAgregar.Visible = false;
                    dataViewProductos.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Hubo problemas al dar la baja", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
