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
            /*
            string sql;
            object cantfilas;
            ADODB.Recordset rs;
            string nombre;
            int cantidad, cantidadVender, precio, kg;
            Datos.Persistencia persistencia = new Datos.Persistencia();
            persistencia.AbrirConexion();
            if (persistencia.cn.State != 0)
            {
                sql = "Select * from insumos where ID_Productor ='"+Negocios.Metodos.id+"' and ID_Insumo ='"+txtID.Text+"' && Cantidad > 0";

                try
                {
                    rs = Datos.Persistencia.cn.Execute(sql, out cantfilas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    cantidadVender = Convert.ToInt32(txtCantidad.Text);
                    precio = Convert.ToInt32(txtPrecio.Text);
                    cantidad = Convert.ToInt32(rs.Fields[5].Value);
                    nombre = Convert.ToString(rs.Fields[2].Value);
                    kg = Convert.ToInt32(rs.Fields[4].Value);

                    if (cantidadVender > cantidad)
                    {
                        MessageBox.Show("La cantidad que deseea vender paso la cantidad que usted posee.","Aviso");
                        txtCantidad.Focus();
                    }
                    else
                    {
                        try
                        {
                            Negocios.Metodos.VenderProductor(txtID.Text, kg,cantidadVender, precio, nombre);
                            MessageBox.Show("Vendiste el producto: "+txtID.Text +" Cantidad: "+cantidadVender +" Precio: "+ precio , "Concretada");
                            txtID.Clear();
                            txtCantidad.Clear();
                            txtPrecio.Clear();
                            txtID.Enabled = false;
                            txtCantidad.Enabled = false;
                            txtPrecio.Enabled = false;
                            btnCargarPro.Enabled = true;
                            dataViewMisProductos.Rows.Clear();
                            btnVender.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }


                }
                else
                {
                    MessageBox.Show("El producto que deseea vender no existe en su inventario.", "Aviso");
                    txtID.Focus();
                }
            }
            */
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
    }
}
