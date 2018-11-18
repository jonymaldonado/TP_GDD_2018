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

        public FormAMClient(FormClient formAMCliente, bool isUpper, string userId)
        {
            InitializeComponent();
            this.isUpper = isUpper;
            this.formPrevious = formAMCliente;
            this.LoadDocs();

            if (!isUpper) // is modification
            {
                this.userId = userId;
                this.LoadFieldsOfClient();
            }
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
            cmb_type_doc.Items.Add("Otros");
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
                    txt_number_card.Text = reader.IsDBNull(15) ? "" : reader.GetDecimal(14).ToString();
                    txt_name_card.Text = reader.IsDBNull(14) ? "" : reader.GetString(15);
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
                ClientDAO clientDAO = GetClientDAO();

                ClientConnection.CreateClient(clientDAO);
                MessageBox.Show("El nuevo cliente ha sido creado correctamente.");
                this.AskIfYouWantToAddAnotherClient();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }

        private ClientDAO GetClientDAO() 
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.User = txt_name.Text + txt_number_doc.Text;
            clientDAO.Password = txt_number_doc.Text;
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
            clientDAO.BirthDate = Convert.ToDateTime(dtp_birthdate.Value.Date.ToString()); ;
            clientDAO.CardName = txt_name_card.Text;
            clientDAO.CardNumber = Convert.ToInt64(txt_number_card.Text);

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
            return (!string.IsNullOrEmpty(txt_name.Text)
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

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isUpper)
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
                ClientDAO clientDAO = GetClientDAO();

                ClientConnection.UpdateClient(clientDAO, this.userId);
                MessageBox.Show("La modificación del cliente ha sido realizada correctamente.");
                formPrevious.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
            }
        }
    }

}
