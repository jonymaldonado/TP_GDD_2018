using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (!isUpper) 
            {
                this.userId = userId;
                //this.LoadFieldsOfClient();
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

    }
}
