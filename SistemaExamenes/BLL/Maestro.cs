using DAL;
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
    public class Maestro
    {
        #region Propiedades
        private int _IdExamen;

        public int IdExamen
        {
            get { return _IdExamen; }
            set { _IdExamen = value; }
        }

        private int _IdPregunta;

        public int IdPregunta
        {
            get { return _IdPregunta; }
            set { _IdPregunta = value; }
        }

        private int _IdRespuesta;

        public int IdRespuesta
        {
            get { return _IdRespuesta; }
            set { _IdRespuesta = value; }
        }

        private string  _Pregunta;

        public string  Pregunta
        {
            get { return _Pregunta; }
            set { _Pregunta = value; }
        }

        private string  _Respuesta;

        public string  Respuesta
        {
            get { return _Respuesta; }
            set { _Respuesta = value; }
        }

        private decimal  _Puntos;

        public decimal  Puntos
        {
            get { return _Puntos; }
            set { _Puntos = value; }
        }

        private string _Seccion;

        public string Seccion
        {
            get { return _Seccion; }
            set { _Seccion = value; }
        }

        private string _Secuencia;

        public string Secuencia
        {
            get { return _Secuencia; }
            set { _Secuencia = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _CodExamen;

        public string CodExamen
        {
            get { return _CodExamen; }
            set { _CodExamen = value; }
        }

        private string _Examen;

        public string Examen
        {
            get { return _Examen; }
            set { _Examen = value; }
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

        #region Metodos
        public DataSet CARGA_MATERIAS()
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
                return null;
            }
            else
            {
                sql = "SP_SELECT_MATERIAS";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
                    sql = "SP_ERROR_INSERT";
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


        public void CARGA_CODEXAMEN()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
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
                /*Llamado al Procedimiento dentro de la BD*/
                sql = "SP_SELECT_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vnombre", SqlDbType.NChar, _Nombre);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
                    sql = "SP_ERROR_INSERT";
                    ParamStruct[] parametroSs = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametroSs, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                }
                else
                {
                    /*Se obtienen los datos deseados por medio de la busqueda realizada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _Secuencia = ds.Tables[0].Rows[0]["secuencia"].ToString();
                        _CodExamen = _Nombre + _Secuencia;
                    }
                    else
                    {
                        _CodExamen = "Error";
                    }
                }
            }
        }

        /*Metodo que permite la actualizacion de la secuencia dentro de los codigos de facturas, de manera
         que se obtiene los articulos vendidos al un mismo cliente*/
        public bool ACTUALIZA_SECUENCIA_EXAMEN()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
                sql = "SP_ERROR_INSERT";
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
                /*Llamado al Procedimiento dentro de la BD*/
                string SecuenciaNueva = Convert.ToString(Convert.ToInt32(_Secuencia) + 1);
                sql = "SP_UPDATE_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vnombre", SqlDbType.NChar, _Nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@vsecuencia", SqlDbType.VarChar, SecuenciaNueva);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
                    sql = "SP_ERROR_INSERT";
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
                    /*Validación de la Actualizacion realizada*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }
        }

        public bool INSERT_PREGUNTA()
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
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                sql = "SP_INSERT_PREGUNTA";
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idexamen", SqlDbType.NChar, _Examen);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@vpregunta", SqlDbType.VarChar, _Pregunta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@vseccion", SqlDbType.VarChar, _Seccion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@vcod", SqlDbType.VarChar, _CodExamen);


                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "SP_ERROR_INSERT";
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


        public bool INSERT_RESPUESTAS()
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
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                sql = "SP_INSERT_RESPUESTAS";
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@vpregunta", SqlDbType.VarChar, _Pregunta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@vcod", SqlDbType.VarChar, _CodExamen);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@vrespuesta", SqlDbType.VarChar, _Respuesta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@vpuntos", SqlDbType.Decimal, _Puntos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@vseccion", SqlDbType.VarChar, _Seccion);


                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "SP_ERROR_INSERT";
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


        #endregion


    }
}
