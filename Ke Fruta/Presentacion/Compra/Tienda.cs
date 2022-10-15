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
            /*
            dataViewProductos.Rows.Clear();

            if (rdbtnFertilizantes.Checked)
            {
                string sql;
                ADODB.Recordset rs;
                object cantfilas;

                if (Datos.Persistencia.cn.State != 0)
                {
                    sql = "Select * from productos where Tipo = 'Fertilizante' && Stock > 0"; 
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
                            int rowEscribir = dataViewProductos.Rows.Count - 1;
                            dataViewProductos.Rows.Add(1);

                            dataViewProductos.Rows[rowEscribir].Cells[0].Value = rs.Fields[0].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[1].Value = rs.Fields[1].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[2].Value = rs.Fields[2].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[3].Value = rs.Fields[3].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[4].Value = rs.Fields[4].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[5].Value = rs.Fields[5].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[6].Value = rs.Fields[7].Value;

                            rs.MoveNext();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No contamos con stock en Fertilizantes","Aviso");
                    }
                }

            }
            else if (rdbtnHerFun.Checked)
            {
                string sql;
                ADODB.Recordset rs;
                object cantfilas;
                if (Datos.Persistencia.cn.State != 0)
                {
                    sql = "Select * from productos where Tipo = 'Herbicida' || Tipo = 'Fungicida' && Stock > 0";

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
                            int rowEscribir = dataViewProductos.Rows.Count - 1;
                            dataViewProductos.Rows.Add(1);

                            dataViewProductos.Rows[rowEscribir].Cells[0].Value = rs.Fields[0].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[1].Value = rs.Fields[1].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[2].Value = rs.Fields[2].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[3].Value = rs.Fields[3].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[4].Value = rs.Fields[4].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[5].Value = rs.Fields[5].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[6].Value = rs.Fields[7].Value;

                            rs.MoveNext();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No contamos con stock en Herbicidas y Fungicidas","Aviso");
                    }
                }
            }
            else if (rdbtnSemillas.Checked)
            {
                string sql;
                ADODB.Recordset rs;
                object cantfilas;
                if (Datos.Persistencia.cn.State != 0)
                {
                    sql = "Select * from productos where Tipo = 'Semilla' && Stock > 0"; 

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
                            int rowEscribir = dataViewProductos.Rows.Count - 1;
                            dataViewProductos.Rows.Add(1);

                            dataViewProductos.Rows[rowEscribir].Cells[0].Value = rs.Fields[0].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[1].Value = rs.Fields[1].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[2].Value = rs.Fields[2].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[3].Value = rs.Fields[3].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[4].Value = rs.Fields[4].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[5].Value = rs.Fields[5].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[6].Value = rs.Fields[7].Value;

                            rs.MoveNext();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No contamos con stock en Semillas","Aviso");
                    }
                }
            }
            else if (rdbtnOtros.Checked)
            {
                string sql;
                ADODB.Recordset rs;
                object cantfilas;

                if (Datos.Persistencia.cn.State != 0)
                {
                    sql = "Select * from productos where Tipo = 'Agricola' && Stock > 0";

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
                            int rowEscribir = dataViewProductos.Rows.Count - 1;
                            dataViewProductos.Rows.Add(1);

                            dataViewProductos.Rows[rowEscribir].Cells[0].Value = rs.Fields[0].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[1].Value = rs.Fields[1].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[2].Value = rs.Fields[2].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[3].Value = rs.Fields[3].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[4].Value = rs.Fields[4].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[5].Value = rs.Fields[5].Value;
                            dataViewProductos.Rows[rowEscribir].Cells[6].Value = rs.Fields[7].Value;

                            rs.MoveNext();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No contamos con stock en productos Agricolas","Aviso");
                    }
                }
            }

            txtID.Enabled = true;
            numUpDnCantidad.Enabled = true;
            btnComprar.Enabled = true;
            */
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide(); 
            
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            /*
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
                    int cantidad = Convert.ToInt32(numUpDnCantidad.Value);
                    Negocios.Metodos.BuscarStockProducto(txtID.Text, cantidad);
                    numUpDnCantidad.Enabled = false;
                    txtID.Enabled = false;
                    txtID.Text = "";
                    btnComprar.Enabled = false;
                    dataViewProductos.Rows.Clear();
                }
                catch
                {
                    MessageBox.Show("Hubo problemas al concretar la venta", "Aviso");
                }

            }
            */
        }
        
        public static void Aviso(string Problema)
        {
            MessageBox.Show(Problema);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.MaxLength = 15;
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
    }
}
