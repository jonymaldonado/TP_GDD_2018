using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public class UserConnection
    {
        public static int Authenticate(string user, string password)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@USUARIO", user));
            parameters.Add(new SqlParameter("@Password", password));

            return Connection.queryForInt("EL_GROUP_BY.BUSCAR_USUARIO", Connection.Type.StoredProcedure, parameters);
        }

        public static void RegisterFailedAttempt(string user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", user));
            Connection.WriteInTheBase("EL_GROUP_BY.REG_INTENTO_FALLIDO", Connection.Type.StoredProcedure, parameters);
        }

        public static int CountRoles(string user)
        {
            int id = GetUserId(user);
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@USU_ID", id));
            return Connection.queryForInt("EL_GROUP_BY.OBTENER_CANT_ROLES", Connection.Type.StoredProcedure, parametros);
        }

        public static int GetUserId(string user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", user));

            return Connection.queryForInt("EL_GROUP_BY.OBTENER_ID_USUARIO", Connection.Type.StoredProcedure, parameters);
        }

        public static SqlDataReader GetRolesAvailables(int userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", userId));
            return Connection.GetDataReader("EL_GROUP_BY.OBTENER_ROLES_ACTIVOS", Connection.Type.StoredProcedure, parameters);
        }

        public static int GetUniqueRolId(Int32 userId)
        {
            return Connection
                    .queryForInt("SELECT ROL_ID FROM EL_GROUP_BY.ROL_USUARIO WHERE USUARIO_ID = " + userId);
        }

        public static int GetFirstLogin(Int32 userId)
        {
            return Connection   
                        .queryForInt("SELECT Usuario_Primer_Login FROM EL_GROUP_BY.USUARIO WHERE USUARIO_ID = " + userId);
        }

        public static void UpdatePassword(int userId, string newPassword)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int, 50);
            parameter.Value = userId;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PASSWORD", SqlDbType.NVarChar, 50);
            parameter.Value = newPassword;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ACTUALIZAR_PASSWORD", Connection.Type.StoredProcedure, parameters);
        }

        public static int ExistsUserName(string userName)
        {
            return Connection.queryForInt("EXEC EL_GROUP_BY.ES_UNICO_USERNAME '" +userName+ "'");
        }

        public static DataSet ListUsers(String username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USERNAME", SqlDbType.NVarChar, 10);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(username))
            {
                parameter.Value = username;
            }
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_USUARIOS", Connection.Type.StoredProcedure, parameters);

            return ds;

        }

        public static void SetUserStatus(Int32 userId, bool status)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int);
            parameter.Value = userId;
            parameters.Add(parameter);

            parameter = new SqlParameter("@HABILITADO", SqlDbType.Bit);
            parameter.Value = status;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.SET_USUARIO_HABILITADO", Connection.Type.StoredProcedure, parameters);
        }

    }

}
