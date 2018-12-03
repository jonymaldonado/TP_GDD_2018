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
            DataTable dataTable = new DataTable("ITEM_TIPO");

            dataTable.Columns.Add("Item_Monto", typeof(Decimal));
            dataTable.Columns.Add("Item_Cantidad", typeof(Decimal));
            dataTable.Columns.Add("Item_Descripcion", typeof(String));
            dataTable.Columns.Add("Factura_ID", typeof(int));
            dataTable.Columns.Add("Compra_ID", typeof(int));
           
            foreach (ItemDAO item in items)
            {
                dataTable.Rows.Add( item.Item_Monto,
                                    item.Item_Cantidad,
                                    item.Item_Descripcion,
                                    item.Factura_ID,
                                    item.Compra_ID
                                  );
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
