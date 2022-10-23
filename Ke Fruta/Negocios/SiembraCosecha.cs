using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class SiembraCosecha
    {
        protected string _idPro;
        protected string _idSec;
        protected string _FSie;
        protected string _FCos;
        protected string _Cultivo;
        protected bool _Existe;
        protected DataTable _dt = new DataTable();

        public DataTable dt
        {
            get { return _dt; }
        }
        public string IdPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }
        public string IdSec
        {
            get { return _idSec; }  
            set { _idSec = value; }
        }
        public string FSie
        {
            get { return _FSie; }
            set { _FSie = value; }
        }
        public string FCos
        {
            get { return _FCos; }
            set { _FCos = value; }
        }
        public string Cultivo
        {
            get { return _Cultivo; }
            set { _Cultivo = value; }
        }
        public bool Existe
        {
            get { return _Existe; }
            set { _Existe = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void BuscarSiembraCosecha()
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
                sql = "Select * from siembra_cosecha where ID_Sector ='" + _idSec + "'";

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
                    _Existe = true;
                    _idPro = Convert.ToString(rs.Fields[1].Value);
                    persistencia.cn.Close();
                }
                else
                {
                    _Existe = false;
                    persistencia.cn.Close();
                }
            }
        }
        public void ModificarSiembraCosecha()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "UPDATE siembra_cosecha SET Fecha_Siembra = '" + _FSie + "', Fecha_Cosecha = '" + _FCos + "', " +
                    "Cultivo = '" + _Cultivo + "' WHERE ID_Sector = '" + _idSec + "' and ID_Productor = '" + IdPro + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    persistencia.cn.Close();
                    BuscarDatosProductorNotificar();
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        public void RegistrarSiembraCosecha()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into siembra_cosecha(ID_Sector, ID_Productor, Fecha_Siembra, Fecha_Cosecha, Cultivo) values " +
                    "('" + _idSec + "','" + _idPro + "','" + _FSie + "','" + _FCos + "','" + _Cultivo + "')";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    persistencia.cn.Close();
                    BuscarDatosProductorNotificar();
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        //______________________________________
        public void ConsultarSiembraID()
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
                sql = "Select * from siembra_cosecha where ID_Sector ='" + _idSec + "'";
                try
                {
                    rs = persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    _Existe = true;
                    _dt.Columns.Add("ID Productor");
                    _dt.Columns.Add("Sector");
                    _dt.Columns.Add("Fecha Siembra");
                    _dt.Columns.Add("Fecha Cosecha");
                    _dt.Columns.Add("Cultivo");

                    DataRow row = _dt.NewRow();
                    row["ID Productor"] = Convert.ToString(rs.Fields[1].Value);
                    row["Sector"] = Convert.ToString(rs.Fields[0].Value);
                    row["Fecha Siembra"] = rs.Fields[2].Value.ToString("yyyy-MM-dd");
                    row["Fecha Cosecha"] = rs.Fields[3].Value.ToString("yyyy-MM-dd");
                    row["Cultivo"] = Convert.ToString(rs.Fields[4].Value);

                    _dt.Rows.Add(row);
                    _idPro = Convert.ToString(rs.Fields[1].Value);
                    _idSec = Convert.ToString(rs.Fields[0].Value);
                    persistencia.cn.Close();
                }
                else
                {
                    _Existe = false;
                    persistencia.cn.Close();
                }
            }
        }
        public void ConsultarSiembraIDPro()
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
                sql = "Select * from siembra_cosecha where ID_Productor= '" + _idPro + "'";

                try
                {
                    rs = persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    persistencia.cn.Close();
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    _dt.Columns.Add("ID Productor");
                    _dt.Columns.Add("Sector");
                    _dt.Columns.Add("Fecha Siembra");
                    _dt.Columns.Add("Fecha Cosecha");
                    _dt.Columns.Add("Cultivo");
                    _Existe = true;
                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row["ID Productor"] = Convert.ToString(rs.Fields[1].Value);
                        row["Sector"] = Convert.ToString(rs.Fields[0].Value);
                        row["Fecha Siembra"] = rs.Fields[2].Value.ToString("yyyy-MM-dd");
                        row["Fecha Cosecha"] = rs.Fields[3].Value.ToString("yyyy-MM-dd");
                        row["Cultivo"] = Convert.ToString(rs.Fields[4].Value);

                        _dt.Rows.Add(row);
                        rs.MoveNext();
                    }
                    persistencia.cn.Close();
                }
                else
                {
                    _Existe = false;
                    persistencia.cn.Close();
                }

            }
        }
        //______________________________________
        public void BuscarDatosProductorNotificar()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;
            ADODB.Recordset rs;

            if(persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where ID = '" + _idPro + "'";
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
                    Negocios.Notificar notificar = new Negocios.Notificar();
                    notificar.Email = Convert.ToString(rs.Fields[3].Value);
                    notificar.IdSec = _idSec;
                    notificar.Nombre = Convert.ToString(rs.Fields[1].Value);
                    notificar.FCosecha = _FCos;
                    notificar.FSiembra = _FSie;
                    notificar.Cultivo = _Cultivo;
                    notificar.NotificarSiembraCosecha();
                    persistencia.cn.Close();
                }
                
            }
        }
    }
}
