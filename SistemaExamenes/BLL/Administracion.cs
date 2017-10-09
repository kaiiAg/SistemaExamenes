﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Administracion
    {
        #region Propiedades
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _Tipo;

        public int Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        private int _IdUsuario;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private int _IdMaestro;

        public int IdMaestro
        {
            get { return _IdMaestro; }
            set { _IdMaestro = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NombreMaestro;

        public string NombreMaestro
        {
            get { return _NombreMaestro; }
            set { _NombreMaestro = value; }
        }


        private string _Grado;

        public string Grado
        {
            get { return _Grado; }
            set { _Grado = value; }
        }

        private string _Grupo;

        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        

        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
        }

        #endregion


        #region Variables Privadas
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        #endregion

        #region Propiedades

        public bool INSERT_USUARIOS()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                sql = "SP_INSERTAR_USUARIOS";
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vusername", SqlDbType.NChar, _Username);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@vpassword", SqlDbType.NChar, _Password);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@vstatus", SqlDbType.Int, _Status);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@vtipo", SqlDbType.Int, _Tipo);
               
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show("2" + mensaje_error + "  " + numero_error);
                    return true;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }


        public bool INSERT_ALUMNOS()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                sql = "SP_INSERTAR_ALUMNOS";
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idusuario", SqlDbType.Int, _IdUsuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idmaestro", SqlDbType.Int, _IdMaestro);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@nom", SqlDbType.VarChar, _Nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@grad", SqlDbType.NChar, _Grado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@grup", SqlDbType.NChar, _Grupo);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show("2" + mensaje_error + "  " + numero_error);
                    return true;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }


        public void ID_USUARIO()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = "SP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                sql = "SP_SELECT_IDUSUARIO";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vusuario", SqlDbType.NVarChar, _Username);
                
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "SP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // _Status = Convert.ToInt32(ds.Tables[0].Rows[0]["status"]);
                        _ID = Convert.ToInt32(ds.Tables[0].Rows[0]["idUsuario"]);


                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }
                    else
                    {
                        MessageBox.Show("datos no encontrados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }

        public void ID_MAESTRO()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = "SP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                sql = "SP_SELECT_IDMAESTRO";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vnombre", SqlDbType.VarChar, _NombreMaestro);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "SP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // _Status = Convert.ToInt32(ds.Tables[0].Rows[0]["status"]);
                        _ID = Convert.ToInt32(ds.Tables[0].Rows[0]["idMaestro"]);


                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }
                    else
                    {
                        MessageBox.Show("datos no encontrados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }


        public DataSet CARGA_MAESTROS()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                return null;
            }
            else
            {
                sql = "SP_SELECT_MAESTROS";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametros = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }




        #endregion




    }
}
