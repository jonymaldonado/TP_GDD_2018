using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using MyLibrary;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class FormAMEmpresa : Form
    {
        string userId;
        bool isUpper = false;
        Form formPrevious;

        public FormAMEmpresa(FormEmpresa formAMEmpresa, bool isUpper, string userId)
        {
            InitializeComponent();
            this.isUpper = isUpper;
            this.formPrevious = formAMEmpresa;

            if (!isUpper) //Modificacion
            {
                this.userId = userId;
                this.LoadFieldsOfEmpresa();
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrevious.Show();
            this.Close();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CleanAllFields();
        }

        private void CleanAllFields()
        {
            txt_razon_social.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_cuit.Text = "";

            txt_street.Text = "";
            txt_number_street.Text = "";
            txt_floor.Text = "";
            txt_department.Text = "";
            txt_location.Text = "";
            txt_postal_code.Text = "";
            txt_city.Text = "";
            
        }

        private void LoadFieldsOfEmpresa()
        {
            SqlDataReader reader = EmpresaConnection.GetEmpresaForModify(this.userId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_razon_social.Text   = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    txt_email.Text          = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    txt_phone.Text          = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    txt_cuit.Text           = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    txt_street.Text         = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    txt_number_street.Text  = reader.IsDBNull(5) ? "" : reader.GetDecimal(5).ToString();
                    txt_floor.Text          = reader.IsDBNull(6) ? "" : reader.GetDecimal(6).ToString();
                    txt_department.Text     = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    txt_postal_code.Text    = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    txt_location.Text       = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    txt_city.Text           = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    
                }
            }

            reader.Close();
        }


    }
}
