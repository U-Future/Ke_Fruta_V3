using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Windows.Forms;

namespace Ke_Fruta.Negocios
{
    internal class Notificar
    {
        protected string _idCompra;
        protected string _email;
        protected string _FSiembra;
        protected string _FCosecha;
        protected string _Nombre;
        protected string _idSec;
        protected string _Cultivo;
        protected string _idCliente;

        public string IdCompra 
        { 
            get { return _idCompra; } 
            set { _idCompra = value; } 
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string FSiembra
        {
            get { return _FSiembra; }
            set { _FSiembra = value; }
        }
        public string FCosecha
        {
            get { return _FCosecha; }
            set { _FCosecha = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string IdSec
        {
            get { return _idSec; }
            set { _idSec = value; }
        }
        public string Cultivo
        {
            get { return _Cultivo; }
            set { _Cultivo = value; }
        }
        public string idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void NotificarSiembraCosecha()
        {
            string htmlString = @"<body><style> body { font-family: Arial, Helvetica, sans-serif; color: green } </style> " +
                "<h1>Notificación de Siembra y Cosecha</h1> <p>Estimado " + _Nombre + ".<br> Le notificamos que la proxima siembra y cosecha del Sector N°"+_idSec+ "<br>" +
                "sera: <br> Fecha de Siembra: " + _FSiembra +" <br> Fecha de Cosecha: " + _FCosecha + "<br>Cultivo: "+_Cultivo+"</p><br>" +
                "<p>Saludos Cordiales,<br>Ke Fruta cooperativa agraria.</p></body>";

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("kefruta14@gmail.com");
                message.To.Add(new MailAddress(_email));
                message.Subject = "Ke Fruta Siembras y Cosechas";
                message.IsBodyHtml = true;
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("kefruta14@gmail.com", "pttcafstysfotpln");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void NotificarCompra()
        {
            if (persistencia.cn.State == 0)
            {
                persistencia.AbrirConexion();
            }
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if (persistencia.cn.State != 0)
            {
                sql = "Select ID_Compra, ID_Cliente, ID_Producto, Cantidad,Costo, Fecha_de_Compra, Estado " +
                    "from compra where ID_Cliente = '" + _idCliente + "' and ID_Compra = (select max(ID_Compra) ID_Compra from compra)";

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
                    string idPer, email, nombre, idPro, cantidad, costo;
                    _idCompra = Convert.ToString(rs.Fields[0].Value);
                    idPer = Convert.ToString(rs.Fields[1].Value);
                    idPro = Convert.ToString(rs.Fields[2].Value);
                    cantidad = Convert.ToString(rs.Fields[3].Value);
                    costo = Convert.ToString(rs.Fields[4].Value);

                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Select * from usuario where ID = '"+idPer+"'";

                        try
                        {
                            rs1 = persistencia.cn.Execute(sql1, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }

                        if (rs1.RecordCount > 0)
                        {
                            email = Convert.ToString(rs1.Fields[3].Value);
                            nombre = Convert.ToString(rs1.Fields[1].Value);
                            persistencia.cn.Close();
                            string htmlString = @"<body><style> body { font-family: Arial, Helvetica, sans-serif; color: green } </style> " +
                            "<h1>Notificación de Compra</h1> " +
                            "<p>Estimado " + nombre + ".<br> " +
                            "Le notificamos que su Compra N°" + _idCompra + " a sido registrada, esperamos que la recoja en <br> " +
                            "nuestras oficinas, si deseea que nosotros se lo entreguemos, comuniquese por <br>" +
                            "nuestro Email: kefruta14@gmail.com.</p><br>" +
                            "<p> <h2>Usted compro: </h2><br>" +
                            "ID Producto: "+ idPro + "<br>"+
                            "Cantidad: "+ cantidad + "<br>"+
                            "Costo: "+costo+ "</p><br>" +
                            "<p>Saludos Cordiales<br>Ke Fruta cooperativa agraria.</p></body>";

                            try
                            {
                                MailMessage message = new MailMessage();
                                SmtpClient smtp = new SmtpClient();
                                message.From = new MailAddress("kefruta14@gmail.com");
                                message.To.Add(new MailAddress(email));
                                message.Subject = "Ke Fruta Compras";
                                message.IsBodyHtml = true;
                                message.Body = htmlString;
                                smtp.Port = 587;
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("kefruta14@gmail.com", "pttcafstysfotpln");
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Send(message);
                            }
                            catch (SmtpException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }

                }
            }
        }
        }
    }

