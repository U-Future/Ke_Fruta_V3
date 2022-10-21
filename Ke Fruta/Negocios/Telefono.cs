using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Telefono
    {
        protected string _telefono;
        protected string _id;
        protected bool _Existe;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string id 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        public bool Existe
        {
            get { return _Existe; }
            set { _Existe = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void AgregarTelefono()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Insert into tel_usuario(ID_Usuario, Telefono) values" +
                    "('" + _id + "','" + _telefono + "')";

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
        public void EliminarTelefono()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Delete from tel_usuario where Telefono ='" + _telefono + "'";

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
        public void BuscarTelefono()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from tel_usuario where Telefono='" + _telefono + "'";
                try
                {
                    rs = persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
                if(rs.RecordCount > 0)
                {
                    _Existe = true;
                    persistencia.cn.Close();
                }
                else
                {
                    _Existe = false;
                    persistencia.cn.Close();
                }
            }

        }
    }
}
