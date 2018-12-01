using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EspectaculoDAO
    {

        public Int32 Espectaculo_ID {get; set;}
        public Int32 Espectaculo_Codigo {get; set;}
        public String Espectaculo_Descripcion {get; set;}
        public String Espectaculo_Direccion {get; set;}
        public DateTime Espectaculo_Fecha {get; set;}
        public DateTime Espectaculo_Fecha_Vencimiento {get; set;}
        public String Espectaculo_Estado {get; set;}
        public Int32 Rubro_ID {get; set;}
        public Int32 Empresa_ID {get; set;}
               

    }
}
