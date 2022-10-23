using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ke_Fruta.Datos
{
    internal class Persistencia
    {
        public ADODB.Connection cn = new ADODB.Connection();

        protected static string _usuario;
        protected static string _password;
        
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }


        public void AbrirConexion()
        {
            try
            {
                cn.Open("odbc_kefruta", usuario, password); 
            }
            catch
            {
                return;
            }

            cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
        }
    }
}
