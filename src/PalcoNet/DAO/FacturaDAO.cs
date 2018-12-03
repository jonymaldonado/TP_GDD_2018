using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FacturaDAO
    {
        public Int32 Factura_ID { get; set; }
		public Int32 Factura_Nro { get; set; }
		public DateTime Factura_Fecha { get; set; }
		public Decimal Factura_Total { get; set; }
        public Int32 Factura_Empresa_ID { get; set; }
    }
}
