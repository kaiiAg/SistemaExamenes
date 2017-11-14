using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private double  _Puntos;

        public double  Puntos
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

        #endregion


    }
}
