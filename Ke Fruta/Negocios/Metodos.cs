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
        protected bool _Existe;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public bool Existe
        {
            get { return _Existe; }
            set { _Existe = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();


        public void BuscarUsuario()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
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
                    _Existe = true;
                    switch (rs.Fields[2].Value.ToString())
                    {
                        case "A"://Administrativo
                            Administrativo administrativo = new Administrativo();
                            administrativo.Show();
                            break;
                        case "I"://Productor
                            Ke_Fruta.Productor productor = new Productor();
                            productor.Show();
                            break;
                        case "E"://Cliente
                            Ke_Fruta.Compra.Tienda tienda = new Ke_Fruta.Compra.Tienda();
                            tienda.Show();
                            break;
                    }
                }
                else
                {
                    _Existe = false;
                }
            }
        }                                                
        //_____________________________
        public void Salir_Tienda()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
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
                        case "I"://Productor
                            Ke_Fruta.Productor productor = new Productor();
                            productor.Show();
                            break;
                        case "E"://Cliente
                            Ke_Fruta.Login login = new Login();
                            login.Show();
                            break;
                    }
                }
            }
        }
    }
}



