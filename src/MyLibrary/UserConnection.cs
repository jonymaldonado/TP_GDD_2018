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

        public static int getUniqueRolId(Int32 userId)
        {
            return Connection
                    .queryForInt("SELECT ROL_ID FROM EL_GROUP_BY.ROL_USUARIO WHERE USUARIO_ID = " + userId);
        }
    }

}
