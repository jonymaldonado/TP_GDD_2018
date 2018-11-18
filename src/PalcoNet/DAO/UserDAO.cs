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
        public String Phone { get; set; }
        public String Street { get; set; }
        public String NumberStreet { get; set; }
        public String Floor { get; set; }
        public String Department { get; set; }
        public String PostalCode { get; set; }
        public String Location { get; set; }
        public String Email { get; set; }
    }
}
