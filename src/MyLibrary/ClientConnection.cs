using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
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

            parameter = new SqlParameter("@PASSWORD", SqlDbType.NVarChar, 50);
            parameter.Value = client.Password;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PRIMER_LOGIN", SqlDbType.Bit);
            parameter.Value = client.FirstLogin;
            parameters.Add(parameter);

            LoadMoreParameters(client, parameters);
            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_CLIENTE", Connection.Type.StoredProcedure, parameters);
        }

        public static void UpdateClient(ClientDAO client, string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@USUARIO_ID", SqlDbType.Int, 50);
            parameter.Value = userId;
            parameters.Add(parameter);

            LoadMoreParameters(client, parameters);
            Connection.WriteInTheBase("EL_GROUP_BY.ACTUALIZAR_CLIENTE", Connection.Type.StoredProcedure, parameters);
        }

        private static void LoadMoreParameters(ClientDAO client, List<SqlParameter> parameters)
        {
            SqlParameter parameter;

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

            parameter = new SqlParameter("@CUIL", SqlDbType.VarChar, 255);
            parameter.Value = client.Cuil;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TELEFONO", SqlDbType.VarChar, 255);
            parameter.Value = client.Phone;
            parameters.Add(parameter);

            parameter = new SqlParameter("@MAIL", SqlDbType.VarChar, 255);
            parameter.Value = client.Email;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CALLE", SqlDbType.VarChar, 255);
            parameter.Value = client.Street;
            parameters.Add(parameter);

            parameter = new SqlParameter("@NRO_CALLE", SqlDbType.Int, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(client.NumberStreet))
            {
                parameter.Value = Convert.ToInt32(client.NumberStreet);
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@PISO", SqlDbType.Int, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(client.Floor))
            {
                parameter.Value = Convert.ToInt32(client.Floor);
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@DEPARTAMENTO", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(client.Department))
            {
                parameter.Value = client.Department;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@LOCALIDAD", SqlDbType.VarChar, 255);
            parameter.Value = client.Location;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CODIGO_POSTAL", SqlDbType.VarChar, 255);
            parameter.Value = client.PostalCode;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_NAC", SqlDbType.DateTime, 100);
            parameter.Value = client.BirthDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TARJETA_NOMBRE", SqlDbType.VarChar, 255);
            parameter.Value = client.CardName;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TARJETA_NRO", SqlDbType.Int, 100);
            parameter.Value = client.CardNumber;
            parameters.Add(parameter);
        }

        public static SqlDataReader GetUserForModify(string userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USER_ID", userId));
            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_USER_FOR_MODIFY", Connection.Type.StoredProcedure, parameters);

            return reader;
        }

        public static int GetClientIdWithUserId(int userId)
        {
            return Connection
                    .queryForInt("SELECT CLIENTE_ID FROM EL_GROUP_BY.Cliente where Usuario_ID = " + Convert.ToString(userId));
        }

        public static SqlDataReader GetClientData(int clientId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CLIENT_ID", clientId));

            parameters.Add(new SqlParameter("@FECHA", ConfigurationManager.AppSettings["FechaSistema"]));

            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_DATOS_CLIENTE_X_ID", Connection.Type.StoredProcedure, parameters);
            
            return reader;
        }


        public static DataSet GetHistoryDataByClient(int clientId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@CLIENT_ID", SqlDbType.VarChar, 255);
            parameter.Value = Convert.ToString(clientId);
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static DataSet GetChangeList(int points)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@PUNTOS", SqlDbType.Int, 1);
            parameter.Value = Convert.ToString(points);
            parameters.Add(parameter);

            parameters.Add(new SqlParameter("@FECHA", ConfigurationManager.AppSettings["FechaSistema"]));

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_CANJE_DISPONIBLE", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static void  ChangePoints(int clientId, int puntos, int Publicacion_ID, int Ubicacion_ID)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@CLIENTE_ID", SqlDbType.Int, 50);
            parameter.Value = clientId;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PUNTOS", SqlDbType.Int, 50);
            parameter.Value = puntos;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PUBLICACION_ID", SqlDbType.Int, 50);
            parameter.Value = Publicacion_ID;
            parameters.Add(parameter);
            
            parameter = new SqlParameter("@UBICACION_ID", SqlDbType.Int, 50);
            parameter.Value = Ubicacion_ID;
            parameters.Add(parameter);

            parameters.Add(new SqlParameter("@FECHA", ConfigurationManager.AppSettings["FechaSistema"]));
            
            Connection.WriteInTheBase("EL_GROUP_BY.CANJEAR_UBICACION", Connection.Type.StoredProcedure, parameters);

        }

        public static Int32 GetUserId(Int32 ClientId)
        {
            return Connection.queryForInt("SELECT Usuario_ID FROM EL_GROUP_BY.Cliente WHERE Cliente_ID =" + ClientId);

        }

    }

}
