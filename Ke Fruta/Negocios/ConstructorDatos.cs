using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class ConstructorDatos
    {

        protected string _id;
        protected string _idadm;
        protected string _idpro;
        protected string _idcli;

        protected string _rutadm;
        protected string _rutpro;
        protected string _rutcli;

        protected string _nombre;
        protected string _password;
        protected string _tipo;
        protected string _tipocultivo;
        protected List<string> _telefonos;
        protected List<string> _idsector;
        protected string _canthect;
        protected string _estado;
        protected string _cantidad;
        protected string _costo;
        protected string _fechasie;
        protected string _fechacos;
        protected string _fechaventa;
        protected string _fechacompra;
        protected string _fabricante;
        protected string _precio;
        protected string _kg;
        protected string _zona;

        public string Id
        {
            get { return (_id); }
            set { _id = value; }
        }
        public string Idadm
        {
            get { return _idadm; }
            set { _idadm = value; }
        }
        public string Idpro
        {
            get { return _idpro; }
            set { _idpro = value; }
        }
        public string Idcli
        {
            get { return _idcli; }
            set { _idcli = value; }
        }
        public string Rutadm
        {
            get { return _rutadm; }
            set { _rutadm = value; }
        }
        public string Rutpro
        {
            get { return _rutpro; }
            set { _rutpro = value; }
        }
        public string Rutcli
        {
            get { return _rutcli;  }
            set { _rutcli = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Tipocultivo
        {
            get { return _tipocultivo; }
            set { _tipocultivo = value; }
        }
        public List<string> Telefono
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }
        public List<string> Idsector
        {
            get { return _idsector; }
            set { _idsector = value; }
        }
        public string Canthect
        {
            get { return _canthect; }
            set { _canthect = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public string Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public string Fechasie
        {
            get { return _fechasie; }
            set { _fechasie = value; }
        }
        public string Fechacos
        {
            get { return _fechacos; }
            set { _fechacos = value; }
        }
        public string Fechaventa
        {
            get { return _fechaventa; }
            set { _fechaventa = value; }
        }
        public string Fechacompra
        {
            get { return _fechacompra; }
            set { _fechacompra = value; }
        }
        public string Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Kg
        {
            get { return _kg; }
            set { _kg = value; }
        }
        public string Zona
        {
            get { return _zona; }
            set { _zona = value; }
        }



    }
}
