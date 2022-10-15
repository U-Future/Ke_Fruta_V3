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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            /*
            Negocios.Metodos.BuscoDatosProductor();
            txtID.Text = Negocios.Metodos.id;
            txtNom.Text = Negocios.Metodos.nombre;
            txtPassword.Text = Negocios.Metodos.password;
            txtRut.Text = Negocios.Metodos.rut;
            txtTipo.Text = Negocios.Metodos.tipocultivo;
            txtEmail.Text = Negocios.Metodos.email;

            gpboxDatos.Enabled = true;
            btnCargar.Enabled = false;

            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if (Datos.Persistencia.cn.State != 0)
            {
                sql = "Select * from tel_usuario where ID_Usuario = '"+Negocios.Metodos.id+"'";

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
                        listboxTeléfono.Items.Add("Telefono: "+ rs.Fields[1].Value);
                        listboxTeléfono.Items.Add("______________________________");
                        rs.MoveNext();
                    }
                }
            }

            if (Datos.Persistencia.cn.State != 0)
            {
                sql1 = "Select * from sector where ID_Productor = '" + Negocios.Metodos.id + "'";

                try
                {
                    rs1 = Datos.Persistencia.cn.Execute(sql1, out cantfilas);
                }
                catch
                {
                    return;
                }
                if (rs1.RecordCount > 0)
                {
                    while (!rs1.EOF)
                    {
                        listboxSector.Items.Add("ID: "+ rs1.Fields[1].Value);
                        listboxSector.Items.Add("Tipo Cultivo: "+rs1.Fields[2].Value);
                        listboxSector.Items.Add("Hectareas: "+rs1.Fields[3].Value);
                        listboxSector.Items.Add("Estado: "+rs1.Fields[4].Value);
                        listboxSector.Items.Add("______________________________");
                        rs1.MoveNext();
                    }
                }
            }
            */

        }
    }
}
