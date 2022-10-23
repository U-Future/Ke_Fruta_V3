using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Compra
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }
        public static string nombre;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (rdbtnFertilizantes.Checked)
            {
                CargarFertilizante();
            }
            else if (rdbtnHerFun.Checked)
            {
                CargarHerFun();
            }
            else if (rdbtnSemillas.Checked)
            {
                CargarSemilla();
            }
            else if (rdbtnOtros.Checked)
            {
                CargarAgricola();
            }            
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.Metodos metodos = new Negocios.Metodos();
                metodos.Salir_Tienda();
                this.Hide();
            }
            catch
            {
                return;
            }
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Comprar();
        }
        
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
        public void CargarAgricola()
        {
            try
            {
                Negocios.Productos productos = new Negocios.Productos();
                productos.BuscarOtro();
                if (productos.Existe == true)
                {
                    dataViewProductos.DataSource = productos.dt;
                }
                else
                {
                    MessageBox.Show("No disponemos de Stock en productos Agricolas", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void CargarSemilla()
        {
            try
            {
                Negocios.Productos productos = new Negocios.Productos();
                productos.BuscarSemilla();
                if (productos.Existe == true)
                {
                    dataViewProductos.DataSource = productos.dt;
                }
                else
                {
                    MessageBox.Show("No disponemos de Stock en Semillas", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void CargarFertilizante()
        {
            try
            {
                Negocios.Productos productos = new Negocios.Productos();
                productos.BuscarFertilizante();
                if (productos.Existe == true)
                {
                    dataViewProductos.DataSource = productos.dt;
                }
                else
                {
                    MessageBox.Show("No disponemos de Stock en Fertilizantes", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void CargarHerFun()
        {
            try
            {
                Negocios.Productos productos = new Negocios.Productos();
                productos.BuscarHerFun();
                if (productos.Existe == true)
                {
                    dataViewProductos.DataSource = productos.dt;
                }
                else
                {
                    MessageBox.Show("No disponemos de Stock en Herbicidas y Fungicidas", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void Comprar()
        {
            if (numUpDnCantidad.Value == 0)
            {
                MessageBox.Show("Seleccione un cantidad para continuar la compra", "Aviso");
                numUpDnCantidad.Focus();
            }
            else if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Complete el campo ID", "Aviso");
                txtID.Focus();
            }
            else
            {
                try
                {
                    Negocios.Usuario usuario = new Negocios.Usuario();
                    Negocios.Metodos metodos = new Negocios.Metodos();
                    Negocios.Productos productos = new Negocios.Productos();
                    Negocios.Compra compra = new Negocios.Compra();
                    Negocios.Notificar notificar = new Negocios.Notificar();
                    compra.IdProducto = txtID.Text;
                    compra.Verificar();
                    if(compra.Existe == true)
                    {
                        if(compra.Cantidad < Convert.ToInt32(numUpDnCantidad.Value))
                        {
                            MessageBox.Show("La cantidad que desea comprar no la poseemos. Nuestro Stock es: " + compra.Cantidad, "Aviso");
                        }
                        else
                        {
                            if (MessageBox.Show("¿Seguro que desea comprar el producto?","Confirmar",MessageBoxButtons.YesNoCancel, 
                                MessageBoxIcon.Question)== DialogResult.Yes)
                            {
                                int costcompra;
                                costcompra = compra.Precio * Convert.ToInt32(numUpDnCantidad.Value);
                                usuario.nombre = metodos.nombre;
                                usuario.BusquedaXNombre();
                                compra.IdCliente = usuario.id;
                                compra.IdProducto = txtID.Text;
                                compra.Cantidad = Convert.ToInt32(numUpDnCantidad.Value);
                                compra.Costo = costcompra;
                                compra.GenerarCompra();
                                if (compra.Concretado == true)
                                {
                                    productos.IdProducto = txtID.Text;
                                    productos.Cantidad = Convert.ToInt32(numUpDnCantidad.Value);
                                    productos.Quitar();
                                    if(productos.Quitado == true)
                                    {
                                        notificar.idCliente = usuario.id;
                                        notificar.NotificarCompra();
                                        MessageBox.Show("Compra realizada correctamente", "Aviso");
                                        dataViewProductos.DataSource = null;
                                        txtID.Clear();
                                        numUpDnCantidad.Value = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hubo problemas al quitar el producto de nuestro inventario", "Aviso");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hubo problemas al realizar la compra", "Aviso");
                                }
                            }
                            else
                            {
                                txtID.Clear();
                                numUpDnCantidad.Value = 0;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto que intenta comprar no esta registrado en nuestro inventario", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.Metodos metodos = new Negocios.Metodos();
                metodos.Salir_Tienda();
                this.Hide();
            }
            catch
            {
                return;
            }
        }
    }
}
