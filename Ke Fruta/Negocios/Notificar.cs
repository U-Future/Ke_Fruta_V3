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

        Datos.Persistencia persistencia = new Datos.Persistencia();

        public static void EnviarCorreo()
            {
                string htmlString = @"<body><style> body { font-family: Arial, Helvetica, sans-serif; color: green } </style> " +
                "<h1>Notificación</h1> <p>Estimado " + "Lucas" + " " + "Sequeira" + ",<br> Le notificamos que se aproxima una proxima fecha de siembra.<br></p>" +
                "<p>Le recordamos que deberá comprar la siguiente lista de productos previo a la siembra del cultivo:</p><br>" +
                "<p>Le saluda atte,<br>Ke Fruta cooperativa agraria.</p></body>";

                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("kefruta14@gmail.com");
                    message.To.Add(new MailAddress("lucassequeira.134@gmail.com"));
                    message.Subject = "Test";
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
        public void NotificarSiembraCosecha()
        {
            string htmlString = @"<body><style> body { font-family: Arial, Helvetica, sans-serif; color: green } </style> " +
                "<h1>Notificación Ke Fruta</h1> <p>Estimado " + _Nombre + ".<br> Le notificamos que la proxima siembra y cosecha del Sector N°"+_idSec+ "<br>" +
                "sera: <br> Fecha de Siembra: " + _FSiembra +" <br> Fecha de Cosecha: " + _FCosecha + "<br>Cultivo: "+_Cultivo+"</p><br>" +
                "<p>Saludos Cordiales,<br>Ke Fruta cooperativa agraria.</p></body>";

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("kefruta14@gmail.com");
                message.To.Add(new MailAddress(_email));
                message.Subject = "Ke Fruta: Aviso";
                message.IsBodyHtml = true;
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("kefruta14@gmail.com", "pttcafstysfotpln");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("Se notifico al Productor de la Siembra y Cosecha." , "Aviso");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void NotificarCompra()
        {
            persistencia.AbrirConexion();
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from compra where ID_Compra ='"+_idCompra+"'";

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

                            string htmlString = @"<body><style> body { font-family: Arial, Helvetica, sans-serif; color: green } </style> " +
                            "<h1>Notificación de Compra</h1> " +
                            "<p>Estimado " + nombre + ".<br> " +
                            "Le notificamos que su Compra N°" + _idCompra + "a sido registrada, esperamos que la recoja en <br> " +
                            "nuestras oficinas, si deseea que nosotros se lo entreguemos, comuniquese con nosotros por <br>" +
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

