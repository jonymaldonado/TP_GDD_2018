using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

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


    }
}
