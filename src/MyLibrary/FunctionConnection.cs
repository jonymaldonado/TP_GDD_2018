using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace MyLibrary
{
    public class FunctionConnection
    {
        private static FunctionDAO GetFunction(SqlDataReader reader)
        {
            FunctionDAO functionDAO = new FunctionDAO();

            functionDAO.Id = reader.GetInt32(reader.GetOrdinal("FUN_ID"));
            functionDAO.Name = reader.GetString(reader.GetOrdinal("FUN_DESCRIPCION"));
            functionDAO.Visible = reader.GetBoolean(reader.GetOrdinal("FUN_VISIBLE"));

            return functionDAO;
        }

        public static List<FunctionDAO> GetFunctions()
        {
            List<FunctionDAO> functions = new List<FunctionDAO>();

            SqlDataReader reader = Connection.GetDataReader("SELECT * FROM EL_GROUP_BY.FUNCIONALIDAD");

            return LoadFunctionsSinceReader(reader);
        }

        public static List<FunctionDAO> GetFunctionsAccordingQuery(Int32 id, String query)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ROL_ID", id));

            SqlDataReader reader = Connection.GetDataReader(query, Connection.Type.StoredProcedure, parameters);

            return LoadFunctionsSinceReader(reader);
        }

        private static List<FunctionDAO> LoadFunctionsSinceReader(SqlDataReader reader)
        {
            List<FunctionDAO> functions = new List<FunctionDAO>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FunctionDAO function = GetFunction(reader);
                    functions.Add(function);
                }
            }

            reader.Close();

            return functions;
        }

        public static SqlDataReader GetFunctionsIds(int roleId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ROL_ID", roleId));
            return Connection.GetDataReader("EL_GROUP_BY.OBTENER_FUNCIONALIDADES_ROL", Connection.Type.StoredProcedure, parameters);
        }
    }

}
