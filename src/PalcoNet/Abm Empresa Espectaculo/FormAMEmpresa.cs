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
        public EmpresaDAO empresa = new EmpresaDAO();
        string userId;
        bool isUpper = false;
        Form formPrevious;

        string user = null;
        string password = null;
        bool isRegisterUser = false;

        public FormAMEmpresa(FormEmpresa formAMEmpresa, bool isUpper, string userId)
        {
            InitializeComponent();
            this.isUpper = isUpper;
            this.formPrevious = formAMEmpresa;

            if (!isUpper) //Modificacion
            {
                this.chk_active.Visible = true;
                this.userId = userId;
                this.LoadFieldsOfEmpresa();
            }
        }

        public FormAMEmpresa(Registro_de_Usuario.FormUserRegister formUserRegister, string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            formPrevious = formUserRegister;
            isRegisterUser = true;
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

                    if(reader.GetSqlBoolean(11))
                        chk_active.Checked = true;
                    
                }
            }

            reader.Close();
        }

        private void UpdateEmpresa()
        {
            if (this.checkMandatoryFields())
            {
                EmpresaDAO empresa = GetEmpresaDAO(null, null);

                EmpresaConnection.UpdateEmpresa(empresa, this.userId, this.chk_active.Checked);
                MessageBox.Show("La modificación de la empresa ha sido realizada correctamente.");
                formPrevious.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }

        private void CreateEmpresa()
        {
            if (this.checkMandatoryFields())
            {
                EmpresaDAO empresaDAO = GetEmpresaDAO(this.user, this.password);

                EmpresaConnection.CreateEmpresa(empresaDAO);
                MessageBox.Show("La nueva Empresa ha sido creado correctamente.");
                this.CleanAllFields();

                if (isRegisterUser)
                {
                    this.Close();
                    this.formPrevious.Close();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }

        private bool checkMandatoryFields()
        {
            return (!string.IsNullOrEmpty(txt_razon_social.Text)
                    && !string.IsNullOrEmpty(txt_phone.Text)
                    && !string.IsNullOrEmpty(txt_email.Text)
                    && !string.IsNullOrEmpty(txt_cuit.Text)
                    && !string.IsNullOrEmpty(txt_street.Text)
                    && !string.IsNullOrEmpty(txt_number_street.Text)
                    && !string.IsNullOrEmpty(txt_location.Text)
                    && !string.IsNullOrEmpty(txt_postal_code.Text)
                    && !string.IsNullOrEmpty(txt_city.Text));

        }

        private EmpresaDAO GetEmpresaDAO(string user, string password)
        {
            EmpresaDAO empresa = new EmpresaDAO();

            empresa.User = (string.IsNullOrEmpty(user)) ? txt_razon_social.Text + txt_cuit.Text : user;
            empresa.Password = (string.IsNullOrEmpty(password)) ? txt_cuit.Text : password;
            empresa.RazonSocial = txt_razon_social.Text;
            empresa.Cuit = txt_cuit.Text;
            empresa.Email = txt_email.Text;
            empresa.Ciudad = txt_city.Text;   
            empresa.Phone = txt_phone.Text;
            empresa.Street = txt_street.Text;
            empresa.NumberStreet = txt_number_street.Text;
            empresa.Floor = txt_floor.Text;
            empresa.Department = txt_department.Text;
            empresa.Location = txt_location.Text;
            empresa.PostalCode = txt_postal_code.Text;
            empresa.FirstLogin = !this.isRegisterUser;

            return empresa;
        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ExistsRazonSocial())
            {
                MessageBox.Show("La Razón Social " + txt_razon_social.Text + " ya existe en el sistema. Ingrese una diferente.", "Error");
                return;
            }

            if (ExistsCuit())
            {
                MessageBox.Show("El Cuit " + txt_cuit.Text + " ya existe en el sistema. Ingrese uno diferente.");
                return;
            }

            if (this.isUpper || this.isRegisterUser)
                this.CreateEmpresa();
            else
                this.UpdateEmpresa();
        }



        private void txt_number_street_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo deja numericos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        private void txt_floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo deja numericos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {

            if(!Utilities.IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("El Email es inválido");
                e.Cancel = true;
            }
            else
                e.Cancel = false;            

        }

        private void txt_cuit_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilities.IsValidCuit(txt_cuit.Text))
            {
                MessageBox.Show("El CUIT es inválido");
                e.Cancel = true;
            }
            else
                e.Cancel = false;

        }

        private bool ExistsRazonSocial()
        {
            return EmpresaConnection.ExistsRazonSocial(txt_razon_social.Text, this.userId);
        }

        private bool ExistsCuit()
        {
            return EmpresaConnection.ExistsCuit(txt_cuit.Text, this.userId);
        }
        
    }
}
