using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
        public Int32 UserId { get; set; }
        public String User { get; set; }
        public String Password { get; set; }

        public String Email { get; set; }
        public String Telefono { get; set; }
        public String Calle { get; set; }
        public Int32 Piso { get; set; }
        public String Depto { get; set; }
        public String Localidad { get; set; }
        public String CodigoPostal { get; set; }

    }
}
