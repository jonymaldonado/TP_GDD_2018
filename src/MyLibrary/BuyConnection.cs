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

        public static DataSet ListExistingPublications(DateTime dateFrom, DateTime dateTo, DateTime systemDate, string desc, Int32 categoryOne, Int32 categoryTwo, Int32 categoryThree)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@FECHA_DESDE", SqlDbType.DateTime, 100);
            parameter.Value = dateFrom;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_HASTA", SqlDbType.DateTime, 100);
            parameter.Value = dateTo;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA_SIST", SqlDbType.DateTime, 100);
            parameter.Value = systemDate;
            parameters.Add(parameter);

            parameter = new SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if (!String.IsNullOrEmpty(desc))
            {
                parameter.Value = desc;
            }
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_UNO", SqlDbType.Int);
            parameter.Value = categoryOne;
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_DOS", SqlDbType.Int);
            parameter.Value = categoryTwo;
            parameters.Add(parameter);

            parameter = new SqlParameter("@RUBRO_TRES", SqlDbType.Int);
            parameter.Value = categoryThree;
            parameters.Add(parameter);

            return Connection.GetDataSet("EL_GROUP_BY.LISTAR_PUBLICACIONES_DISPONIBLES_COMPRA", Connection.Type.StoredProcedure, parameters);
        }
    }
}
