using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CompraDAO
    {
        public Int32 Compra_ID { get; set; }
        public DateTime Compra_Fecha { get; set; }
        public Int64 Compra_Cantidad { get; set; }
        public Int64 Compra_Monto_Total { get; set; }
        public Boolean Compra_Rendida { get; set; }
        public Int32 Cliente_ID { get; set; }
        public Int32 Forma_Pago_ID { get; set; }

    }
}
