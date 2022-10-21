using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Presentacion.ProductorActividades
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }

        private void btnCargarPro_Click(object sender, EventArgs e)
        {
            /*
            Negocios.Metodos.BuscoDatosProductor();
            btnCargarPro.Enabled = false;

            string sql;
            object cantfilas;
            ADODB.Recordset rs;

            if (Datos.Persistencia.cn.State != 0)
            {
                sql = "Select * from insumos where ID_Productor ='"+Negocios.Metodos.id+"' && Tipo = 'Agricola' && Cantidad > 0";

                try
                {
                    rs = Datos.Persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    while (!rs.EOF)
                    {
                        int rowEscribir = dataViewMisProductos.Rows.Count - 1;
                        dataViewMisProductos.Rows.Add(1);

                        dataViewMisProductos.Rows[rowEscribir].Cells[0].Value = rs.Fields[1].Value;
                        dataViewMisProductos.Rows[rowEscribir].Cells[1].Value = rs.Fields[2].Value;
                        dataViewMisProductos.Rows[rowEscribir].Cells[2].Value = rs.Fields[3].Value;
                        dataViewMisProductos.Rows[rowEscribir].Cells[3].Value = rs.Fields[4].Value;
                        dataViewMisProductos.Rows[rowEscribir].Cells[4].Value = rs.Fields[5].Value;
                        rs.MoveNext();
                    }
                    txtID.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtPrecio.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usted no tiene productos agricolas para vender","Aviso");
                }
            }
            */
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidad.MaxLength = 10;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {

            }
            else if (txtCantidad.Text.Equals(""))
            {

            }
            else if (txtPrecio.Text.Equals(""))
            {

            }
            else
            {
                Negocios.Insumos insumos = new Negocios.Insumos();
                Negocios.Vende vende = new Negocios.Vende();
                Negocios.Usuario usuario = new Negocios.Usuario();
                Negocios.Metodos metodos = new Negocios.Metodos();
                Negocios.Productos productos = new Negocios.Productos();

                //try
                //{
                    usuario.nombre = metodos.nombre;
                    usuario.BusquedaXNombre();
                    insumos.IdCliente = usuario.id;
                    insumos.IdInsumo = txtID.Text;
                    insumos.BuscarExistenciaInsumo();
                if (insumos.Cantidad < Convert.ToInt32(txtCantidad.Text))
                {
                    MessageBox.Show("No posee la cantidad que desea vender, usted posee: "+insumos.Cantidad, "Aviso");
                    txtCantidad.Focus();
                }
                else
                {
                    if (insumos.Tengo == true)
                    {
                        dataViewMisProductos.DataSource = insumos.dt;
                        if (MessageBox.Show("¿Esta seguro que desea vender este producto?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            vende.IdProductor = usuario.id;
                            vende.IdInsumo = txtID.Text;
                            vende.Nombre = insumos.NombreProducto;
                            vende.Cantidad = txtCantidad.Text;
                            vende.Precio = txtPrecio.Text;
                            vende.Vender();
                            if (vende.Realizado == true)
                            {
                                insumos.IdCliente = usuario.id;
                                insumos.IdInsumo = txtID.Text;
                                insumos.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                insumos.EliminarInsumo();
                                if (insumos.Realizado == true)
                                {
                                    productos.Nombre = insumos.NombreProducto;
                                    productos.VerificoInsumoProductor();
                                    if (productos.Existe)
                                    {
                                        productos.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                        productos.Agregar();
                                        if (productos.Agregado == true)
                                        {
                                            MessageBox.Show("La venta se realizo exitosamenete 1", "Aviso");
                                            txtCantidad.Clear();
                                            txtID.Clear();
                                            txtPrecio.Clear();
                                            CargarMisInsumos();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Hubo problemas agregar");
                                        }
                                    }
                                    else
                                    {
                                        productos.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                        productos.Precio = Convert.ToInt32(txtPrecio.Text);
                                        productos.KG = insumos.Kg;
                                        productos.Nombre = insumos.NombreProducto;
                                        productos.ComprarProductoNoExistente();
                                        if (productos.Registrado == true)
                                        {
                                            MessageBox.Show("La venta se realizo exitosamenete 2", "Aviso");
                                            txtCantidad.Clear();
                                            txtID.Clear();
                                            txtPrecio.Clear();
                                            CargarMisInsumos();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Hubo problemas");
                                        }
                                    }
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                MessageBox.Show("Chau");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Compra Cancelada", "Aviso");
                            txtID.Clear();
                            txtCantidad.Clear();
                            txtPrecio.Clear();
                            CargarMisInsumos();
                        }

                    }
                    else
                    {

                    }
                }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //    return;
                //}
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.Show();
            this.Hide();
        }
        public void CargarMisInsumos()
        {
            Negocios.Insumos insumos = new Negocios.Insumos();
            insumos.CargarMisInsumos();
            if(insumos.Tengo == true)
            {
                dataViewMisProductos.DataSource = insumos.dt;
            }
            else
            {
                MessageBox.Show("No posee insumos para vender", "Aviso");
            }
        }
    }
}
