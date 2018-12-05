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
            if ((empresa != null) && !String.IsNullOrEmpty(empresa.RazonSocial))
            {
                parameter.Value = empresa.RazonSocial;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@CUIT", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if ((empresa != null) && !String.IsNullOrEmpty(empresa.Cuit))
            {
                parameter.Value = empresa.Cuit;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMAIL", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if ((empresa != null) && !String.IsNullOrEmpty(empresa.Email))
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
            parameter.Value = empresa.User;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PASSWORD", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Password;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PRIMER_LOGIN", SqlDbType.Bit);
            parameter.Value = empresa.FirstLogin;
            parameters.Add(parameter);

            LoadMoreParameters(empresa, parameters);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_EMPRESA", Connection.Type.StoredProcedure, parameters);
        }

        public static SqlDataReader GetEmpresaForModify(string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USER_ID", userId));
            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_EMPRESA_FOR_MODIFY", Connection.Type.StoredProcedure, parameters);

            return reader;
        }

        public static void UpdateEmpresa(EmpresaDAO empresa, string userId, Boolean active)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int, 50);
            parameter.Value = userId;
            parameters.Add(parameter);

            parameter = new SqlParameter("@HABILITADO", SqlDbType.Bit, 1);
            parameter.Value = active;
            parameters.Add(parameter);

            LoadMoreParameters(empresa, parameters);
            Connection.WriteInTheBase("EL_GROUP_BY.ACTUALIZAR_EMPRESA", Connection.Type.StoredProcedure, parameters);
        }

        private static void LoadMoreParameters(EmpresaDAO empresa, List<SqlParameter> parameters)
        {
            SqlParameter parameter;

            parameter = new SqlParameter("@RAZON_SOCIAL", SqlDbType.VarChar, 255);
            parameter.Value = empresa.RazonSocial;
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMAIL", SqlDbType.VarChar, 255);
            parameter.Value = empresa.Email;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 20);
            parameter.Value = empresa.Phone;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CALLE", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Street;
            parameters.Add(parameter);

            parameter = new SqlParameter("@NUMERO", SqlDbType.Int, 18);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.NumberStreet))
            {
                parameter.Value = Convert.ToInt32(empresa.NumberStreet);
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@PISO", SqlDbType.Int, 18);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.Floor))
            {
                parameter.Value = Convert.ToInt32(empresa.Floor);
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@DEPTO", SqlDbType.VarChar, 50);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(empresa.Department))
            {
                parameter.Value = empresa.Department;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@LOCALIDAD", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Location;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CODIGO_POSTAL", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.PostalCode;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CIUDAD", SqlDbType.NVarChar, 50);
            parameter.Value = empresa.Ciudad;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CUIT", SqlDbType.NVarChar, 255);
            parameter.Value = empresa.Cuit;
            parameters.Add(parameter);

        }

        public static DataSet ListComprasByEmpresa(Int32 IdEmpresa, DateTime FechaHasta)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@ID_EMPRESA", SqlDbType.Int);
            parameter.Value = IdEmpresa;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA", SqlDbType.DateTime);
            parameter.Value = FechaHasta;
            parameters.Add(parameter);
            
            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_COMPRAS_EMPRESA", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static bool ExistsRazonSocial(string razon, string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@RAZON_SOCIAL", SqlDbType.NVarChar, 255);
            parameter.Value = razon;
            parameters.Add(parameter);

            parameter = new SqlParameter("@USER_ID", SqlDbType.Int);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(userId))
            {
                parameter.Value = userId;
            }
            parameters.Add(parameter);

            SqlParameter result = new SqlParameter("@EXISTE", SqlDbType.Bit);
            result.Size = sizeof(bool);
            result.Direction = ParameterDirection.Output;
            parameters.Add(result);

            Connection.WriteInTheBase("EL_GROUP_BY.EXISTE_RAZON_EMPRESA", Connection.Type.StoredProcedure, parameters);

            return Convert.ToBoolean(result.Value);
        }

        public static bool ExistsCuit(string cuit, string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@CUIT", SqlDbType.NVarChar, 255);
            parameter.Value = cuit;
            parameters.Add(parameter);


            parameter = new SqlParameter("@USER_ID", SqlDbType.Int);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(userId))
            {
                parameter.Value = userId;
            }
            parameters.Add(parameter);

            SqlParameter result = new SqlParameter("@EXISTE", SqlDbType.Bit);
            result.Size = sizeof(bool);
            result.Direction = ParameterDirection.Output;
            parameters.Add(result);

            Connection.WriteInTheBase("EL_GROUP_BY.EXISTE_CUIT_EMPRESA", Connection.Type.StoredProcedure, parameters);

            return Convert.ToBoolean(result.Value);
        }

    }


}
