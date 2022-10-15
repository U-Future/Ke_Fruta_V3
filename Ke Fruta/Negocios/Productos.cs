using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Productos
    {
        protected string _idProducto;
        protected string _Nombre;
        protected string _Tipo;
        protected string _Fabricante;
        protected int _Precio;
        protected int _KG;
        protected int _Stock;
        protected int _Cantidad;
        protected bool _Quitado;
        protected bool _Agregado;
        protected bool _Existe;
        protected bool _Registrado;
        protected bool _Suficiente;
        protected DataTable _dt = new DataTable();
        
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        public string Fabricante
        {
            get { return _Fabricante; }
            set { _Fabricante = value; }
        }
        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public int KG
        {
            get { return _KG; }
            set { _KG = value; }
        }
        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public bool Quitado
        {
            get { return _Quitado; }
            set { _Quitado = value; }
        }
        public bool Agregado
        {
            get { return _Agregado; }
            set { _Agregado = value; }
        }
        public bool Existe
        {
            get { return _Existe; }
            set { _Existe = value; }
        }
        public bool Registrado
        {
            get { return _Registrado; }
            set { _Registrado = value; }
        }
        public bool Suficiente
        {
            get { return _Suficiente; }
            set { _Suficiente = value; }
        }
        public DataTable dt
        {
            get { return _dt; }
        }
        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void Modificar()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update productos set Stock = Stock - '" + _Cantidad + "' where ID_Producto = '" + _idProducto + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Quitado = true;
                }
                catch
                {
                    _Quitado = false;
                    return;
                }
            }
        }
        public void BuscarProducto()
        {
            persistencia.AbrirConexion();
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
                    return;
                }
                if(rs.RecordCount > 0)
                {
                    _Existe = true;

                    _dt.Columns.Add("ID Producto");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("Fabricante");
                    _dt.Columns.Add("Kg");
                    _dt.Columns.Add("Precio");
                    _dt.Columns.Add("Stock");
                    
                    DataRow row = _dt.NewRow();
                    row[0] = Convert.ToString(rs.Fields[0].Value);
                    row[1] = Convert.ToString(rs.Fields[1].Value);
                    row[2] = Convert.ToString(rs.Fields[2].Value);
                    row[3] = Convert.ToString(rs.Fields[3].Value);
                    row[4] = Convert.ToInt32(rs.Fields[5].Value);
                    row[5] = Convert.ToInt32(rs.Fields[4].Value);
                    row[6] = Convert.ToInt32(rs.Fields[7].Value);

                    _dt.Rows.Add(row);
                }
                else
                {
                    _Existe = false;
                }
            }
        }
        public void ListarTodo()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from productos";

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

                    _dt.Columns.Add("ID Producto");
                    _dt.Columns.Add("Nombre");
                    _dt.Columns.Add("Tipo");
                    _dt.Columns.Add("Fabricante");
                    _dt.Columns.Add("Kg");
                    _dt.Columns.Add("Precio");
                    _dt.Columns.Add("Stock");

                    while (!rs.EOF)
                    {
                        DataRow row = _dt.NewRow();
                        row[0] = Convert.ToString(rs.Fields[0].Value);
                        row[1] = Convert.ToString(rs.Fields[1].Value);
                        row[2] = Convert.ToString(rs.Fields[2].Value);
                        row[3] = Convert.ToString(rs.Fields[3].Value);
                        row[4] = Convert.ToInt32(rs.Fields[5].Value);
                        row[5] = Convert.ToInt32(rs.Fields[4].Value);
                        row[6] = Convert.ToInt32(rs.Fields[7].Value);

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
        //_____________________________
        public void Registrar()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            switch (_Tipo)
            {
                case "Semilla":
                    if(persistencia.cn.State != 0)
                    {
                        sql = "Insert into productos(Nombre, Tipo, Fabricante, Precio, KG, Zona, Stock) values" +
                            "('" + _Nombre + "','Semilla','" + _Fabricante + "','" + _Precio + "','" + _KG + "','Este','0')";
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            _Registrado = true;
                        }
                        catch
                        {
                            _Registrado = false;
                            return;
                        }
                    }
                    break;
                case "Fungicida":
                    if(persistencia.cn.State != 0)
                    {
                        sql = "Insert into productos(Nombre, Tipo, Fabricante, Precio, KG, Zona, Stock) values" +
                            "('" + _Nombre + "','Fungicida','" + _Fabricante + "','" + _Precio + "','" + _KG + "','Oeste','0')";
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            _Registrado = true;
                        }
                        catch
                        {
                            _Registrado = false;
                            return;
                        }
                    }
                    break;
                case "Herbicida":
                    if (persistencia.cn.State != 0)
                    {
                        sql = "Insert into productos(Nombre, Tipo, Fabricante, Precio, KG, Zona, Stock) values" +
                            "('" + _Nombre + "','Herbicida','" + _Fabricante + "','" + _Precio + "','" + _KG + "','Oeste','0')";
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            _Registrado = true;
                        }
                        catch
                        {
                            _Registrado = false;
                            return;
                        }
                    }
                    break;
                case "Fertilizante":
                    if (persistencia.cn.State != 0)
                    {
                        sql = "Insert into productos(Nombre, Tipo, Fabricante, Precio, KG, Zona, Stock) values" +
                            "('" + _Nombre + "','Fertilizante','" + _Fabricante + "','" + _Precio + "','" + _KG + "','Oeste','0')";
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            _Registrado = true;
                        }
                        catch
                        {
                            _Registrado = false;
                            return;
                        }
                    }
                    break;
            }
        }
        public void BuscarUltimo()
        {
            persistencia.AbrirConexion();
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if(persistencia.cn.State != 0)
            {
                sql = "select max(ID_Producto) ID_Producto from productos";

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
                    if(persistencia.cn.State != 0)
                    {
                        sql1 = "select * from productos where ID_Producto = '" + rs.Fields[0].Value + "'";

                        try
                        {
                            rs1 = persistencia.cn.Execute(sql1, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                        if(rs1.RecordCount > 0)
                        {
                            _idProducto = Convert.ToString(rs1.Fields[0].Value);
                            _Nombre = Convert.ToString(rs1.Fields[1].Value);
                            _Tipo = Convert.ToString(rs1.Fields[2].Value);
                            _Fabricante = Convert.ToString(rs1.Fields[3].Value);
                            _Precio = Convert.ToInt32(rs1.Fields[4].Value);
                            _KG = Convert.ToInt32(rs1.Fields[5].Value);
                        }
                        
                    }
                }
            }
        }
        //_____________________________
        public void Agregar()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Update productos set Stock = Stock + '" + _Cantidad + "' where ID_Producto ='" + _idProducto + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Agregado = true;
                }
                catch
                {
                    _Agregado = false;
                    return;
                }
            }
        }
        public void Quitar()
        {
            persistencia.AbrirConexion();
            string sql, sql1;
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
                    return;
                }
                if(rs.RecordCount > 0)
                {
                    int stock = Convert.ToInt32(rs.Fields[7].Value);
                    if (stock < _Cantidad)
                    {
                        _Suficiente = false;
                    }
                    else
                    {
                        _Suficiente = true;
                        if(persistencia.cn.State != 0)
                        {
                            sql1 = "Update productos set Stock = Stock - '" + _Cantidad + "' where ID_Producto = '" + _idProducto + "'";
                            try
                            {
                                persistencia.cn.Execute(sql1, out cantfilas);
                                _Quitado = true;
                            }
                            catch
                            {
                                _Quitado = false;
                                return;
                            }
                        }
                    }
                }
            }
        }
        //_____________________________
        public void BajaProducto()
        {
            persistencia.AbrirConexion();
            string sql, sql1, sql2;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql2 = "Delete from realiza_venta where ID_Producto = '" + _idProducto + "'";
                try
                {
                    persistencia.cn.Execute(sql2, out cantfilas);
                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Delete from compra where ID_Producto = '" + _idProducto + "'";
                        try
                        {
                            persistencia.cn.Execute(sql1, out cantfilas);
                            if (persistencia.cn.State != 0)
                            {
                                sql = "Delete from productos where ID_Producto = '" + _idProducto + "'";
                                try
                                {
                                    persistencia.cn.Execute(sql, out cantfilas);
                                    _Quitado = true;
                                }
                                catch
                                {
                                    _Quitado = false;
                                    return;
                                }
                            }
                        }
                        catch
                        {
                            _Quitado = false;
                            return;
                        }
                    }
                }
                catch
                {
                    _Quitado = false;
                    return;
                }
            }
        }
    }
}
