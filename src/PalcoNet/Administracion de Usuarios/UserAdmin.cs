using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MyLibrary;

namespace PalcoNet.Administracion_de_Usuarios
{
    public partial class UserAdmin : Form
    {
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_list.DataSource = UserConnection.ListUsers(txt_search_name.Text).Tables[0];
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                UserConnection.SetUserStatus(Convert.ToInt32(row.Cells["Usuario_ID"].Value),true);   
            }
            dgv_list.DataSource = UserConnection.ListUsers(txt_search_name.Text).Tables[0];
        }

        private void btn_deshabilitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                UserConnection.SetUserStatus(Convert.ToInt32(row.Cells["Usuario_ID"].Value), false);
            }
            dgv_list.DataSource = UserConnection.ListUsers(txt_search_name.Text).Tables[0];
        }
    }
}
