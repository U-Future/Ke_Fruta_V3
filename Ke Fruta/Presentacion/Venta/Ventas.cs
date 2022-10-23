using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Venta
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnConcretar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Complete la ID","Aviso");
                txtID.Focus();
            }
            else
            {
                Negocios.Metodos metodos = new Negocios.Metodos();
                Negocios.Usuario usuario = new Negocios.Usuario();
                Negocios.Compra compra = new Negocios.Compra();
                Negocios.Productos productos = new Negocios.Productos();
                compra.IdCompra = txtID.Text;
                compra.CargarTableCompra();
                if (compra.Existe == true)
                {
                    compra.ConcretarCompra();
                    if(compra.Concretado == true)
                    {
                        usuario.nombre = metodos.nombre;
                        usuario.BusquedaXNombre();
                        compra.IdCompra = txtID.Text;
                        compra.BuscarDatosCliente();

                        Negocios.RealizaVenta realizaventa = new Negocios.RealizaVenta();
                        realizaventa.IdCompra = txtID.Text;
                        realizaventa.IdProducto = compra.IdProducto;
                        realizaventa.IdCliente = compra.IdCliente;
                        realizaventa.IdAdministrativo = usuario.id;
                        realizaventa.RealizarVenta();
                        Negocios.Notificar notificar = new Negocios.Notificar();
                        if (realizaventa.Realizado == true)
                        {
                            switch (compra.TipoCliente)
                            {
                                case "I":

                                    Negocios.Insumos insumos = new Negocios.Insumos();
                                    insumos.IdProducto = compra.IdProducto;
                                    insumos.IdCliente = compra.IdCliente;
                                    insumos.Cantidad = compra.Cantidad;
                                    insumos.BuscarDatosProducto();
                                    if (insumos.Realizado == true)
                                    {
                                        productos.Cantidad = compra.Cantidad;
                                        productos.IdProducto = compra.IdProducto;
                                        productos.Modificar();
                                        if (productos.Quitado == true)
                                        {
                                            notificar.IdCompra = txtID.Text;
                                            notificar.NotificarCompra();
                                            MessageBox.Show("Venta realizada correctamente", "Aviso");
                                            txtID.Clear();
                                            btnConcretar.Enabled = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Problemas al quitar el producto de nuestro inventario.", "Problema");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Problemas al cargar las ventas al productor", "Aviso");
                                        txtID.Clear();
                                    }
                                    break;
                                case "E":
                                    productos.Cantidad = compra.Cantidad;
                                    productos.IdProducto = compra.IdProducto;
                                    productos.Modificar();
                                    if (productos.Quitado == true)
                                    {
                                        notificar.IdCompra = txtID.Text;
                                        notificar.NotificarCompra();
                                        MessageBox.Show("Venta realizada correctamente", "Aviso");
                                        txtID.Clear();
                                        btnConcretar.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Problemas al quitar el producto de nuestro inventario.", "Problema");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se logro registrar en la BD", "Aviso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo concretar la compra", "Aviso");
                    }

                }
                else
                {
                    MessageBox.Show("La compra que se quiere concretar no se encuentra registrada, " +
                        "intente nuevamente con un ID que se encuentre en la tabla.", "Aviso");
                }
            }
        }
        public static void Aviso(string Aviso)
        {
            MessageBox.Show(Aviso);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID", "Aviso");
                txtID.Focus();
            }
            else
            {
                Negocios.Compra compra = new Negocios.Compra();
                compra.IdCompra = txtID.Text;
                compra.CargarTableCompra();
                if (compra.Existe == true)
                {
                    dataViewCompras.DataSource = compra.dt;
                    btnConcretar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontro ninguna Compra pendiente con este ID", "Aviso");
                    txtID.Clear();
                    txtID.Focus();
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            dataViewCompras.DataSource = null;

            Negocios.Compra compra = new Negocios.Compra();
            compra.CargarTablePendientes();

            if (compra.Existe == true)
            {
                dataViewCompras.DataSource = compra.dt;
                btnConcretar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay compras pendientes", "Aviso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataViewCompras.DataSource = null;
            btnConcretar.Enabled = false;
            txtID.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
            this.Hide();
        }
    }
}
