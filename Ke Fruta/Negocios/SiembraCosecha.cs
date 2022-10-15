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
        protected List<string> _ListarPro = new List<string>();
        protected List<string> _ListarSec = new List<string>();
        protected List<string> _ListarFSie = new List<string>();
        protected List<string> _ListarFCos = new List<string>();
        protected List<string> _ListarCultivo = new List<string>();
        protected DataTable _dt = new DataTable();

        public DataTable dt
        {
            get { return _dt; }
        }

        public List<string> ListarPro
        {
            get { return _ListarPro; }
            set { _ListarPro = value; }
        }
        public string IdPro
        {
            get { return _idPro; }
            set { _idPro = value; }
        }
        public List<string> ListarSec
        {
            get { return _ListarSec; }
            set { _ListarSec = value; }
        }
        public string IdSec
        {
            get { return _idSec; }  
            set { _idSec = value; }
        }
        public List<string> ListarFSie
        {
            get { return _ListarFSie; }
            set { _ListarFSie = value; }
        }
        public string FSie
        {
            get { return _FSie; }
            set { _FSie = value; }
        }
        public List<string> ListarFCos
        {
            get { return _ListarFCos; }
            set { _ListarFCos = value; }
        }
        public string FCos
        {
            get { return _FCos; }
            set { _FCos = value; }
        }
        public List<string> ListarCultivo
        {
            get { return _ListarCultivo; }
            set { _ListarCultivo = value; }
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
            persistencia.AbrirConexion();
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
                    return;
                }
                if(rs.RecordCount > 0)
                {
                    _Existe = true;
                    _idPro = Convert.ToString(rs.Fields[1].Value);
                }
                else
                {
                    _Existe = false;
                }
            }
        }
        public void ModificarSiembraCosecha()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "UPDATE siembra_cosecha SET Fecha_Siembra = '" + _FSie + "', Fecha_Cosecha = '" + _FCos + "', " +
                    "Cultivo = '" + _Cultivo + "' WHERE ID_Sector = '" + _idSec + "' and ID_Productor = '" + IdPro + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
        }
        public void RegistrarSiembraCosecha()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into siembra_cosecha(ID_Sector, ID_Productor, Fecha_Siembra, Fecha_Cosecha, Cultivo) values " +
                    "('" + _idSec + "','" + _idPro + "','" + _FSie + "','" + _FCos + "','" + _Cultivo + "')";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
        }
        //______________________________________
        public void ConsultarSiembraID()
        {
            persistencia.AbrirConexion();
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
                }
                else
                {
                    _Existe = false;
                }
            }
        }
        public void ConsultarSiembraIDPro()
        {
            persistencia.AbrirConexion();
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
                }
                else
                {
                    _Existe = false;
                }

            }
        }

    }
}
