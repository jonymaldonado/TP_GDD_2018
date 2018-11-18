using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;

namespace MyLibrary
{
    public class EmpresaConnection
    {
        public static DataSet ListExistingEmpresa(EmpresaDAO empresa)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.RazonSocial))
            {
                parameter.Value = empresa.RazonSocial;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@CUIT", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.Cuit))
            {
                parameter.Value = empresa.Cuit;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMAIL", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.Email))
            {
                parameter.Value = empresa.Email;
            }
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_EMPRESAS", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static void DeleteEmpresa(EmpresaDAO empresa)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int, 100);
            parameter.Value = empresa.UserId;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_EMPRESA", Connection.Type.StoredProcedure, parameters);
        }

        public static void CreateEmpresa(EmpresaDAO empresa)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO", SqlDbType.VarChar, 50);
            parameter.Value = empresa.UserId;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50);
            parameter.Value = empresa.Password;
            parameters.Add(parameter);

            parameter = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 255);
            parameter.Value = empresa.RazonSocial;
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMAIL", SqlDbType.VarChar, 255);
            parameter.Value = empresa.Email;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 20);
            parameter.Value = empresa.Telefono;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CALLE", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Calle;
            parameters.Add(parameter);

            parameter = new SqlParameter("@NUMERO", SqlDbType.Int, 18);
            parameter.Value = empresa.Piso;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PISO", SqlDbType.Int, 18);
            parameter.Value = empresa.Piso;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DEPTO", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Depto;
            parameters.Add(parameter);

            parameter = new SqlParameter("@LOCALIDAD", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Localidad;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CODIGO_POSTAL", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.CodigoPostal;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CIUDAD", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Ciudad;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CUIT", SqlDbType.NVarChar, 255);
            parameter.Value = empresa.Cuit;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_EMPRESA", Connection.Type.StoredProcedure, parameters);
        }

    }
}
