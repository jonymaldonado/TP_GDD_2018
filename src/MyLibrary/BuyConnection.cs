using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyLibrary
{
    public class BuyConnection
    {
        public static SqlDataReader GetCategories()
        {
            return Connection.GetDataReader("SELECT RUBRO_ID, RUBRO_DESCRIPCION FROM EL_GROUP_BY.RUBRO");
        }

        public static DataSet ListExistingPublications(DateTime dateFrom, DateTime dateTo, string desc, string categoryOne, string categoryTwo, string categoryThree)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@FECHA_DESDE", SqlDbType.DateTime, 100);
            parameter.Value = dateFrom;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_HASTA", SqlDbType.DateTime, 100);
            parameter.Value = dateTo;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(desc))
            {
                parameter.Value = desc;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_UNO", SqlDbType.VarChar, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(categoryOne))
            {
                parameter.Value = categoryOne;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_DOS", SqlDbType.VarChar, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(categoryTwo))
            {
                parameter.Value = categoryTwo;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_TRES", SqlDbType.VarChar, 100);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(categoryThree))
            {
                parameter.Value = categoryThree;
            }
            parameters.Add(parameter);

            return Connection.GetDataSet("EL_GROUP_BY.LISTAR_PUBLICACIONES_DISPONIBLES", Connection.Type.StoredProcedure, parameters);
        }
    }
}
