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
    public partial class FormChangePassword : Form
    {
        private int userId;
        private string userName;


        public FormChangePassword()
        {
            InitializeComponent();
        }

        public FormChangePassword(int userId, string userName)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            txt_username.Text = this.userName;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();   
        }

        private bool MatchPasswords()
        {
            return txt_password.Text.Equals(txt_new_password.Text);
        }

        private bool AllCompleteFields()
        {
            return (!string.IsNullOrEmpty(txt_username.Text)
                    && !string.IsNullOrEmpty(txt_password.Text)
                    && !string.IsNullOrEmpty(txt_new_password.Text));
        }

        private void btn_change_password_Click(object sender, EventArgs e)
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
                txt_new_password.Text = "";
                return;
            }

            string newPassword = txt_password.Text;

            UserConnection.UpdatePassword(userId, newPassword);
            MessageBox.Show("La nueva contraseña ha sido actualizada correctamente.");
            this.Dispose();
        }
    }
}
