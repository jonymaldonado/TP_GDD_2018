using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace MyLibrary
{
    public class UbicationConnection
    {
        public static List<UbicationTypeDAO> GetUbicationTypes()
        {
            List<UbicationTypeDAO> ubicationTypes = new List<UbicationTypeDAO>();

            SqlDataReader reader = Connection.GetDataReader("SELECT * FROM EL_GROUP_BY.Ubicacion_Tipo");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UbicationTypeDAO ubicationType = GetUbicationType(reader);
                    ubicationTypes.Add(ubicationType);
                }
                reader.NextResult();
            }

            reader.Close();

            return ubicationTypes;
        
        }

        private static UbicationTypeDAO GetUbicationType(SqlDataReader reader)
        {
            UbicationTypeDAO ubicationType = new UbicationTypeDAO();

            ubicationType.id = reader.GetInt32(reader.GetOrdinal("Ubicacion_Tipo_ID"));
            ubicationType.cod = reader.GetDecimal(reader.GetOrdinal("Ubicacion_Tipo_Codigo"));
            ubicationType.desc = reader.GetString(reader.GetOrdinal("Ubicacion_Tipo_Descripcion"));

            return ubicationType;
        }

        public static SqlDataReader GetUbications(Int32 idPublic)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PUBLI_ID", idPublic));
            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_UBICACIONES", Connection.Type.StoredProcedure, parameters);

            return reader;
        }

        public static void CreateUbications(int publicID, BindingList<UbicationDAO> ubicaciones)
        {
            DataTable dataTable = new DataTable("UBICACION_TIPO");

            dataTable.Columns.Add("Ubicacion_Fila", typeof(string));
            dataTable.Columns.Add("Ubicacion_Asiento", typeof(int));
            dataTable.Columns.Add("Ubicacion_Sin_Numerar", typeof(int));
            dataTable.Columns.Add("Ubicacion_Precio", typeof(int));
            dataTable.Columns.Add("Ubicacion_Disponible", typeof(int));
            dataTable.Columns.Add("Ubicacion_Tipo_ID", typeof(int));
            dataTable.Columns.Add("Ubicacion_Canjeada", typeof(int));
            dataTable.Columns.Add("Ubicacion_Fecha_Canje", typeof(DateTime));
            dataTable.Columns.Add("Ubicacion_Cliente_Canje", typeof(int));

            foreach (UbicationDAO ubicacion in ubicaciones)
            {
                dataTable.Rows.Add(ubicacion.Fila,
                                    ubicacion.Asiento,
                                    ubicacion.SinNumerar,
                                    ubicacion.Precio,
                                    1, //Disponible
                                    ubicacion.TipoDAO.id,
                                    0, //No canjeada
                                    null,
                                    null);
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@UBICACIONES";
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dataTable;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PUBLI_ID", SqlDbType.Int);
            parameter.Value = publicID;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_UBICACIONES", Connection.Type.StoredProcedure, parameters);

        }

        public static void DeleteUbications(int publicID, BindingList<UbicationDAO> ubicaciones)
        {
            DataTable dataTable = new DataTable("UBICACION_TIPO");

            dataTable.Columns.Add("Ubicacion_ID", typeof(int));
            dataTable.Columns.Add("Publicacion_ID", typeof(int));
            
            foreach (UbicationDAO ubicacion in ubicaciones)
            {
                dataTable.Rows.Add(ubicacion.UbicacionId,
                                   publicID);
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@UBICACIONES";
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dataTable;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.BORRAR_UBICACIONES", Connection.Type.StoredProcedure, parameters);

        }

    }
}
