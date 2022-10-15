using System;
using System.Collections.Generic;
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

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void BuscarDatosProducto()
        {
            persistencia.AbrirConexion();
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
            persistencia.AbrirConexion();
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
            persistencia.AbrirConexion();
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
            persistencia.AbrirConexion();
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
    }
}
