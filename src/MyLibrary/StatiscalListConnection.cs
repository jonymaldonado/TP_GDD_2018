using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyLibrary
{
    public class StatiscalListConnection
    {
        public static DataSet GenerateSelectedList(String selectedList, DateTime dateFrom, DateTime dateTo, int gradeVisibility, int month)
        {
            List<SqlParameter> parameters = PrepareParameters(dateFrom, dateTo, gradeVisibility, month);

            return Connection.GetDataSet(selectedList, Connection.Type.StoredProcedure, parameters);
        }

        private static List<SqlParameter> PrepareParameters(DateTime dateFrom, DateTime dateTo, int gradeVisibility, int month)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@fecha_desde", SqlDbType.DateTime, 100);
            parameter.Value = dateFrom;
            parameters.Add(parameter);

            parameter = new SqlParameter("@fecha_hasta", SqlDbType.DateTime, 100);
            parameter.Value = dateTo;
            parameters.Add(parameter);

            if (gradeVisibility != 0)
            {
                parameter = new SqlParameter("@prioridad", SqlDbType.Int);
                parameter.Value = gradeVisibility;
                parameters.Add(parameter);
            }

            //if (!string.IsNullOrEmpty(month))
            if(month != 0)
            {
                parameter = new SqlParameter("@mes", SqlDbType.Int);
                parameter.Value = month;
                parameters.Add(parameter);
            }

            return parameters;
        }

        public static SqlDataReader GetPriorities()
        {
            return Connection.GetDataReader("SELECT GRADO_PUBLICACION_ID, GRADO_PUBLICACION_PRIORIDAD FROM EL_GROUP_BY.GRADO_PUBLICACION");
        }
    }
}
