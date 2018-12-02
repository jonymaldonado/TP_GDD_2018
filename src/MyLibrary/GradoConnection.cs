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
    public class GradoConnection
    {
        public static DataSet ListExistingGrado(GradoDAO grado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@PRIORIDAD", SqlDbType.VarChar, 255);
            parameter.Value = DBNull.Value;
            if ((grado != null) && !String.IsNullOrEmpty(grado.Prioridad))
            {
                parameter.Value = grado.Prioridad;
            }
            parameters.Add(parameter);

            DataSet ds = Connection.GetDataSet("EL_GROUP_BY.LISTAR_GRADOS", Connection.Type.StoredProcedure, parameters);

            return ds;
        }

        public static void DeleteGrado(GradoDAO grado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@ID", SqlDbType.Int, 100);
            parameter.Value = grado.Id;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.ELIMINAR_GRADO", Connection.Type.StoredProcedure, parameters);
        }

        public static void CreateGrado(GradoDAO grado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
                       
            LoadParameters(grado, parameters);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_GRADO", Connection.Type.StoredProcedure, parameters);
        }

        private static void LoadParameters(GradoDAO grado, List<SqlParameter> parameters)
        {
            SqlParameter parameter;

            parameter = new SqlParameter("@COMISION", SqlDbType.Decimal);
            parameter.Value = grado.Comision;
            parameters.Add(parameter);

            parameter = new SqlParameter("@PRIORIDAD", SqlDbType.VarChar, 10);
            parameter.Value = grado.Prioridad;
            parameters.Add(parameter);

        }

        public static SqlDataReader GetGradoForModify(Int32 id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", id));
            SqlDataReader reader = Connection.GetDataReader("EL_GROUP_BY.OBTENER_GRADO_FOR_MODIFY", Connection.Type.StoredProcedure, parameters);

            return reader;
        }

        public static void UpdateGrado(GradoDAO grado, Int32 id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@ID", SqlDbType.Int, 50);
            parameter.Value = id;
            parameters.Add(parameter);

            LoadParameters(grado, parameters);

            Connection.WriteInTheBase("EL_GROUP_BY.ACTUALIZAR_GRADO", Connection.Type.StoredProcedure, parameters);
        }


    }
}
