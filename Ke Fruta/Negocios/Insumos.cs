using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Insumos
    {
        protected string _idInsumo;
        protected string _idProducto;
        protected string _idCliente;
        protected string _nombreProducto;
        protected int _Cantidad;
        protected int _kg;
        protected string _tipo;
        protected bool _Realizado;
        protected DataTable _dt = new DataTable();
        protected string _id;
        protected bool _Tengo;

        public string IdInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public string IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public int Kg
        {
            get { return _kg; }
            set { _kg = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public bool Realizado
        {
            get { return _Realizado; }
            set { _Realizado = value; }
        }
        public DataTable dt
        {
            get { return _dt; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool Tengo
        {
            get { return _Tengo; }
            set { _Tengo = value; }
        }

        Metodos metodos = new Metodos();
        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void BuscarDatosProducto()
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
                sql = "Select * from productos where ID_Producto = '" + _idProducto + "'";

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
                    _nombreProducto = Convert.ToString(rs.Fields[1].Value);
                    _tipo = Convert.ToString(rs.Fields[2].Value);
                    _kg = Convert.ToInt32(rs.Fields[5].Value);
                    CargarInsumo();
                }
                
            }
        }
        public void CargarInsumo()
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
                sql = "Select * from insumos where ID_Productor='" + _idCliente + "' and Nombre ='" + _nombreProducto + "' " +
                    "and Tipo ='" + _tipo + "'";

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
                    _idInsumo = Convert.ToString(rs.Fields[1].Value);
                    Modificar();
                }
                else
                {
                    Insertar();
                }
            }

        }
        public void Modificar()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update insumos set Cantidad = Cantidad + '" + _Cantidad + "' " +
                    "where ID_Productor ='" + _idCliente + "' and ID_Insumo ='" + _idInsumo + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                }
                catch
                {
                    _Realizado = false;
                    return;
                }
            }
        }
        public void Insertar()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "insert into insumos(ID_Productor, Nombre, Tipo, KG, Cantidad) " +
                    "values('" + _idCliente + "', '" + _nombreProducto + "', '" + _tipo + "', '" + _kg + "', '" + _Cantidad + "')";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                }
                catch
                {
                    _Realizado = false;
                    return;
                }
            }
        }
        //__________________________________
        public void BuscarMisInsumos()
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
                sql = "select insumos.ID_Productor,insumos.ID_Insumo,insumos.Nombre,insumos.Tipo,insumos.KG,insumos.Cantidad " +
                    "from insumos inner join productor on insumos.ID_Productor = productor.ID_Productor " +
                    "inner join usuario on productor.ID_Productor = usuario.ID where usuario.Nombre = '" + metodos.nombre + "'";

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
                    _Tengo = true;
                    _dt.Columns.Add("ID Insumo");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("KG");
                    _dt.Columns.Add("Cantidad");

                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row["ID Insumo"] = Convert.ToString(rs.Fields[1].Value);
                        row["Nombre"] = Convert.ToString(rs.Fields[2].Value);
                        row["Tipo"] = Convert.ToString(rs.Fields[3].Value);
                        row["KG"] = Convert.ToString(rs.Fields[4].Value);
                        row["Cantidad"] = Convert.ToString(rs.Fields[5].Value);

                        _dt.Rows.Add(row);
                        rs.MoveNext();
                    }
                    persistencia.cn.Close();

                }
                else
                {
                    _Tengo = false;
                }

            }
        }
        public void AgregarProductoExistente()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update insumos set Cantidad = Cantidad + '" + _Cantidad + "' " +
                    "where ID_Productor = '" + _idCliente + "' and ID_Insumo = '" + _idInsumo + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                    persistencia.cn.Close();
                }
                catch
                {
                    _Realizado = false;
                    persistencia.cn.Close();
                    return;
                }
            }

        }
        public void QuitarProductoExistente()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update insumos set Cantidad = Cantidad - '" + _Cantidad + "' " +
                   "where ID_Productor = '" + _idCliente + "' and ID_Insumo = '" + _idInsumo + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                    persistencia.cn.Close();
                }
                catch
                {
                    _Realizado = false;
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        public void VerificarExistencia()
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
                sql = "Select * from insumos " +
                    "where ID_Productor = '" + _idCliente + "' and ID_Insumo = '" + _idInsumo + "'";
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
                    _Tengo = true;
                    _Cantidad = Convert.ToInt32(rs.Fields[4].Value);
                    persistencia.cn.Close();
                }
                else
                {
                    _Tengo = false;
                    persistencia.cn.Close();
                }
            }
        }
        public void AgregarInsumoNoExistente()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into insumos(ID_Productor, Nombre, Tipo, KG, Cantidad) values" +
                    "('" + _idCliente + "','" + _nombreProducto + "','Agricola','" + _kg + "','" + _Cantidad + "')";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                    persistencia.cn.Close();
                }
                catch
                {
                    _Realizado = false;
                    persistencia.cn.Close();
                    return;
                }
            }
        }
        public void BuscarInsumoAgregado()
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
                sql = "select ID_Productor, max(ID_Insumo) ID, Nombre, Tipo, KG, Cantidad " +
                    "from insumos where ID_Productor = '" + _idCliente + "'";
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
                    _dt.Columns.Add("ID Insumo");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("KG");
                    _dt.Columns.Add("Cantidad");

                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row["ID Insumo"] = Convert.ToString(rs.Fields[1].Value);
                        row["Nombre"] = Convert.ToString(rs.Fields[2].Value);
                        row["Tipo"] = Convert.ToString(rs.Fields[3].Value);
                        row["KG"] = Convert.ToString(rs.Fields[4].Value);
                        row["Cantidad"] = Convert.ToString(rs.Fields[5].Value);

                        _dt.Rows.Add(row);
                        rs.MoveNext();
                    }
                    persistencia.cn.Close();
                }
            }
        }
        //_________________________________
        public void CargarMisInsumos()
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
                sql = "select insumos.ID_Productor,insumos.ID_Insumo,insumos.Nombre,insumos.Tipo,insumos.KG,insumos.Cantidad " +
                    "from insumos inner join productor on insumos.ID_Productor = productor.ID_Productor " +
                    "inner join usuario on productor.ID_Productor = usuario.ID where usuario.Nombre = '" + metodos.nombre + "' " +
                    "and insumos.Tipo = 'Agricola'";

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
                    _Tengo = true;
                    _dt.Columns.Add("ID Insumo");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("KG");
                    _dt.Columns.Add("Cantidad");

                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row["ID Insumo"] = Convert.ToString(rs.Fields[1].Value);
                        row["Nombre"] = Convert.ToString(rs.Fields[2].Value);
                        row["Tipo"] = Convert.ToString(rs.Fields[3].Value);
                        row["KG"] = Convert.ToString(rs.Fields[4].Value);
                        row["Cantidad"] = Convert.ToString(rs.Fields[5].Value);

                        _dt.Rows.Add(row);
                        rs.MoveNext();
                    }
                    persistencia.cn.Close();

                }
                else
                {
                    _Tengo = false;
                }

            }
        }
        //_________________________________
        public void BuscarExistenciaInsumo()
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
                sql = "Select * from insumos where ID_Productor = '" + _idCliente + "' and " +
                    "ID_Insumo = '" + _idInsumo + "' and Tipo = 'Agricola'";
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
                    _Tengo = true;
                    _dt.Columns.Add("ID Insumo");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("KG");
                    _dt.Columns.Add("Cantidad");


                    DataRow row = _dt.NewRow();
                    row["ID Insumo"] = Convert.ToString(rs.Fields[1].Value);
                    row["Nombre"] = Convert.ToString(rs.Fields[2].Value);
                    row["Tipo"] = Convert.ToString(rs.Fields[3].Value);
                    row["KG"] = Convert.ToString(rs.Fields[4].Value);
                    row["Cantidad"] = Convert.ToString(rs.Fields[5].Value);

                    _dt.Rows.Add(row);

                    _idInsumo = Convert.ToString(rs.Fields[1].Value);
                    _nombreProducto = Convert.ToString(rs.Fields[2].Value);
                    _tipo = Convert.ToString(rs.Fields[3].Value);
                    _kg = Convert.ToInt32(rs.Fields[4].Value);
                    _Cantidad = Convert.ToInt32(rs.Fields[5].Value);
                    persistencia.cn.Close();

                }
                else
                {
                    _Tengo = false;
                }
            }
        }
        public void EliminarInsumo()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update insumos set Cantidad = Cantidad - '" + _Cantidad + "' " +
                    "where ID_Productor = '" + _idCliente + "' and ID_Insumo = '" + _idInsumo + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                    persistencia.cn.Close();
                }
                catch
                {
                    _Realizado = false;
                    persistencia.cn.Close();
                    return;
                }
            }
        }
    }
}
