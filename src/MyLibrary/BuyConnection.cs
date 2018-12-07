using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using MyLibrary;
using System.Configuration;

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

        public static SqlDataReader GetCreditCard(Int32 ClieID)
        {
            return Connection.GetDataReader("SELECT Cliente_Tarjeta_Numero, Cliente_Tarjeta_Marca FROM EL_GROUP_BY.Cliente WHERE Cliente_ID = "+ClieID);
        }


        public static void CreateBuy(CompraDAO compra, List<UbicationDAO> ubicaciones, Int32 IdEmpresa)
        {
            DataTable dataTable = new DataTable("PUBLICACION_UBICACION_TIPO_TABLA");

            dataTable.Columns.Add("Ubicacion_ID", typeof(int));
            dataTable.Columns.Add("Publicacion_ID", typeof(int));
            
            foreach (UbicationDAO ubicacion in ubicaciones)
            {
                dataTable.Rows.Add( ubicacion.UbicacionId,
                                    ubicacion.PubliID );
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@UBICACIONES";
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dataTable;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FECHA", SqlDbType.DateTime);
            parameter.Value = compra.Compra_Fecha;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CANTIDAD", SqlDbType.BigInt);
            parameter.Value = compra.Compra_Cantidad;
            parameters.Add(parameter);

            parameter = new SqlParameter("@MONTO", SqlDbType.BigInt);
            parameter.Value = compra.Compra_Monto_Total;
            parameters.Add(parameter);

            parameter = new SqlParameter("@CLIENTE_ID", SqlDbType.Int);
            parameter.Value = compra.Cliente_ID;
            parameters.Add(parameter);

            parameter = new SqlParameter("@FORMA_PAGO", SqlDbType.Int);
            parameter.Value = compra.Forma_Pago_ID;
            parameters.Add(parameter);

            //Se otorgan 10 puntos por cada localidad comprada
            parameter = new SqlParameter("@PUNTOS", SqlDbType.Decimal);
            parameter.Value = (int) compra.Compra_Monto_Total;
            parameters.Add(parameter);

            //Los puntos se vencen 6 meses despues de la fecha de compra que los generó
            parameter = new SqlParameter("@VENCIMIENTO", SqlDbType.DateTime);
            parameter.Value = compra.Compra_Fecha.AddMonths(6);
            parameters.Add(parameter);
            
            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_COMPRA", Connection.Type.StoredProcedure, parameters);

        }

    }
}
