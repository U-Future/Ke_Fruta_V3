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
    public partial class GestFertilizacion : Form
    {
        public GestFertilizacion()
        {
            InitializeComponent();
        }

        private void gpboxVerduras_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboxTipo.SelectedIndex == 1)
            {
                gpboxVerduras.Visible = true;
                btnBuscarCriterios.Visible = true;
            }
            else if (cboxTipo.SelectedIndex == 2)
            {
                pnlCTriCeb.Visible = true;
                pnlCTriCeb.Enabled = true;
            }else if (cboxTipo.SelectedIndex == 3)
            {
                gpboxFrutas.Visible = true;
                btnBuscarCriterios.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione un tipo para continuar.");
                cboxTipo.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double nitrogeno=2.56 , fosforo=0.47 , potasio=4 , totalNit , totalFos, totalPot;
            double tonhect = Convert.ToDouble(numeUpDnTonPapaHect.Value);

            totalNit = nitrogeno*tonhect;
            txtNitrogeno.Text = totalNit + "Kg";

            totalFos = fosforo*tonhect;
            txtFosforo.Text = totalFos + "Kg";

            totalPot = potasio*tonhect;
            txtPotasio.Text = totalPot + "Kg";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rdbtnPapaRosada.Checked)
            {
                    pnlCriPapas.Visible = true;
                    gpboxVerduras.Visible = false;
                    btnBuscarCriterios.Visible = false;
            }
            else if (rdbtnZapalloCriollo.Checked)
            {
                    pnlCriZap.Visible = true;
                    gpboxVerduras.Visible = false;
                    btnBuscarCriterios.Visible = false;
            }
            else if (rdbtnManzana.Checked)
            {
                    pnlCriMan.Visible = true;
                    pnlCriMan.Enabled = true;
                    gpboxFrutas.Visible = false;
                    btnBuscarCriterios.Visible = false;
            }
            else if (rdbtnLimon.Checked || rdbtnNaranja.Checked)
            {
                    pnlCriNarLim.Visible = true;
                    pnlCriNarLim.Enabled = true;
                    gpboxFrutas.Visible = false;
                    btnBuscarCriterios.Visible = false;
            }
            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnlCriPapas.Visible = false;
            numeUpDnTonPapaHect.Value = 0;
            gpboxVerduras.Visible = true;
            btnBuscarCriterios.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double nitrogeno_zap = 120, fosforo_zap = 70, potasio_zap = 170, totalNit_zap, totalFos_zap, totalPot_zap;
            double hect_zap = Convert.ToDouble(numUpDnHectZap.Value);

            if (numUpDnHectZap.Value.Equals(0))
            {
                MessageBox.Show("La cantidad de hectareas debe ser diferente de 0, modifiquelo para continuar.");
                numUpDnHectZap.Focus();
            }
            else {
                totalNit_zap = nitrogeno_zap * hect_zap;
                txtNitrogeno_zap.Text = totalNit_zap + "Kg";

                totalFos_zap = fosforo_zap * hect_zap;
                txtFosforo_zap.Text = totalFos_zap + "Kg";

                totalPot_zap = potasio_zap * hect_zap;
                txtPotasio_zap.Text = totalPot_zap + "Kg";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbtnNitrogeno.Checked)
            {
                pnlNitrogeno.Visible = true;
                pnlCTriCeb.Enabled = false;
                pnlNitrogeno.Enabled = true;

            }
            else if (rdbtnFosforo.Checked)
            {
                pnlFosforo.Visible = true;
                pnlCTriCeb.Enabled = false;
                pnlFosforo.Enabled = true;
            }
        }

        private void btnCargarN_Click(object sender, EventArgs e)
        {
            if (rdbtnZ2.Checked)
            {
                pnlZ2.Visible = true;
                gpboxEstadios.Enabled = false;
                btnCargarN.Enabled = false;
                
                
            }else if(rdbtnZ3.Checked)
            {
                pnlZ3.Visible = true;
                gpboxEstadios.Enabled = false;
                btnCargarN.Enabled = false;
            }
        }

        private void txtEQF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNSuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNCritico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNPlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnCancelarN_Click(object sender, EventArgs e)
        {
            pnlNitrogeno.Visible = false;            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pnlZ2.Visible = false;
            txtEQF.Clear();
            txtNSuelo.Clear();
            txtNCritico.Clear();
            txtCantNitUtil.Clear();

            gpboxEstadios.Enabled = true;
            btnCargarN.Enabled = true;

        }

        private void btnCalcularNitUt_Click(object sender, EventArgs e)
        {
            double NC, EQF = 5, NS, NCExs, NCMod, N=25, NitUtilizar;
            NC = Convert.ToDouble(txtNCritico.Text);
            NS = Convert.ToDouble(txtNSuelo.Text);

            if (txtNSuelo.Text.Equals("") || txtNCritico.Text.Equals(""))
            {
                MessageBox.Show("Uno de los campos esta vacio, completelo.");
                txtNSuelo.Focus();
            }
            else
            {
                if (NC > 14)
                {
                    NCExs = NC - 14;
                    NCMod = NCExs * 5;
                    N = N + NCMod;

                    NitUtilizar = (NC - NS) * EQF;
                    txtCantNitUtil.Text = N.ToString() + "Kg";


                }
                else if (NC <= 14)
                {
                    NitUtilizar = (NC - NS) * EQF;
                    txtCantNitUtil.Text = NitUtilizar.ToString() + "Kg";
                }
            }
        }

        private void btnLimpiarNZ2_Click(object sender, EventArgs e)
        {
            txtNSuelo.Clear();
            txtNCritico.Clear();
            txtCantNitUtil.Clear();
        }

        private void btnCalcularZ3_Click(object sender, EventArgs e)
        {
            double EQFZ, NCZ, NP, N;

            if (txtNPlanta.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo de Nitrogeno en Planta");
                txtNPlanta.Focus();
            }
            else
            {
                EQFZ = Convert.ToDouble(txtEQFZ.Text);
                NP = Convert.ToDouble(txtNPlanta.Text);

                NCZ = (4.2 / 100) * NP;

                N = EQFZ * (NCZ - NP);

                txtCNUtilZ3.Text = N.ToString();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnlZ3.Visible = false;
            txtCNUtilZ3.Clear();
            txtNPlanta.Clear();

            gpboxEstadios.Enabled = true;
            btnCargarN.Enabled = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            txtCNUtilZ3.Clear();
            txtNPlanta.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double NCF, EQFF, FS, F;

            NCF = Convert.ToDouble(txtNCriticoFosforo.Text);
            EQFF = Convert.ToDouble(txtEQFFosforo.Text);
            FS = Convert.ToDouble(txtFSuelo.Text);

            if (txtFSuelo.Text.Equals(""))
            {
                MessageBox.Show("El campo de Fosforo en Suelo esta vacio, completelo.");
                txtFSuelo.Focus();
            }
            else
            {
                F = (NCF - FS) * EQFF;
                txtCFUtil.Text = F.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlFosforo.Visible = false;
            txtCFUtil.Clear();
            txtFSuelo.Clear();
        }

        private void btnLimpiarF_Click(object sender, EventArgs e)
        {
            txtCFUtil.Clear();
            txtFSuelo.Clear();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            pnlCTriCeb.Visible = false;
            pnlZ2.Visible = false;
            pnlZ3.Visible = false;
            pnlFosforo.Visible = false;
        }

        private void btnCalcularFertMan_Click(object sender, EventArgs e)
        {
            double nit_man = 110, pot_man = 200, cantHect, nitUti, potUti;

            if (numUpDnHectMan.Value.Equals(""))
            {
                MessageBox.Show("La cantidad de hectareas no puede ser igual a 0, seleccione otro valor.");
                numUpDnHectMan.Focus();
            }
            else
            {
                cantHect = Convert.ToDouble(numUpDnHectMan.Value);
                nitUti = nit_man * cantHect;
                potUti = pot_man * cantHect;

                txtNitMan.Text = nitUti.ToString() + "Kg";
                txtPotMan.Text = potUti.ToString() + "Kg";
            }
        }

        private void btnVolverMan_Click(object sender, EventArgs e)
        {
            pnlCriMan.Visible = false;
            txtNitMan.Text = "";
            txtPotMan.Text = "";
            numUpDnHectMan.Value = 0;
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            pnlCriNarLim.Visible = false;
            numUpDnHectNar.Value = 0;
            txtNitNar.Text = "";
            txtFosNar.Text = "";
            txtPotMan.Text = "";
        }

        private void btnCalcularNar_Click(object sender, EventArgs e)
        {
            double nit_nar = 200, fos_nar = 45,pot_nar = 150, cantHect_nar, nitUti_nar, potUti_nar, fosUti_nar;

            if (numUpDnHectNar.Value.Equals("0"))
            {
                MessageBox.Show("La cantidad de hectareas no puede ser igual a 0, seleccione otro valor.");
                numUpDnHectNar.Focus();
            }
            else
            {
                cantHect_nar = Convert.ToDouble(numUpDnHectNar.Value);
                nitUti_nar = nit_nar * cantHect_nar;
                potUti_nar = pot_nar * cantHect_nar;
                fosUti_nar = fos_nar * cantHect_nar;

                txtNitNar.Text = nitUti_nar.ToString() + "Kg";
                txtPotNar.Text = potUti_nar.ToString() + "Kg";
                txtFosNar.Text = fosUti_nar.ToString() + "Kg";
            }
        }

        private void btnVolverZap_Click(object sender, EventArgs e)
        {
            pnlCriZap.Visible = false;
            txtFosforo_zap.Text = "";
            txtNitrogeno_zap.Text = "";
            txtPotasio_zap.Text = "";


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
