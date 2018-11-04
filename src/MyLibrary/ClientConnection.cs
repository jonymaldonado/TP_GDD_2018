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
    public class ClientConnection
    {
        public static DataSet ListExistingClients(String name, String surname, String email, String numberDoc)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(name))
            {
                parameter.Value = name;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@APELLIDO", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(surname))
            {
                parameter.Value = surname;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMAIL", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(email))
            {
                parameter.Value = email;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@NRO_DOC", SqlDbType.Int, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(numberDoc))
            {
                parameter.Value = numberDoc;
            }
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_CLIENTES_EXISTENTES", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static void DeleteClient(string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int, 100);
            parameter.Value = userId;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_CLIENTE", Connection.Type.StoredProcedure, parameters);
        }

        public static void CreateClient(ClientDAO client)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO", SqlDbType.VarChar, 50);
            parameter.Value = client.User;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50);
            parameter.Value = client.Password;
            parameters.Add(parameter);

            parameter = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 255);
            parameter.Value = client.FirstName;
            parameters.Add(parameter);

            parameter = new SqlParameter("@APELLIDO", SqlDbType.VarChar, 255);
            parameter.Value = client.LastName;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TIPO_DOC", SqlDbType.VarChar, 10);
            parameter.Value = client.TypeDoc;
            parameters.Add(parameter);

            parameter = new SqlParameter("@NRO_DOC", SqlDbType.Int, 100);
            parameter.Value = client.NumberDoc;
            parameters.Add(parameter);

            // me están faltando agregar más parámetros

            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_CLIENTE", Connection.Type.StoredProcedure, parameters);
        }
    }

}
