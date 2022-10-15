using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ke_Fruta
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        //____________________________________________________________________________________________________________
        /*public static void BuscarUsuario(string usuario)
        {
            string sql;
            ADODB.Recordset rs;
            object cantfilas;

            if (cn.State != 0)
            {
                sql = "Select Tipo from usuario where Nombre= '" + usuario + "'";
                try
                {
                    rs = cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    //MessageBox.Show(sql);

                    switch (rs.Fields[0].Value.ToString())
                    {
                        case "A"://Administrativo
                            Administrativo administrativo = new Administrativo();
                            administrativo.Show();
                            break;
                        case "I"://Productor
                            Productor productor = new Productor();
                            productor.Show();
                            break;
                        case "E"://Cliente
                            Compra.Tienda tienda = new Compra.Tienda();
                            tienda.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro a ningun usuario con este nombre");
                }

            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }

        }*/
        //____________________________________________________________________________________________________________
        /*public static void AltaUsuario(string id, string rut, string nombre, string tipo, string tipocultivo, string pass)
        {
            string sql, sql1, sql2, sql3, sql4, sql5, sql6;
            object cantfilas;

            if (cn.State != 0)
            {
                sql = "Insert into usuario(ID, Nombre, Contrasenia, Tipo) values ('" + id + "','" + nombre + "','" + pass + "','" + tipo + "')";//Insertar en Usuario
                sql1 = "Insert into cliente(ID_Cliente, RUT_Cliente) values ('" + id + "','" + rut + "')";//Insertar en Cliente
                sql2 = "Insert into productor(ID_Productor, RUT_Productor, Tipo_Cultivo) values ('" + id + "','" + rut + "','" + tipocultivo + "')";//Insertar en Productor
                sql3 = "Create User '" + nombre + "'@localhost identified by '" + pass + "'";//Crear Usuario
                sql4 = "Grant select, insert, delete, update, create user, drop, grant option on *.* to '" + nombre + "'@localhost";//Permisos Administrativo
                sql5 = "Grant insert, delete, update, select on *.* to '" + nombre + "'@localhost";//Permisos Productor
                sql6 = "Grant insert, select on *.* to '" + nombre + "'@localhost";//Permisos Externos


                switch (tipo)
                {
                    case "A":
                        if (cn.State != 0)
                        {
                            try
                            {

                                if (cn.State != 0)
                                {
                                    cn.Execute(sql3, out cantfilas);
                                }
                                if (cn.State != 0)
                                {
                                    cn.Execute(sql4, out cantfilas);
                                }
                                if (cn.State != 0)
                                {
                                    cn.Execute(sql, out cantfilas);
                                }

                                MessageBox.Show("Se agrego correctamente a: " + nombre);


                            }
                            catch
                            {
                                return;
                            }
                        }
                        break;
                    case "I":
                        try
                        {
                            if (cn.State != 0)
                            {
                                cn.Execute(sql3, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql5, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql1, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql2, out cantfilas);
                            }

                            MessageBox.Show("Se agrego correctamente a: " + nombre);

                        }
                        catch
                        {
                            return;
                        }
                        break;
                    case "E":
                        try
                        {
                            if (cn.State != 0)
                            {
                                cn.Execute(sql3, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql6, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql1, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                            MessageBox.Show("Se agrego correctamente a: " + nombre);


                        }
                        catch
                        {
                            return;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void BajaUsuarioProductor(string id, string nombre)
        {
            string sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11;
            object cantfilas;

            if (cn.State != 0)
            {
                sql5 = "Delete from gestiona where ID_Productor= '" + id + "'";//Gestiona
                sql6 = "Delete from realiza_venta ID_Cliente= '" + id + "'";//Realiza_Venta
                sql7 = "Delete from compra ID_Cliente= '" + id + "'";//Compra
                sql9 = "Delete from vende ID_Productor= '" + id + "'";//Vende
                sql8 = "Delete from siembra_cosecha ID_Productor= '" + id + "'";//Siembra_Cosecha
                sql3 = "Delete from sector where ID_Productor= '" + id + "'"; //Sector
                sql10 = "Delete from insumos ID_Productor= '" + id + "'";//Insumos
                sql4 = "Delete from productor where ID_Productor= '" + id + "'";//Productor
                sql11 = "Delete from cliente where ID_Cliente= '" + id + "'";//Cliente
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + id + "'";//Usuario
                sql1 = "Drop User '" + nombre + "'@localhost"; //User

                try
                {
                    if (cn.State != 0)
                    {
                        cn.Execute(sql5, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql6, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql7, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql9, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql8, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql3, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql10, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql4, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql11, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql2, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql1, out cantfilas);
                    }

                }
                catch
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void BajaUsuarioCliente(string id, string nombre)
        {
            string sql, sql1, sql2, sql6, sql7, sql11;
            object cantfilas;

            if (cn.State != 0)
            {
                sql6 = "Delete from realiza_venta ID_Cliente= '" + id + "'";//Realiza_Venta
                sql7 = "Delete from compra ID_Cliente= '" + id + "'";//Compra
                sql11 = "Delete from cliente where ID_Cliente= '" + id + "'";//Cliente
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + id + "'";//Usuario
                sql1 = "Drop User '" + nombre + "'@localhost"; //User

                try
                {
                    if (cn.State != 0)
                    {
                        cn.Execute(sql6, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql7, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql11, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql2, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql1, out cantfilas);
                    }

                }
                catch
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void BajaUsuarioAdministrativo(string id, string nombre)
        {
            string sql, sql1, sql2, sql5, sql6, sql11;
            object cantfilas;

            if (cn.State != 0)
            {
                sql5 = "Delete from gestiona where ID_Productor= '" + id + "'";//Gestiona
                sql6 = "Delete from realiza_venta ID_Cliente= '" + id + "'";//Realiza_Venta
                sql11 = "Delete from administrativo where ID_Administrativo= '" + id + "'";//Administrativo
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + id + "'";//Usuario
                sql1 = "Drop User '" + nombre + "'@localhost"; //User

                try
                {
                    if (cn.State != 0)
                    {
                        cn.Execute(sql5, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql6, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql11, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql2, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql1, out cantfilas);
                    }

                }
                catch
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void AltaSector(string id, string rut, string id_sec, string canthect)
        {
            string sql;
            object cantfilas;

            if (cn.State != 0)
            {
                sql = "Insert into sector(ID_Productor, RUT_Productor, ID_Sector, Tipo_Cultivo, Cant_Hectareas, Estado) values ('" + id + "','" + rut + "','" + id_sec + "','" + null + "','" + canthect + "','" + "Descanso" + "')";
                try
                {
                    cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void BajaSector(string id_Sector)
        {
            string sql, sql1, sql2;
            object cantfilas;
            if (cn.State != 0)
            {
                sql = "Delete from sector where ID_Sector= '" + id_Sector + "'";//Sector
                sql1 = "Delete from gestiona where ID_Sector= '" + id_Sector + "'";//Gestiona
                sql2 = "Delete from siembra_cosecha where ID_Sector= '" + id_Sector + "'";//Siembra_Cosecha

                try
                {
                    if (cn.State != 0)
                    {
                        cn.Execute(sql1, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql2, out cantfilas);
                    }
                    if (cn.State != 0)
                    {
                        cn.Execute(sql, out cantfilas);
                    }
                }
                catch
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }

        }*/
        //____________________________________________________________________________________________________________
        /*public static void AltaTelefono(string id, string telefono)
        {
            string sql;
            object cantfilas;

            if (cn.State != 0)
            {
                sql = "Insert into tel_usuario(ID_Usuario, Telefono) values ('" + id + "','" + telefono + "')";

                try
                {
                    cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void BajaTelefono(string telefono)
        {
            string sql;
            object cantfilas;
            if (cn.State != 0)
            {
                sql = "Delete from tel_usuario where Telefono= '" + telefono + "'";
                try
                {
                    cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void ModificarUsuario(string id, string nombre, string tipocultivo, string contra, string tipo)
        {
            string sql, sql1;
            object cantfilas;
            if (cn.State != 0)
            {

                switch (tipo)
                {
                    case "A":
                        sql = "Update usuario set Nombre= '" + nombre + "', Contrasenia= '" + contra + "' where ID= '" + id + "'";
                        try
                        {
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case "I":
                        sql = "Update usuario set Nombre= '" + nombre + "', Contrasenia= '" + contra + "' where ID= '" + id + "'";
                        sql1 = "Update productor set Tipo_Cultivo= '" + tipocultivo + "' where ID_Productor= '" + id + "'";
                        try
                        {
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                            if (cn.State != 0)
                            {
                                cn.Execute(sql1, out cantfilas);
                            }
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case "E":
                        sql = "Update usuario set Nombre= '" + nombre + "', Contrasenia= '" + contra + "' where ID= '" + id + "'";
                        try
                        {
                            if (cn.State != 0)
                            {
                                cn.Execute(sql, out cantfilas);
                            }
                        }
                        catch
                        {
                            return;
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }
        }*/
        //____________________________________________________________________________________________________________
        /*public static void CargarSiembraCosecha(string idPro, string rutPro, string idSec, string idSieCos, string fechain, string fechafin)
        {
            string sql;
            object cantfilas;

            if (cn.State != 0)
            {
                sql = "Insert into siembre_cosecha(ID_Sector, ID_Productor, RUT_Productor, ID_Siembra_Cosecha, Fecha_Siembra, Fecha_Cosecha) values ('"+idSec+"','"+idPro+"','"+rutPro+"','"+idSieCos+"','"+fechain+"','"+fechafin+"')";
                try
                {
                    if (cn.State != 0)
                    {
                        cn.Execute(sql, out cantfilas);
                    }
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos,intente " +
                    "nuevamente o comuniquese con el tecnico");
            }

        }*/
        //____________________________________________________________________________________________________________
    }


}
