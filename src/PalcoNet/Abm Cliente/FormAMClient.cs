using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MyLibrary;

namespace PalcoNet.Abm_Cliente
{
    public partial class FormAMClient : Form
    {
        string userId;
        bool isUpper = false;
        Form formPrevious;
        Comprar.FormToBuy formPreviusCompra;

        string user = null;
        string password = null;
        bool isRegisterUser = false;
        bool creditCardChange = false;

        //Alta/modificacion de Cliente
        public FormAMClient(FormClient formClient, bool isUpper, string userId)
        {
            InitializeComponent();
            ModifyScreen();
            
            this.isUpper = isUpper;
            this.chk_active.Visible = false;
            this.formPrevious = formClient;
        
            if (!isUpper) // is modification
            {
                this.userId = userId;
                this.chk_active.Visible = true;
                this.LoadFieldsOfClient();
            }
        }

        //Llamada para cambio de tarjeta de credito
        public FormAMClient(Comprar.FormToBuy FormCompra, Int32 ClientId)
        {
            InitializeComponent();
            ModifyScreen();
            
            this.isUpper = false;
            this.chk_active.Visible = true;
            this.formPrevious = FormCompra;
            this.formPreviusCompra = FormCompra;
            this.userId = Convert.ToString(ClientConnection.GetUserId(ClientId));
            this.LoadFieldsOfClient();
            
            this.creditCardChange = true;
            groupBox3.Enabled = false;
            returnToolStripMenuItem.Enabled = false;

        }

        //Registro de nuevo cliente
        public FormAMClient(Registro_de_Usuario.FormUserRegister formRegisterUser, string user, string password)
        {
            InitializeComponent();
            ModifyScreen();
                
            this.isRegisterUser = true;
            this.user = user;
            this.password = password;
            this.formPrevious = formRegisterUser;
            
        }

        private void ModifyScreen()
        {
            txt_number_doc.MaxLength = 10;
            txt_cuil.MaxLength = 20;
            txt_number_card.MaxLength = 16;
            this.LoadDocs();

            this.txt_cuil.Validating += txt_cuil_Validating;
            this.txt_email.Validating += txt_email_Validating;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrevious.Show();
            this.Close();
        }

        private void LoadDocs()
        {
            cmb_type_doc.Items.Add("DNI");
            cmb_type_doc.Items.Add("DUI");
            cmb_type_doc.Items.Add("CI");
            cmb_type_doc.Items.Add("Otro");
        }

        private void LoadFieldsOfClient()
        {
            SqlDataReader reader = ClientConnection.GetUserForModify(this.userId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_name.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    txt_surname.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    this.GetMatchItem(reader.GetString(2));
                    txt_number_doc.Text = reader.IsDBNull(3) ? "" : reader.GetDecimal(3).ToString();
                    dtp_birthdate.Value = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                    txt_cuil.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    txt_street.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    txt_number_street.Text = reader.IsDBNull(7) ? "" : reader.GetDecimal(7).ToString();
                    txt_floor.Text = reader.IsDBNull(8) ? "" : reader.GetDecimal(8).ToString();
                    txt_department.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    txt_location.Text = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    txt_postal_code.Text = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    txt_phone.Text = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    txt_email.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                    txt_number_card.Text = reader.IsDBNull(15) ? "" : reader.GetString(14);
                    txt_name_card.Text = reader.IsDBNull(14) ? "" : reader.GetString(15);

                    if (reader.GetSqlBoolean(16))
                        chk_active.Checked = true;
                    
                }
            }

            reader.Close();
        }

        private void GetMatchItem(string match)
        {   
            cmb_type_doc.SelectedIndex = cmb_type_doc.FindStringExact(match); 
        }
        
        private void CreateClient()
        {
            if (this.AreAllTheDataCompleted())
            {
                ClientDAO clientDAO = GetClientDAO(this.user, this.password);

                ClientConnection.CreateClient(clientDAO);
                MessageBox.Show("El nuevo cliente ha sido creado correctamente.");

                if (isRegisterUser)
                {
                    this.Close();
                    formPrevious.Close();
                    return;
                }

                this.AskIfYouWantToAddAnotherClient();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }

        private ClientDAO GetClientDAO(string user, string password) 
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.User = (string.IsNullOrEmpty(user)) ? txt_name.Text + txt_number_doc.Text : user;
            clientDAO.Password = (string.IsNullOrEmpty(password)) ? txt_number_doc.Text : password;
            clientDAO.FirstName = txt_name.Text;
            clientDAO.LastName = txt_surname.Text;
            clientDAO.TypeDoc = cmb_type_doc.Text;
            clientDAO.NumberDoc = Convert.ToInt32(txt_number_doc.Text);
            clientDAO.Cuil = txt_cuil.Text;
            clientDAO.Phone = txt_phone.Text;
            clientDAO.Email = txt_email.Text;
            clientDAO.Street = txt_street.Text;
            clientDAO.NumberStreet = txt_number_street.Text;
            clientDAO.Floor = txt_floor.Text;
            clientDAO.Department = txt_department.Text;
            clientDAO.Location = txt_location.Text;
            clientDAO.PostalCode = txt_postal_code.Text;
            clientDAO.BirthDate = Convert.ToDateTime(dtp_birthdate.Value.Date.ToString());
            clientDAO.CardName = txt_name_card.Text;
            clientDAO.CardNumber = txt_number_card.Text;
            clientDAO.FirstLogin = !this.isRegisterUser;

            return clientDAO;
        }

        private void AskIfYouWantToAddAnotherClient()
        {
            if (this.ConfirmAddClient())
            {
                this.CleanAllFields();
            }
            else
            {
                formPrevious.Show();
                this.Close();
            }
        }

        private void CleanAllFields()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_number_doc.Text = "";
            txt_cuil.Text = "";
            txt_street.Text = "";
            txt_number_street.Text = "";
            txt_floor.Text = "";
            txt_department.Text = "";
            txt_location.Text = "";
            txt_postal_code.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_name_card.Text = "";
            txt_number_card.Text = "";
        }

        private bool AreAllTheDataCompleted()
        {
            bool resultado = false;

            if(this.creditCardChange)
            {
                resultado = (!string.IsNullOrEmpty(txt_name_card.Text)
                            && !string.IsNullOrEmpty(txt_number_card.Text));
            }
            else
            {
                resultado = (!string.IsNullOrEmpty(txt_name.Text)
                    && !string.IsNullOrEmpty(txt_surname.Text)
                    && !string.IsNullOrEmpty(cmb_type_doc.Text)
                    && !string.IsNullOrEmpty(txt_number_doc.Text)
                    && !string.IsNullOrEmpty(dtp_birthdate.Value.ToString())
                    && !string.IsNullOrEmpty(txt_cuil.Text)
                    && !string.IsNullOrEmpty(txt_street.Text)
                    && !string.IsNullOrEmpty(txt_number_street.Text)
                    && !string.IsNullOrEmpty(txt_location.Text)
                    && !string.IsNullOrEmpty(txt_postal_code.Text)
                    && !string.IsNullOrEmpty(txt_phone.Text)
                    && !string.IsNullOrEmpty(txt_email.Text)
                    && !string.IsNullOrEmpty(txt_name_card.Text)
                    && !string.IsNullOrEmpty(txt_number_card.Text));
            }

            return resultado;
        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(txt_number_doc.Text))
                if (ExistsDoc())
                {
                    MessageBox.Show("El "+cmb_type_doc.Text+" "+ txt_number_doc.Text+" ya existe en el sistema. Ingrese uno diferente.");
                    return;
                }

            if (!string.IsNullOrEmpty(txt_cuil.Text))
                if (ExistsCuil())
                {
                    MessageBox.Show("El Cuil "+ txt_cuil.Text +" ya existe en el sistema. Ingrese uno diferente.");
                    return;
                }

            if (this.isUpper || this.isRegisterUser)
                this.CreateClient();
            else
                this.UpdateClient();
        }

        private Boolean ConfirmAddClient()
        {
            DialogResult result = MessageBox.Show("¿Desea agregar otro cliente ahora?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void UpdateClient()
        {
            if (this.AreAllTheDataCompleted())
            {
                ClientDAO clientDAO = GetClientDAO(null, null);

                ClientConnection.UpdateClient(clientDAO, this.userId, this.chk_active.Checked);

                if(!this.creditCardChange)
                    MessageBox.Show("La modificación ha sido realizada correctamente.");
                else
                {
                    MessageBox.Show("Se ha actualizado la tarjeta de crédito exitosamente.");
                    this.formPreviusCompra.CreditCardOk = true;
                }
                    

                formPrevious.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }
        private void txt_email_Validating(object sender, CancelEventArgs e)
        {

            if (!Utilities.IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("El Email es inválido");
                e.Cancel = true;
            }
            else
                e.Cancel = false;

        }

        private void txt_cuil_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilities.IsValidCuit(txt_cuil.Text))
            {
                MessageBox.Show("El CUIL es inválido");
                e.Cancel = true;
            }
            else
                e.Cancel = false;

        }

        private void txt_numeric_KeyPress(object sender, KeyPressEventArgs e)
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

        private bool ExistsDoc()
        {
            return ClientConnection.ExistsDoc(cmb_type_doc.Text.Trim(), txt_number_doc.Text.Trim(), this.userId);
        }

        private bool ExistsCuil()
        {
            return ClientConnection.ExistsCuil(txt_cuil.Text.Trim(), this.userId);
        }
    }

}
