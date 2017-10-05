using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Acceso
    {
        #region Propiedades
        private string _LoginU;

        public string LoginU
        {
            get { return _LoginU; }
            set { _LoginU = value; }
        }


        private string _Contra;

        public string Contra
        {
            get { return _Contra; }
            set { _Contra = value; }
        }

        private int _Tipo;

        public int Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

      
        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
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

        public void LOGIN()
        {
            conexion = cls_DAL.trae_conexion("BDExamenes", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                sql = "SP_Error_Insert";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                sql = "SP_Acceso";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usuario", SqlDbType.NVarChar, _LoginU);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@contraseña", SqlDbType.NVarChar, _Contra);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    sql = "SP_Error_Insert";
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
                        _Tipo = Convert.ToInt32(ds.Tables[0].Rows[0]["tipo"]);
                        
                       
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


        #endregion
    }
}
