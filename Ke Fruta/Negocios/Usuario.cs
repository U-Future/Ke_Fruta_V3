using ADODB;
using Ke_Fruta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Fruta.Negocios
{
    internal class Usuario
    {

        protected string _id;
        protected string _rut;
        protected string _nombre;
        protected string _nombrenuevo;
        protected string _tipo;
        protected string _email;
        protected string _emailnuevo;
        protected List<string> _telefonos = new List<string>();
        protected List<string> _sector = new List<string>();
        protected string _tipoCultivo;
        protected string _pass;
        protected string _passnueva;
        protected bool _Hay;
        protected bool _EmailExiste;


        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string nombrenuevo
        {
            get { return _nombrenuevo; }
            set { _nombrenuevo = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string emailnuevo
        {
            get { return _emailnuevo; }
            set { _emailnuevo = value; }
        }
        public List<string> telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }
        public string tipoCultivo
        {
            get { return _tipoCultivo; }
            set { _tipoCultivo = value; }
        }
        public string rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public List<string> sector
        {
            get { return _sector; }
            set { _sector = value; }
        }
        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        public string passnueva
        {
            get { return _passnueva; }
            set { _passnueva = value; }
        }
        public bool Hay
        {
            get { return _Hay; }
            set { _Hay = value; }
        }
        public bool EmailExiste
        {
            get { return _EmailExiste; }
            set { _EmailExiste = value; }
        }
        Datos.Persistencia persistencia = new Datos.Persistencia();

        public void verificar()
        {
            string sql, sql1, sql2, sql3;
            ADODB.Recordset rs, rs1, rs2, rs3;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where ID= '" + _id + "'";

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
                    _Hay = true;
                    _nombre = rs.Fields[1].Value.ToString();
                    _email = rs.Fields[3].Value.ToString();
                    _tipo = rs.Fields[2].Value.ToString();

                    switch (rs.Fields[2].Value.ToString())
                    {
                        case "A":
                            _rut = "null";
                            _tipoCultivo = "null";
                            break;
                        case "I":
                            if (persistencia.cn.State != 0)
                            {
                                sql1 = "Select * from productor where ID_Productor ='" + _id + "'";

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
                                    _rut = Convert.ToString(rs1.Fields[1].Value);
                                    _tipoCultivo = Convert.ToString(rs1.Fields[2].Value);

                                    if (persistencia.cn.State != 0)
                                    {
                                        sql2 = "Select * from sector where ID_Productor ='" + _id + "'";

                                        try
                                        {
                                            rs2 = persistencia.cn.Execute(sql2, out cantfilas);
                                        }
                                        catch
                                        {
                                            return;
                                        }
                                        if (rs2.RecordCount > 0)
                                        {
                                            while (!rs2.EOF)
                                            {
                                                _sector.Add(Convert.ToString(rs2.Fields[1].Value));
                                                rs2.MoveNext();
                                            }
                                        }
                                    }

                                }
                            }
                            break;
                        case "E":
                            if (persistencia.cn.State != 0)
                            {
                                _tipoCultivo = "null";
                                sql1 = "Select * from cliente where ID_Cliente ='" + _id + "'";

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
                                    _rut = Convert.ToString(rs1.Fields[1].Value);
                                }
                            }
                            break;
                    }
                    if (persistencia.cn.State != 0)
                    {
                        sql3 = "Select * from tel_usuario where ID_Usuario ='" + _id + "'";

                        try
                        {
                            rs3 = persistencia.cn.Execute(sql3, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                        if (rs3.RecordCount > 0)
                        {
                            while (!rs3.EOF)
                            {
                                _telefonos.Add(Convert.ToString(rs3.Fields[1].Value));
                                rs3.MoveNext();
                            }
                        }
                    }
                }
                else
                {
                    _Hay = false;
                    ABMC.Aviso("No se encontro un registro con este ID");
                }
            }
        }
        public void BuscarExitenciaNombre()
        {
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + _nombrenuevo + "' and ID = '" + _id + "'";
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
                    _Hay = true;
                }
                else
                {
                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Select * from usuario where Nombre ='" + _nombrenuevo + "' and ID != '" + _id + "'";
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
                            _Hay = true;
                        }
                        else
                        {
                            _Hay = false;
                        }
                    }
                }
            }
        }
        public void BuscarExistenciaEmail()
        {
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs, rs1;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Email ='" + _emailnuevo + "' and ID = '" + _id + "'";
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
                    _EmailExiste = true;
                }
                else
                {
                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Select * from usuario where Email ='" + _emailnuevo + "' and ID != '" + _id + "'";
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
                            _EmailExiste = true;
                        }
                        else
                        {
                            ModificarEmail();
                        }

                    }
                }
            }
        }
        //__________________________
        public void AltaUsuario()
        {
            string sql, sql1, sql2, sql3, sql4, sql5, sql8;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Insert into usuario(Nombre, Tipo, Email) values " +
                    "('" + _nombre + "','" + _tipo + "','" + _email + "')";//Insertar en Usuario
                sql1 = "Create User '" + _nombre + "'@'%' identified by '" + pass + "'";//Crear Usuario
                sql2 = "Grant select, insert, delete, update, create user, drop, grant option on *.* to '" + nombre + "'@'%'";//Permisos Administrativo
                sql3 = "Grant insert, delete, update, select on ke_fruta.* to '" + _nombre + "'@'%'";//Permisos Productor
                sql4 = "Grant insert, select, update on ke_fruta.* to '" + _nombre + "'@'%'";//Permisos Externos
                sql5 = "flush privileges";

                if (persistencia.cn.State != 0)
                {
                    sql8 = "Select * from usuario where Nombre ='" + _nombre + "'";
                    try
                    {
                        rs = persistencia.cn.Execute(sql8, out cantfilas);
                    }
                    catch
                    {
                        return;
                    }
                    if (rs.RecordCount > 0)
                    {
                        ABMC.Aviso("Este Nombre ya se encuentra registrado");
                    }
                    else
                    {
                        switch (tipo)
                        {
                            case "A":
                                if (persistencia.cn.State != 0)
                                {
                                    try
                                    {
                                        if (persistencia.cn.State != 0)
                                        {
                                            persistencia.cn.Execute(sql, out cantfilas);
                                        }
                                        if (persistencia.cn.State != 0)
                                        {
                                            persistencia.cn.Execute(sql1, out cantfilas);
                                        }
                                        if (persistencia.cn.State != 0)
                                        {
                                            persistencia.cn.Execute(sql2, out cantfilas);
                                        }

                                        AltaAdm();
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
                                    if (persistencia.cn.State != 0)
                                    {
                                       persistencia.cn.Execute(sql, out cantfilas);
                                    }
                                    if (persistencia.cn.State != 0)
                                    {
                                        persistencia.cn.Execute(sql1, out cantfilas);
                                    }
                                    if (persistencia.cn.State != 0)
                                    {
                                        persistencia.cn.Execute(sql3, out cantfilas);
                                    }

                                    AltaCli();
                                    AltaPro();
                                    ABMC.Aviso("Se agrego correctamente al Productor");
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "E":
                                try
                                {
                                    if (persistencia.cn.State != 0)
                                    {
                                        persistencia.cn.Execute(sql, out cantfilas);
                                    }
                                    if (persistencia.cn.State != 0)
                                    {
                                        persistencia.cn.Execute(sql1, out cantfilas);
                                    }
                                    if (persistencia.cn.State != 0)
                                    {
                                        persistencia.cn.Execute(sql4, out cantfilas);
                                    }

                                    AltaCli();
                                    ABMC.Aviso("Se agrego correctamente al Cliente");
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                        }
                    }
                }
            }
        }
        public void AltaAdm()
        {
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + _nombre + "'";
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
                    _id = Convert.ToString(rs.Fields[0].Value);

                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Insert into administrativo(ID_Administrativo) values ('" + _id + "')";
                        try
                        {
                            persistencia.cn.Execute(sql1, out cantfilas);
                            ABMC.Aviso("Se agrego correctamente al Administrativo");
                        }
                        catch
                        {
                            return;
                        }
                    }


                }
            }

        }
        public void AltaCli()
        {
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + _nombre + "'";
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
                    id = Convert.ToString(rs.Fields[0].Value);

                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Insert into cliente(ID_Cliente, RUT_Cliente) " +
                            "values ('" + id + "','" + _rut + "')";
                        try
                        {
                            persistencia.cn.Execute(sql1, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                    }


                }
            }

        }
        public void AltaPro()
        {
            string sql, sql1;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + _nombre + "'";
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
                    id = Convert.ToString(rs.Fields[0].Value);

                    if (persistencia.cn.State != 0)
                    {
                        sql1 = "Insert into productor(ID_Productor, RUT_Productor, Tipo_Cultivo) values " +
                            "('" + id + "','" + _rut + "','" + _tipoCultivo + "')";
                        try
                        {
                            persistencia.cn.Execute(sql1, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }
        }
        //__________________________
        public void BajaUsuarioProductor()
        {
            string sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql5 = "Delete from gestiona where ID_Productor= '" + _id + "'";//Gestiona
                sql6 = "Delete from realiza_venta where ID_Cliente= '" + _id + "'";//Realiza_Venta
                sql7 = "Delete from compra where ID_Cliente= '" + _id + "'";//Compra
                sql9 = "Delete from vende where ID_Productor= '" + _id + "'";//Vende
                sql8 = "Delete from siembra_cosecha where ID_Productor= '" + _id + "'";//Siembra_Cosecha
                sql3 = "Delete from sector where ID_Productor= '" + _id + "'"; //Sector
                sql10 = "Delete from insumos where ID_Productor= '" + _id + "'";//Insumos
                sql4 = "Delete from productor where ID_Productor= '" + _id + "'";//Productor
                sql11 = "Delete from cliente where ID_Cliente= '" + _id + "'";//Cliente
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + _id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + _id + "'";//Usuario
                sql1 = "Drop User '" + _nombre + "'@'%'"; //User
                try
                {
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql5, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql6, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql7, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql9, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql8, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql3, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql10, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql4, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql11, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql2, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql1, out cantfilas);
                    }
                    ABMC.Aviso("Baja realizada exitosamente");

                }
                catch
                {
                    return;
                }

            }
        }
        public void BajaUsuarioCliente()
        {
            string sql, sql1, sql2, sql6, sql7, sql11;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql6 = "Delete from realiza_venta where ID_Cliente= '" + _id + "'";//Realiza_Venta
                sql7 = "Delete from compra where ID_Cliente= '" + _id + "'";//Compra
                sql11 = "Delete from cliente where ID_Cliente= '" + _id + "'";//Cliente
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + _id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + _id + "'";//Usuario
                sql1 = "Drop User '" + _nombre + "'@'%'"; //User

                try
                {
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql6, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql7, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql11, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql2, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql1, out cantfilas);
                    }
                    ABMC.Aviso("Baja realizada exitosamente");
                }
                catch
                {
                    return;
                }

            }
        }
        public void BajaUsuarioAdministrativo()
        {
            string sql, sql1, sql2, sql5, sql6, sql11;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql5 = "Delete from gestiona where ID_Productor= '" + _id + "'";//Gestiona
                sql6 = "Delete from realiza_venta where ID_Cliente= '" + _id + "'";//Realiza_Venta
                sql11 = "Delete from administrativo where ID_Administrativo= '" + _id + "'";//Administrativo
                sql2 = "Delete from tel_usuario where ID_Usuario= '" + _id + "'";// Telefono
                sql = "Delete from usuario where ID= '" + _id + "'";//Usuario
                sql1 = "Drop User '" + _nombre + "'@'%'"; //User

                try
                {
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql5, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql6, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql11, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql2, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql, out cantfilas);
                    }
                    if (persistencia.cn.State != 0)
                    {
                        persistencia.cn.Execute(sql1, out cantfilas);
                    }
                    ABMC.Aviso("Baja realizada exitosamente");
                }
                catch
                {
                    return;
                }

            }
        }
        //__________________________
        public void ModificarUsuario()
        {
            string sql;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Update usuario set Nombre= '" + _nombrenuevo + "' where ID= '" + _id + "'";

                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
        }
        public void ModificarEmail()
        {
            string sql;
            object cantfilas;
            if (persistencia.cn.State != 0)
            {
                sql = "Update usuario set Email = '" + _emailnuevo + "' where ID = '" + _id + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);
                }
                catch
                {
                    return;
                }
            }
        }
        public void ModificarPassword()
        {
            string sql;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                sql = "Alter user '" + _nombre + "'@'%' identified by '" + _passnueva + "'";
                try
                {
                    persistencia.cn.Execute(sql, out cantfilas);

                }
                catch
                {
                    return;
                }

            }
        }
        public void ModificarNombreUser()
        {
            string sql, sql2, sql3, sql4;
            object cantfilas;

            if (persistencia.cn.State != 0)
            {
                //sql = "Update user set User = '" + _nombrenuevo + "' where Host = '%' and User ='" + _nombre + "'";
                sql = "RENAME USER '" + _nombre + "'@'%' TO '" + _nombrenuevo + "'@'%'";
                sql2 = "Grant select, insert, delete, update, create user, drop, grant option on *.* to '" + _nombrenuevo + "'@'%'";//Permisos Administrativo
                sql3 = "Grant insert, delete, update, select on ke_fruta.* to '" + _nombrenuevo + "'@'%'";//Permisos Productor
                sql4 = "Grant insert, select, update on ke_fruta.* to '" + _nombrenuevo + "'@'%'";//Permisos Externos

                switch (tipo)
                {
                    case "A":
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            persistencia.cn.Execute(sql2, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                        break;
                    case "I":
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            persistencia.cn.Execute(sql3, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                        break;
                    case "E":
                        try
                        {
                            persistencia.cn.Execute(sql, out cantfilas);
                            persistencia.cn.Execute(sql4, out cantfilas);
                        }
                        catch
                        {
                            return;
                        }
                        break;
                }

            }
        }
        //__________________________
        public void BusquedaXNombre()
        {
            string sql;
            object cantfilas;
            ADODB.Recordset rs;

            if (persistencia.cn.State != 0)
            {
                sql = "Select * from usuario where Nombre ='" + _nombre + "'";

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
                    _Hay = true;
                    _id = Convert.ToString(rs.Fields[0].Value);
                }
                else
                {
                    _Hay = false;
                }
            }
        }
    }
}
