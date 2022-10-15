using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta.Negocios
{
    internal class Metodos
    {
        protected static string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void BuscarUsuario()
        {
            persistencia.AbrirConexion();

            string sql;
            ADODB.Recordset rs;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre= '" + _nombre + "'";
                try
                {
                    rs = persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
                if (rs.RecordCount > 0)
                {

                    switch (rs.Fields[2].Value.ToString())
                    {
                        case "A"://Administrativo
                            Administrativo administrativo = new Administrativo();
                            administrativo.Show();
                            persistencia.cn.Close();
                            break;
                        case "I"://Productor
                            Presentacion.SeleccioneApp seleccioneApp = new Presentacion.SeleccioneApp();
                            seleccioneApp.Show();
                            persistencia.cn.Close();
                            break;
                        case "E"://Cliente
                            Ke_Fruta.Compra.Tienda tienda = new Ke_Fruta.Compra.Tienda();
                            tienda.Show();
                            persistencia.cn.Close();
                            break;
                    }
                }
            }
        }                                                
        //____________________________________________________________________________________________________________    
        public void AbrirCon()
        {
            Datos.Persistencia persistencia = new Datos.Persistencia();
            persistencia.AbrirConexion();
        }        

    }
}



