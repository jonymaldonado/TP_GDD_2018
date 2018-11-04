using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClientDAO : UserDAO
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String TypeDoc { get; set; }
        public Int32 NumberDoc { get; set; }
    }
}
