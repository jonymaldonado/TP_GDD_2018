using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PublicationDAO : EspectaculoDAO
    {
        public Int32 PubliID { get; set; }
        public String Description { get; set; }
        public DateTime PublicDate { get; set; } //Fecha en que se publica
        public DateTime EspecDate { get; set; }  // Fecha que se lleva a cabo el espectaculo
        public Int32 CantLoc { get; set; }
        public String Username { get; set; }
        public Int32 EspecID { get; set; }
        public Int32 GradeID { get; set; }
        public Int32 StateID { get; set; }

    }


}
