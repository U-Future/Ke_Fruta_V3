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
            /*
            dataViewMyInsumos.Rows.Clear();
            string nom = Negocios.Metodos.nombre.ToString();
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;


            if (Datos.Persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + nom + "'";

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
                    if (Datos.Persistencia.cn.State != 0)
                    {
                        sql1 = "Select * from insumos where ID_Productor='"+rs.Fields[0].Value+"'";

                        try
                        {
                            rs1 = Datos.Persistencia.cn.Execute(sql1, out cantfilas);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        if(rs1.RecordCount > 0)
                        {
                            while (!rs1.EOF)
                            {
                                int rowEscribir = dataViewMyInsumos.Rows.Count - 1;
                                dataViewMyInsumos.Rows.Add(1);

                                dataViewMyInsumos.Rows[rowEscribir].Cells[0].Value = rs1.Fields[1].Value;
                                dataViewMyInsumos.Rows[rowEscribir].Cells[1].Value = rs1.Fields[2].Value;
                                dataViewMyInsumos.Rows[rowEscribir].Cells[2].Value = rs1.Fields[3].Value;
                                dataViewMyInsumos.Rows[rowEscribir].Cells[3].Value = rs1.Fields[4].Value;
                                dataViewMyInsumos.Rows[rowEscribir].Cells[4].Value = rs1.Fields[5].Value;
                                rs1.MoveNext();

                            }

                        }
                    }
                }
            }
            */
        }

        private void txtKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtKg.MaxLength = 2;
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
                int kg, cantidad;
                kg = Convert.ToInt32(txtKg.Text);
                cantidad = Convert.ToInt32(txtCantidad.Text);
                try
                {
                    //Negocios.Metodos.AgregarInsumoNoExistente(txtNombre.Text, kg, cantidad);
                    txtNombre.Clear();
                    txtKg.Clear();
                    txtCantidad.Clear();
                    pnlAgrMiPro.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
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
            if (txtIDAdd.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID","Aviso");
                txtIDAdd.Focus();
            }
            else if (txtCantAdd.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo de Cantidad", "Aviso");
                txtCantAdd.Focus();
            }
            else
            {
                int cantidad;
                cantidad = Convert.ToInt32(txtCantAdd.Text);
                try
                {
                    //Negocios.Metodos.AgregarInsumoExistente(txtIDAdd.Text, cantidad);
                    txtCantAdd.Clear();
                    txtIDAdd.Clear();
                    pnlAdd.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnQuitarDel_Click(object sender, EventArgs e)
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
                int cantidad;
                cantidad = Convert.ToInt32(txtCantDel.Text);
                try
                {
                    //Negocios.Metodos.QuitarInsumoExistente(txtIDDel.Text, cantidad);
                    txtCantAdd.Clear();
                    txtIDAdd.Clear();
                    pnlDel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pnlDel.Visible = true;
            pnlAgrMiPro.Visible = false;
            pnlAdd.Visible = false;
        }
    }
}
