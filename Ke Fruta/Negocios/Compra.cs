using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Compra
    {
        protected string _idCompra;
        protected string _idCliente;
        protected string _idProducto;
        protected string _NombreProducto;
        protected int _Cantidad;
        protected int _Precio;
        protected int _Costo;
        protected int _KG;
        protected string _fechaCompra;
        protected string _NombreCliente;
        protected string _TipoCliente;
        protected bool _Existe;
        protected DataTable _dt = new DataTable();
        protected bool _Concretado;

        public string IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }
        public string IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public int Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }
        public int KG
        {
            get { return _KG; }
            set { _KG = value; }
        }
        public string FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }
        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }
        public string TipoCliente
        {
            get { return _TipoCliente; }
            set { _TipoCliente = value; }
        }
        public bool Existe
        {
            get { return _Existe; }
            set { _Existe = value; }
        }
        public DataTable dt
        {
            get { return _dt; }
        }
        public bool Concretado
        {
            get { return _Concretado; }
            set { _Concretado = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void CargarTableCompra()
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
                sql = "Select * from compra where ID_Compra ='" + _idCompra + "' and Estado = 'Pendiente'";

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

                    _dt.Columns.Add("ID Compra");
                    _dt.Columns.Add("ID Cliente");
                    _dt.Columns.Add("ID Producto");
                    _dt.Columns.Add("Cantidad");
                    _dt.Columns.Add("Costo");
                    _dt.Columns.Add("Fecha Compra");

                    DataRow row = _dt.NewRow();
                    row["ID Compra"] = Convert.ToString(rs.Fields[0].Value);
                    row["ID Cliente"] = Convert.ToString(rs.Fields[1].Value);
                    row["ID Producto"] = Convert.ToString(rs.Fields[2].Value);
                    row["Cantidad"] = Convert.ToInt32(rs.Fields[3].Value);
                    row["Costo"] = Convert.ToInt32(rs.Fields[4].Value);
                    row["Fecha Compra"] = rs.Fields[5].Value.ToString("yyyy-MM-dd");

                    _dt.Rows.Add(row);

                    _idCliente = Convert.ToString(rs.Fields[1].Value);
                    _idProducto = Convert.ToString(rs.Fields[2].Value);
                    _Cantidad = Convert.ToInt32(rs.Fields[3].Value);

                    persistencia.cn.Close();
                }
                else
                {
                    _Existe = false;
                    persistencia.cn.Close();
                }
            }
        }
        public void CargarTablePendientes()
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
                sql = "Select * from compra where Estado = 'Pendiente'";

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
                    
                        _dt.Columns.Add("ID Compra");
                        _dt.Columns.Add("ID Cliente");
                        _dt.Columns.Add("ID Producto");
                        _dt.Columns.Add("Cantidad");
                        _dt.Columns.Add("Costo");
                        _dt.Columns.Add("Fecha Compra");
                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row["ID Compra"] = Convert.ToString(rs.Fields[0].Value);
                        row["ID Cliente"] = Convert.ToString(rs.Fields[1].Value);
                        row["ID Producto"] = Convert.ToString(rs.Fields[2].Value);
                        row["Cantidad"] = Convert.ToInt32(rs.Fields[3].Value);
                        row["Costo"] = Convert.ToInt32(rs.Fields[4].Value);
                        row["Fecha Compra"] = rs.Fields[5].Value.ToString("yyyy-MM-dd");

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
        //___________________________
        public void ConcretarCompra()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update compra set Estado = 'Concretado' where ID_Compra = '" + _idCompra + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Concretado = true;
                    persistencia.cn.Close();
                }
                catch
                {
                    _Concretado = false;
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        public void BuscarDatosCliente()
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
                sql = "select ID,Nombre,Tipo,Email from usuario us inner join cliente cli, compra co " +
                    "where us.ID=cli.ID_Cliente and cli.ID_Cliente=co.ID_Cliente and co.ID_Compra= '" + _idCompra + "'";
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
                    _idCliente = Convert.ToString(rs.Fields[0].Value);
                    _NombreCliente = Convert.ToString(rs.Fields[1].Value);
                    _TipoCliente = Convert.ToString(rs.Fields[2].Value);
                    persistencia.cn.Close();
                }
            }
        }
        //___________________________
        public void GenerarCompra()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            sql = "Insert into compra(ID_Cliente, ID_Producto, Cantidad, Costo, Estado) values " +
                "('" + _idCliente + "','" + _idProducto + "','" + _Cantidad + "','" + _Costo + "','Pendiente')";
            try
            {
                persistencia.cn.Execute(sql, out cantfilas);
                _Concretado = true;
                persistencia.cn.Close();
            }
            catch
            {
                _Concretado = false;
                persistencia.cn.Close();
                return;
            }
        }
        public void Verificar()
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
                sql = "Select * from productos where ID_Producto = '" + _idProducto + "'";
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
                    _idProducto = Convert.ToString(rs.Fields[0].Value);
                    _NombreProducto = rs.Fields[1].Value;
                    _Precio = Convert.ToInt32(rs.Fields[4].Value);
                    _Cantidad = Convert.ToInt32(rs.Fields[7].Value);
                }
                else
                {
                    _Existe = false;
                }
            }
        }
    }
}
