using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ItemDAO
    {
        public Int32 Item_ID { get; set; }
		public Int32 Item_Monto { get; set; }
		public Int32 Item_Cantidad { get; set; }
		public String Item_Descripcion { get; set; }
		public Int32 Factura_ID { get; set; }
        public Int32 Compra_ID { get; set; }

    }
}
