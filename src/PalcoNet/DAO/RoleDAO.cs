using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoleDAO
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Boolean State { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " - " + Name;
        }
    }

}
