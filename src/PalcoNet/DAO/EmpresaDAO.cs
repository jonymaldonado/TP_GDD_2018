﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmpresaDAO : UserDAO
    {
        public Int32 IdEmpresa { get; set; }
        public String RazonSocial { get; set; }
        public String Cuit { get; set; } 
        public String Ciudad { get; set; }
        
    }
}
