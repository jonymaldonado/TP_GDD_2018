﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UbicationDAO
    {
        public String Fila { get; set; }
        public Int32 Asiento { get; set; }
        public bool SinNumerar { get; set; }
        public Int32 Precio { get; set; }
        public UbicationTypeDAO type { get; set; }    
    }

    public class UbicationTypeDAO
    {
        public int id { get; set; }
        public decimal cod { get; set; }
        public String desc { get; set; }
        
    }

}