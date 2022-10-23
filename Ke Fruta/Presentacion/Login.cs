using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ke_Fruta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtContraseña.Text.Length < 5)
            {
                MessageBox.Show("Ingrese correctamente la contrasena");
                txtContraseña.Focus();
            }
            else if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Escriba correctamente el Nombre de Usuario");
                txtUsuario.Focus();
            }
            else
            {
                try
                {
                    Datos.Persistencia persistencia = new Datos.Persistencia();
                    persistencia.usuario = txtUsuario.Text;
                    persistencia.password = txtContraseña.Text;

                    Negocios.Metodos metodos = new Negocios.Metodos();
                    metodos.nombre = txtUsuario.Text;
                    metodos.BuscarUsuario();
                    if(metodos.Existe == true)
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Password incorrecta", "Aviso");
                    }
                }
                catch
                {
                    MessageBox.Show("Usuario o Password incorrecta", "Aviso");
                    return;
                }
            }

            
            
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
        public void Aviso(string aviso)
        {
            MessageBox.Show(aviso,"Aviso");
            txtContraseña.Focus();
            txtContraseña.Clear();
            txtUsuario.Clear();
        }
        
    }
}

