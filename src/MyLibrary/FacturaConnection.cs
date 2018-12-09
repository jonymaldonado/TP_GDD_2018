using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DAO;
using MyLibrary;
using Microsoft.SqlServer.Server;

namespace MyLibrary
{
    public class FacturaConnection
    {
        public static int CreateFactura(FacturaDAO factura)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter parameter;

            parameter = new SqlParameter("@FECHA", SqlDbType.DateTime);
            parameter.Value = factura.Factura_Fecha;
            parameters.Add(parameter);

            parameter = new SqlParameter("@TOTAL", SqlDbType.Decimal);
            parameter.Value = factura.Factura_Total;
            parameters.Add(parameter);

            parameter = new SqlParameter("@EMPRESA_ID", SqlDbType.Int);
            parameter.Value = factura.Factura_Empresa_ID;
            parameters.Add(parameter);

            // Obtiene el id de la factura creara
            SqlParameter facturaID = new SqlParameter("@FACTURA_ID", SqlDbType.Int);
            facturaID.Size = sizeof(int);
            facturaID.Direction = ParameterDirection.Output;
            parameters.Add(facturaID);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_FACTURA", Connection.Type.StoredProcedure, parameters);

            return Convert.ToInt32(facturaID.Value);

        }

        public static void CreateItems(List<ItemDAO> items)
        {
            var dataTable = new List<SqlDataRecord>();

            foreach (ItemDAO item in items)
            {

                var rec = new SqlDataRecord(
                                new SqlMetaData("Item_Monto", SqlDbType.Decimal, 18,2),
                                new SqlMetaData("Item_Cantidad", SqlDbType.Decimal),
                                new SqlMetaData("Item_Descripcion", SqlDbType.NVarChar, 255),
                                new SqlMetaData("Factura_ID", SqlDbType.Int),
                                new SqlMetaData("Compra_ID", SqlDbType.Int)
                                );
                
                rec.SetDecimal(0, item.Item_Monto);
                rec.SetDecimal(1, item.Item_Cantidad);
                rec.SetString(2, item.Item_Descripcion);
                rec.SetInt32(3, item.Factura_ID);
                rec.SetInt32(4, item.Compra_ID);
                
                dataTable.Add(rec);

            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@ITEMS";
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dataTable;
            parameters.Add(parameter);

            Connection.WriteInTheBase("EL_GROUP_BY.CREAR_ITEMS", Connection.Type.StoredProcedure, parameters);

        }

    }
}
