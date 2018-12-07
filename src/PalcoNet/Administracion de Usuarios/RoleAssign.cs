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
    public partial class RoleAssign : Form
    {
        private static BindingList<RoleDAO> addedRoles = new BindingList<RoleDAO>();
        private static BindingList<RoleDAO> removedRoles = new BindingList<RoleDAO>();

        public string username;
        public Int32 userid;

        public RoleAssign(Int32 userid, string username)
        {
            InitializeComponent();

            addedRoles.Clear();
            removedRoles.Clear();

            this.username = username;
            this.userid = userid;

            txt_username.Text = username;
            txt_userid.Text = userid.ToString();

            LoadRoles();
            
        }

        private void LoadRoles()
        {
            List<RoleDAO> radd = RoleConnection.GetRolesForUser(this.userid, "EL_GROUP_BY.LISTAR_ROL_X_USUARIO");

            foreach (RoleDAO item in radd)
            {
                
                addedRoles.Add(item);
            }

            lst_rol_added.DataSource = addedRoles;
            lst_rol_added.DisplayMember = "Nombre";

            List<RoleDAO> rNotadd = RoleConnection.GetRolesForUser(this.userid, "EL_GROUP_BY.LISTAR_ROL_X_USUARIO_NO_ASIGNADO");

            foreach (RoleDAO item in rNotadd)
            {
                removedRoles.Add(item);
            }

            lst_rol_not_added.DataSource = removedRoles;
            lst_rol_not_added.DisplayMember = "Nombre";

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (lst_rol_not_added.SelectedIndex >= 0)
            {

                RoleDAO itemSelected = (RoleDAO)lst_rol_not_added.Items[lst_rol_not_added.SelectedIndex];
                addedRoles.Add(itemSelected);
                removedRoles.Remove(itemSelected);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lst_rol_added.SelectedIndex >= 0)
            {
                RoleDAO itemSelected = (RoleDAO)lst_rol_added.Items[lst_rol_added.SelectedIndex];
                removedRoles.Add(itemSelected);
                addedRoles.Remove(itemSelected);
            }
        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (RoleDAO rol in addedRoles)
            {
                RoleConnection.AddUserRole(this.userid, rol);
            }

            foreach (RoleDAO rol in removedRoles)
            {
                RoleConnection.DeleteUserRole(this.userid, rol);
            }

            MessageBox.Show("La modificación ha sido exitosa", "Advertencia");

            this.Close();
        }
    }
}
