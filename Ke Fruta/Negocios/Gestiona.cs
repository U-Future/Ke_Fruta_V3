using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Gestiona
    {
        protected int _idAdm;
        protected string _idSec;
        protected int _idPro;

        public int IdAdm
        {
            get { return _idAdm; }
            set { _idAdm = value; }
        }
        public string IdSec
        {
            get { return _idSec; }
            set { _idSec = value; }
        }
        public int IdPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void RegistrarGestion()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into gestiona(ID_Administrativo, ID_Sector, ID_Productor) values" +
                    "('" + _idAdm + "','" + _idSec + "','" + _idPro + "')";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    persistencia.cn.Close();
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
            }

        }
    }
}
