using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class RealizaVenta
    {
        protected string _idCompra;
        protected string _idAdministrativo;
        protected string _idCliente;
        protected string _idProducto;
        protected bool _Realizado;

        public string IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }
        public string IdAdministrativo
        {
            get { return _idAdministrativo; }
            set { _idAdministrativo = value; }
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
        public bool Realizado
        {
            get { return _Realizado; }
            set { _Realizado = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void RealizarVenta()
        {
            persistencia.AbrirConexion();
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into realiza_venta(ID_Compra, ID_Administrativo, ID_Cliente, ID_Producto) values" +
                    "('" + _idCompra + "','" + _idAdministrativo + "','" + _idCliente + "','" + _idProducto + "')";

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
