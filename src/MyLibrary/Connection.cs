using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace MyLibrary
{
    public class Connection
    {
        public static string systemDate = ConfigurationManager.AppSettings["FechaSistema"];
        public static SqlConnection connection = new SqlConnection();
        public static string stringConnection = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = stringConnection;
                connection.Open();
            }

            return connection;
        }

        public static DateTime GetSystemDate()
        {
            DateTime date = DateTime.Parse(systemDate.ToString());
            string dateString = Convert.ToString(ConfigurationManager.AppSettings["FechaSistema"]);
            date = Convert.ToDateTime(dateString);

            return date;
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }

        public enum Type
        {
            StoredProcedure,
            TableDirect,
            Text
        }

        public static SqlDataReader GetDataReader(string query, Type type, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;

            parameters.ForEach(p => command.Parameters.Add(p));

            switch (type)
            {
                case Type.StoredProcedure: command.CommandType = CommandType.StoredProcedure; break;
                case Type.TableDirect: command.CommandType = CommandType.TableDirect; break;
                case Type.Text: command.CommandType = CommandType.Text; break;
                default: break;
            }

            command.Connection = GetConnection();

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        public static DataSet GetDataSet(string query, Type type, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;

            parameters.ForEach(p => command.Parameters.Add(p));

            switch (type)
            {
                case Type.StoredProcedure: command.CommandType = CommandType.StoredProcedure; break;
                case Type.TableDirect: command.CommandType = CommandType.TableDirect; break;
                case Type.Text: command.CommandType = CommandType.Text; break;
                default: break;
            }

            command.Connection = GetConnection();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);

            return ds;
        }

        public static SqlDataReader GetDataReader(string query)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            return GetDataReader(query, Type.Text, parameters);
        }

        public static DataSet GetDataSet(string query)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            return GetDataSet(query, Type.Text, parameters);
        }

        public static int queryForInt(string query, Type type, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;

            parameters.ForEach(p => command.Parameters.Add(p));

            switch (type)
            {
                case Type.StoredProcedure: command.CommandType = CommandType.StoredProcedure; break;
                case Type.TableDirect: command.CommandType = CommandType.TableDirect; break;
                case Type.Text: command.CommandType = CommandType.Text; break;
                default: break;
            }

            command.Connection = GetConnection();

            int result = Convert.ToInt32(command.ExecuteScalar());
           
            return result;
        }

        public static int queryForInt(string query)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            return queryForInt(query, Type.Text, parameters);
        }

        public static void WriteInTheBase(string query, Type type, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;

            parameters.ForEach(p => command.Parameters.Add(p));

            switch (type)
            {
                case Type.Text: command.CommandType = CommandType.Text; break;
                case Type.StoredProcedure: command.CommandType = CommandType.StoredProcedure; break;
                default: break;
            }

            command.Connection = GetConnection();
            command.ExecuteReader().Close();
            command.Parameters.Clear();
        }

        public static void WriteInTheBase(string query)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            WriteInTheBase(query, Type.Text, parameters);
        }
    }

}
