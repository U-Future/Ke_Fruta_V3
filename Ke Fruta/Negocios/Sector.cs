using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Sector
    {
        protected string _idSec;
        protected string _idPro;
        protected string _cantidadhect;
        protected bool _ExistecSector;
        protected string _Cultivo;

        public string idSec
        {
            get { return _idSec; }
            set { _idSec = value; }
        }
        public string idPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }
        public string canidadhect
        {
            get { return _cantidadhect; }
            set { _cantidadhect = value; }
        }
        public bool ExisteSector
        {
            get { return _ExistecSector; }
            set { _ExistecSector = value; }
        }
        public string Cultivo
        {
            get { return _Cultivo; }
            set { _Cultivo = value; }
        }
        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void AgregarSector()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into sector(ID_Productor, ID_Sector, Tipo_Cultivo, Cant_Hectareas, Estado) values" +
                    "('" + _idPro + "','" + _idSec + "','','" + _cantidadhect + "','Descanso')";

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
        public void EliminarSector()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql, sql1, sql2;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Delete from sector where ID_Productor ='" + _idPro + "' and " +
                    "ID_Sector='" + _idSec + "'";
                sql1 = "Delete from gestiona where ID_Sector= '" + _idSec + "'";//Gestiona
                sql2 = "Delete from siembra_cosecha where ID_Sector= '" + _idSec + "'";//Siembra_Cosecha

                try
                {
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql1, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql2, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql, out cantfilas);
                    }
                    persistencia.cn.Close();
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        public void BuscarSector()
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
                sql = "Select * from sector where ID_Sector ='" + _idSec + "'";

                try
                {
                    rs = persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
                if(rs.RecordCount > 0)
                {
                    _ExistecSector = true;
                    _idPro = Convert.ToString(rs.Fields[0].Value);
                    persistencia.cn.Close();
                }
                else
                {
                    _ExistecSector = false;
                    persistencia.cn.Close();
                }
            }
        }
        //________________________
        public void Actualizar()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update sector set Tipo_Cultivo ='" + _Cultivo + "', " +
                    "Estado ='Produccion' where ID_Sector ='" + _idSec + "' and ID_Productor ='" + _idPro + "'";
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
