using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta
{
    public partial class ABMC : Form
    {
        public ABMC()
        {
            InitializeComponent();
        }

        public static void Aviso(string aviso)
        {
            MessageBox.Show(aviso,"Notificacion");
        }

        private void txtIDVerificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            dataViewDatos.Rows.Clear();
            dataViewSector.Rows.Clear();
            dataViewTelefono.Rows.Clear();
            if (txtIDVerificar.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID", "Aviso");
                txtIDVerificar.Focus();
            }
            else
            {
                try
                {
                    Negocios.Usuario usuario = new Negocios.Usuario();
                    usuario.id = txtIDVerificar.Text;
                    usuario.verificar();

                    if (usuario.Hay.Equals(true))
                    {
                        btnVerificar.Enabled = false;
                        txtIDVerificar.Enabled = false;
                        btnModDatos.Enabled = true;
                        btnBaja.Enabled = true;
                        btnAlta.Enabled = false;
                        btnCancelar.Enabled = true;

                        int rowEscribir = dataViewDatos.Rows.Count - 1;
                        dataViewDatos.Rows.Add(1);
                        dataViewDatos.Rows[rowEscribir].Cells[0].Value = usuario.rut;
                        dataViewDatos.Rows[rowEscribir].Cells[1].Value = usuario.nombre;
                        dataViewDatos.Rows[rowEscribir].Cells[2].Value = usuario.tipo;
                        dataViewDatos.Rows[rowEscribir].Cells[3].Value = usuario.email;
                        dataViewDatos.Rows[rowEscribir].Cells[4].Value = usuario.tipoCultivo;
                        txtNomMod.Text = usuario.nombre;
                        txtEmailMod.Text = usuario.email;
                        if (usuario.tipo == "I")
                        {
                            foreach (string sectores in usuario.sector)
                            {
                                int rowEscribir1 = dataViewSector.Rows.Count - 1;
                                dataViewSector.Rows.Add(1);
                                dataViewSector.Rows[rowEscribir1].Cells[0].Value = sectores;
                            }
                            btnAgregarSector.Enabled = true;
                            btnEliminarSector.Enabled = true;
                            btnAgregarTel.Enabled = true;
                            btnEliminarTelefono.Enabled = true;
                            dataViewSector.Enabled = true;
                        }
                        else if (usuario.tipo == "E")
                        {
                            btnAgregarSector.Enabled = false;
                            btnEliminarSector.Enabled = false;
                            btnAgregarTel.Enabled = true;
                            btnEliminarTelefono.Enabled = true;
                            dataViewSector.Enabled = false;
                        }
                        else if (usuario.tipo == "A")
                        {
                            btnAgregarSector.Enabled = false;
                            btnEliminarSector.Enabled = false;
                            btnAgregarTel.Enabled = true;
                            btnEliminarTelefono.Enabled = true;
                            dataViewSector.Enabled = false;
                        }

                        foreach (string tel in usuario.telefonos)
                        {
                            int rowEscribir2 = dataViewTelefono.Rows.Count - 1;
                            dataViewTelefono.Rows.Add(1);
                            dataViewTelefono.Rows[rowEscribir2].Cells[0].Value = tel;
                        }
                    }
                    else
                    {
                        txtIDVerificar.Focus();
                        btnModDatos.Enabled = false;
                        btnAlta.Enabled = true;
                        btnBaja.Enabled = false;
                        btnEliminarTelefono.Enabled = false;
                        btnAgregarTel.Enabled = false;
                        btnEliminarSector.Enabled = false;
                        btnAgregarSector.Enabled = false;
                        btnCancelar.Enabled = false;
                        pnlAlta.Visible = false;
                        pnlModificar.Visible = false;
                    }                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Aviso");
                    return;
                }
            }

        }

        private void btnModDatos_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = true;
            Negocios.Usuario usuario = new Negocios.Usuario();
            usuario.id = txtIDVerificar.Text;
            usuario.verificar();
            txtNomMod.Text = usuario.nombre; ;
            txtEmailMod.Text = usuario.email;
            btnBaja.Enabled = false;
            btnCancelar.Enabled = false;
            btnModDatos.Enabled = false;
            btnEliminarTelefono.Enabled = false;
            btnAgregarTel.Enabled = false;
            btnEliminarSector.Enabled = false;
            btnAgregarSector.Enabled = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            pnlAlta.Visible = true;
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = false;
            pnlModPass.Visible = false;

            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
            btnModDatos.Enabled = true;
            btnEliminarTelefono.Enabled = true;
            btnAgregarTel.Enabled = true;
        }

        private void btnAltaUs_Click(object sender, EventArgs e)
        {
            Negocios.Usuario usuario = new Negocios.Usuario();

            if (txtNombreAlta.Text.Equals(""))
            {
                MessageBox.Show("Complete el Nombre", "Aviso");
                txtNombreAlta.Focus();
            }
            else if (txtRUTAlta.Text.Equals(""))
            {
                MessageBox.Show("Complete el RUT","Aviso");
                txtRUTAlta.Focus();
            }
            else if (txtPasswordAlta.Text.Equals(""))
            {
                MessageBox.Show("Complete la Password","Aviso");
                txtPasswordAlta.Focus();
            }
            else if (txtEmailAlta.Text.Equals(""))
            {
                MessageBox.Show("Complete el Email","Aviso");
                txtEmailAlta.Focus();
            }
            else
            {
                try
                {
                    usuario.nombre = txtNombreAlta.Text;
                    usuario.BuscarExitenciaNombre();
                    if (usuario.Hay == true)
                    {
                        MessageBox.Show("El nombre que se quiere registrar ya existe, debe reemplazarlo.", "Aviso");
                        txtNombreAlta.Focus();
                    }
                    else
                    {
                        if (rdbtnAdministrativo.Checked == true)
                        {
                            usuario.tipo = "A";
                        }
                        else if (rdbtnExterno.Checked == true)
                        {
                            usuario.tipo = "E";
                        }
                        else if (rdbtnInterno.Checked == true)
                        {
                            usuario.tipo = "I";
                            if (rdbtnFruta.Checked == true)
                            {
                                usuario.tipoCultivo = "Fruta";
                            }
                            else if (rdbtnVerdura.Checked == true)
                            {
                                usuario.tipoCultivo = "Verdura";
                            }
                            else if (rdbtnCereal.Checked == true)
                            {
                                usuario.tipoCultivo = "Cereal";
                            }
                        }
                        usuario.nombre = txtNombreAlta.Text;
                        usuario.rut = txtRUTAlta.Text;
                        usuario.pass = txtPasswordAlta.Text;
                        usuario.email = txtEmailAlta.Text;
                        usuario.AltaUsuario();
                        txtNombreAlta.Clear();
                        txtPasswordAlta.Clear();
                        txtEmailAlta.Clear();
                        txtRUTAlta.Clear();
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            txtNombreAlta.Clear();
            txtPasswordAlta.Clear();
            txtEmailAlta.Clear();
            txtRUTAlta.Clear();
            pnlAlta.Visible = false;
            txtIDVerificar.Focus();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios.Usuario usuario = new Negocios.Usuario();
                usuario.id = txtIDVerificar.Text;
                usuario.verificar();
                if (usuario.tipo == "A")
                {
                    usuario.BajaUsuarioAdministrativo();
                    if (usuario.Hay.Equals(true))
                    {
                        txtIDVerificar.Clear();
                        dataViewDatos.Rows.Clear();
                        dataViewSector.Rows.Clear();
                        dataViewTelefono.Rows.Clear();
                        btnBaja.Enabled = false;
                        btnModDatos.Enabled = false;
                        btnAlta.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnEliminarSector.Enabled = false;
                        btnAgregarTel.Enabled = false;
                        btnAgregarSector.Enabled = false;
                        btnEliminarTelefono.Enabled = false;
                        txtIDVerificar.Enabled = true;
                        btnVerificar.Enabled = true;
                    }
                }
                else if (usuario.tipo == "I")
                {
                    usuario.BajaUsuarioProductor();
                    if (usuario.Hay.Equals(true))
                    {
                        txtIDVerificar.Clear();
                        dataViewDatos.Rows.Clear();
                        dataViewSector.Rows.Clear();
                        dataViewTelefono.Rows.Clear();
                        btnBaja.Enabled = false;
                        btnModDatos.Enabled = false;
                        btnAlta.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnEliminarSector.Enabled = false;
                        btnAgregarTel.Enabled = false;
                        btnAgregarSector.Enabled = false;
                        btnEliminarTelefono.Enabled = false;
                        txtIDVerificar.Enabled = true;
                        btnVerificar.Enabled = true;
                    }
                }
                else if (usuario.tipo == "E")
                {
                    usuario.BajaUsuarioCliente();
                    if (usuario.Hay.Equals(true))
                    {
                        txtIDVerificar.Clear();
                        dataViewDatos.Rows.Clear();
                        dataViewSector.Rows.Clear();
                        dataViewTelefono.Rows.Clear();
                        btnBaja.Enabled = false;
                        btnModDatos.Enabled = false;
                        btnAlta.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnEliminarSector.Enabled = false;
                        btnAgregarTel.Enabled = false;
                        btnAgregarSector.Enabled = false;
                        btnEliminarTelefono.Enabled = false;
                        txtIDVerificar.Enabled = true;
                        btnVerificar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void txtRUTAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtCantHect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtIDSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) == true && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void btnAgSec_Click(object sender, EventArgs e)
        {
            if (txtIDSector.Text.Equals(""))
            {
                MessageBox.Show("Complete el ID de Sector", "Aviso");
                txtIDSector.Focus();
            }
            else if (txtCantHect.Text.Equals(""))
            {
                MessageBox.Show("Complete la Cantidad de Hectareas","Aviso");
                txtCantHect.Focus();
            }
            else
            {
                try
                {
                    Negocios.Sector sector = new Negocios.Sector();
                    sector.idSec = txtIDSector.Text;
                    sector.BuscarSector();
                    if (sector.ExisteSector == true)
                    {
                        MessageBox.Show("El sector que se intenta registrar ya existe", "Aviso");
                        txtIDSector.Focus();
                    }
                    else
                    {
                        sector.idPro = txtIDVerificar.Text;
                        sector.idSec = txtIDSector.Text;
                        sector.canidadhect = txtCantHect.Text;
                        sector.AgregarSector();
                        dataViewSector.Rows.Add(txtIDSector.Text);
                        txtIDSector.Clear();
                        txtCantHect.Clear();
                        pnlAgrSec.Visible = false;
                        MessageBox.Show("Se agrego el sector correctamente", "Aviso");
                        btnBaja.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnModDatos.Enabled = true;
                        btnEliminarTelefono.Enabled = true;
                        btnAgregarTel.Enabled = true;
                        btnEliminarSector.Enabled = true;
                        btnAgregarSector.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            if (txtNomMod.Text.Equals(""))
            {
                MessageBox.Show("Complete el Nombre", "Aviso");
                txtNomMod.Focus();
            }
            else if (txtEmailMod.Text.Equals(""))
            {
                MessageBox.Show("Complete el Email", "Aviso");
                txtEmailMod.Focus();
            }
            else
            {
                try
                {

                    Negocios.Usuario usuario = new Negocios.Usuario();
                    usuario.nombrenuevo = txtNomMod.Text;
                    usuario.emailnuevo = txtEmailMod.Text;
                    usuario.id = txtIDVerificar.Text;
                    usuario.BuscarExitenciaNombre();
                    usuario.BuscarExistenciaEmail();
                    if (usuario.Hay == true)
                    {
                        MessageBox.Show("El nombre con el que intenta sustituir al antiguo ya se " +
                            "encuentra registrado con otro usuario, intente con otro.", "Aviso");
                        txtNomMod.Focus();
                    }
                    else
                    {
                        try
                        {
                            usuario.id = txtIDVerificar.Text;
                            usuario.verificar();
                            usuario.nombrenuevo = txtNomMod.Text;
                            usuario.ModificarNombreUser();
                            usuario.ModificarUsuario();
                            MessageBox.Show("Se modifico correctamente el nombre", "Aviso");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    if (usuario.EmailExiste == true)
                    {
                        MessageBox.Show("El email con el que intenta sustituir al antiguo ya se " +
                       "encuentra registrado, intente con otro.", "Aviso");
                        txtEmailMod.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se modifico correctamente el Email.", "Aviso");
                    }
                    pnlModificar.Visible = false;
                    pnlModPass.Visible = false;

                    btnBaja.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnModDatos.Enabled = true;
                    btnEliminarTelefono.Enabled = true;
                    btnAgregarTel.Enabled = true;
                    btnEliminarSector.Enabled = true;
                    btnAgregarSector.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
               
            }
        }

        private void btnModPass_Click(object sender, EventArgs e)
        {
            pnlModPass.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPassNueva.Text.Length < 10)
            {
                MessageBox.Show("La contraseña tiene que tener un minimo de 15 digitos","Aviso");
                txtPassNueva.Focus();
            }
            else if (txtRepPass.Text.Length < 10)
            {
                MessageBox.Show("La contraseña tiene que tener un minimo de 15 digitos", "Aviso");
                txtRepPass.Focus();
            }
            else
            {
                try
                {
                    if (txtPassNueva.Text == txtRepPass.Text)
                    {
                        Negocios.Usuario usuario = new Negocios.Usuario();
                        Negocios.Metodos metodos = new Negocios.Metodos();
                        usuario.id = txtIDVerificar.Text;
                        usuario.passnueva = txtPassNueva.Text;
                        usuario.verificar();
                        usuario.ModificarPassword();
                        MessageBox.Show("Se modifico correctamente", "Aviso");
                        txtPassNueva.Clear();
                        txtRepPass.Clear();
                        pnlModPass.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnAgregarTel_Click(object sender, EventArgs e)
        {
            pnlAgrTel.Visible = true;

            btnBaja.Enabled = false;
            btnCancelar.Enabled = false;
            btnModDatos.Enabled = false;
        }

        private void btnAgregarSector_Click(object sender, EventArgs e)
        {
            pnlAgrSec.Visible = true;

            btnBaja.Enabled = false;
            btnCancelar.Enabled = false;
            btnModDatos.Enabled = false;
            btnEliminarTelefono.Enabled = false;
            btnAgregarTel.Enabled = false;
            btnEliminarSector.Enabled = false;
            btnAgregarSector.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length < 8)
            {
                MessageBox.Show("El telefono tiene una cantidad minima de 8 digitos, corriga", "Aviso");
                txtTelefono.Focus();
            }
            else
            {
                try
                {
                    Negocios.Telefono telefono = new Negocios.Telefono();
                    telefono.telefono = txtTelefono.Text;
                    telefono.BuscarTelefono();
                    if (telefono.Existe == true)
                    {
                        MessageBox.Show("El telefono ya se encuentra registrado.", "Aviso");
                    }
                    else
                    {
                        telefono.id = txtIDVerificar.Text;
                        telefono.telefono = txtTelefono.Text;
                        telefono.AgregarTelefono();
                        dataViewTelefono.Rows.Add(txtTelefono.Text);
                        txtTelefono.Clear();
                        pnlAgrTel.Visible = false;
                        MessageBox.Show("Se agrego correctamente el telefono", "Aviso");
                        btnBaja.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnModDatos.Enabled = true;
                        btnEliminarTelefono.Enabled = true;
                        btnAgregarTel.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
                
            }
        }

        private void btnCancelarAgrTel_Click(object sender, EventArgs e)
        {
            pnlAgrTel.Visible = false;
            txtTelefono.Clear();

            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
            btnModDatos.Enabled = true;
            
        }

        private void btnCancelarSec_Click(object sender, EventArgs e)
        {
            pnlAgrSec.Visible = false;
            txtIDSector.Clear();
            txtCantHect.Clear();

            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
            btnModDatos.Enabled = true;
            btnEliminarTelefono.Enabled = true;
            btnAgregarTel.Enabled = true;
            btnEliminarSector.Enabled = true;
            btnAgregarSector.Enabled = true;

        }

        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewTelefono.CurrentRow;

                if (dataViewTelefono.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Todos lo registros estan seleccionados, seleccione uno a la vez","Aviso");
                }
                else
                {
                    Negocios.Telefono telefono = new Negocios.Telefono();
                    telefono.telefono = row.Cells["Telefonos"].Value.ToString();
                    telefono.id = txtIDVerificar.Text;
                    telefono.EliminarTelefono();
                    dataViewTelefono.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Se elimino correctamente el telefono", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataViewDatos.Rows.Clear();
            dataViewSector.Rows.Clear();
            dataViewTelefono.Rows.Clear();
            txtNomMod.Clear();
            txtEmailMod.Clear();
            btnEliminarTelefono.Enabled = false;
            btnAgregarTel.Enabled = false;
            btnAgregarSector.Enabled = false;
            btnEliminarSector.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlta.Enabled = true;
            btnModDatos.Enabled = false;
            btnBaja.Enabled = false;
            txtIDVerificar.Clear();
            txtIDVerificar.Enabled = true;
            txtIDVerificar.Focus();
            btnVerificar.Enabled = true;
        }

        private void btnEliminarSector_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewSector.CurrentRow;

                if (dataViewSector.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Todos lo registros estan seleccionados, seleccione uno a la vez", "Aviso");
                }
                else
                {
                    Negocios.Sector sector = new Negocios.Sector();
                    sector.idPro = txtIDVerificar.Text;
                    sector.idSec = row.Cells["Sectores"].Value.ToString();
                    sector.EliminarSector();
                    dataViewSector.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Se elimino correctamente", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancelarModPass_Click(object sender, EventArgs e)
        {
            pnlModPass.Visible = false;
        }

        private void txtPassNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassNueva.PasswordChar = '*';
        }

        private void txtRepPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRepPass.PasswordChar = '*';
        }

        private void txtNombreAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPasswordAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPasswordAlta.PasswordChar = '*';
        }

        private void txtNomMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Show();
            this.Hide();
        }
    }
}
