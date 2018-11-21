using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public class Utilities
    {
        
        public static bool IsValidEmail(string inputEmail)
        {

            string email = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

            Regex re = new Regex(email);

            return (re.IsMatch(inputEmail));

        }

        public static bool IsValidCuit(string inputCuit)
        {

            //string cuitRegex = @"\b(20|23|24|27|30|33|34)(\D)?[0-9]{8}(\D)?[0-9]";
            string cuitRegex = @"[0-9]{2}(\D)?[0-9]{8}(\D)?[0-9]";

            Regex re = new Regex(cuitRegex);

            return (re.IsMatch(inputCuit));

        }



    }
}
