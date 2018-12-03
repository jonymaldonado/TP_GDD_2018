using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace PalcoNet.Registro_de_Usuario
{
    public partial class FormUserRegister : Form
    {
        private const string CLIENTE = "CLIENTE";
        private const string EMPRESA = "EMPRESA";

        private int userId;

        public FormUserRegister()
        {
            InitializeComponent();
            LoadComboRoles();
        }

        public FormUserRegister(int userId)
        {
            this.userId = userId;
        }

        private void LoadComboRoles()
        {
            cmb_role.Items.Add("CLIENTE");
            cmb_role.Items.Add("EMPRESA");

            cmb_role.SelectedIndex = 0;
        }

        private bool MatchPasswords()
        {
            return txt_password.Text.Equals(txt_confirm_password.Text);
        }

        private bool AllCompleteFields()
        {
            return (!string.IsNullOrEmpty(txt_user.Text)
                    && !string.IsNullOrEmpty(txt_password.Text)
                    && !string.IsNullOrEmpty(txt_confirm_password.Text));
        }

        private void btn_enter_data_Click(object sender, EventArgs e)
        {
            if (!AllCompleteFields()) 
            {
                MessageBox.Show("Debe completar los datos faltantes.");
                return;
            }

            if (!MatchPasswords())
            {
                MessageBox.Show("Los contraseñas no coinciden, Intente nuevamente.");
                txt_password.Text = "";
                txt_confirm_password.Text = "";
                return;
            }

            if (ExistsUserName())
            {
                MessageBox.Show("El nombre de usuario ya existe en el sistema. Ingrese uno diferente.");
                return;
            }

            string selectedRole = cmb_role.Text;

            if (selectedRole.Equals(CLIENTE))
            {
                Abm_Cliente.FormAMClient form = new Abm_Cliente.FormAMClient(this, txt_user.Text, txt_password.Text);
                this.Hide();
                form.ShowDialog();
            }

            if (selectedRole.Equals(EMPRESA))
            {
                Abm_Empresa_Espectaculo.FormAMEmpresa form = new Abm_Empresa_Espectaculo.FormAMEmpresa(this, txt_user.Text, txt_password.Text);
                this.Hide();
                form.ShowDialog();
            }
        }

        private bool ExistsUserName()
        {
            return 1 == UserConnection.ExistsUserName(txt_user.Text.Trim());
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();   
        }
    }

}
