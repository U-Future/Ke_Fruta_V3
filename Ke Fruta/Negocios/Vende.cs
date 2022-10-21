using Ke_Fruta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Vende
    {
        protected string _IdProductor;
        protected string _IdInsumo;
        protected string _Nombre;
        protected string _Cantidad;
        protected string _Precio;
        protected string _KG;
        protected bool _Realizado;

        public string IdProductor
        {
            get { return _IdProductor; }
            set { _IdProductor = value; }
        }
        public string IdInsumo
        {
            get { return _IdInsumo; }
            set { _IdInsumo = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public string Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public string KG
        {
            get { return _KG; }
            set { _KG = value; }
        }
        public bool Realizado
        {
            get { return _Realizado; }
            set { _Realizado = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();
        public void Vender()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql;
            object cantfilas;

            if(persistencia.cn.State != 0)
            {
                sql = "Insert into vende(ID_Productor, ID_Producto, Nombre, Cantidad, Costo) values" +
                    "('" + _IdProductor + "','" + _IdInsumo + "', '" + _Nombre + "', '" + _Cantidad + "','" + _Precio + "')";
                //try
                //{
                    persistencia.cn.Execute(sql, out cantfilas);
                    _Realizado = true;
                    persistencia.cn.Close();
                //}
                //catch
                //{
                //    _Realizado = false;
                //    persistencia.cn.Close();
                //    return;
                //}
            }
        }
    }
}
