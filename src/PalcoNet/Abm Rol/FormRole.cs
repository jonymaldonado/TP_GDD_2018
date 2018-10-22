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

namespace PalcoNet.Abm_Rol
{
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            PreparareMenu(true);
            EnableFields(true);
            RoleConnection.LoadDGV(dg_rol);
            groupBoxAdd.Enabled = false;
        }

        private void EnableFields(bool state)
        {
            this.txt_add_name.Enabled = state;
            this.btn_search.Enabled = state;
            this.dg_rol.Enabled = state;
        }

        private void PreparareMenu(bool state)
        {
            this.addToolStripMenuItem.Enabled = state;
            this.modifyToolStripMenuItem.Enabled = state;
            this.deleteToolStripMenuItem.Enabled = state;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Enabled = true;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(dg_rol.CurrentRow.Cells["Rol_Id"].Value);
            String nombre = Convert.ToString(dg_rol.CurrentRow.Cells["Rol_Nombre"].Value);

            Boolean available = Convert.ToBoolean(dg_rol.CurrentRow.Cells[2].Value);

            RoleDAO role = new RoleDAO();
            role.Id = id;
            role.Name = nombre;

            this.Hide();
            FormAMRole form = new FormAMRole(role, false, available);
            form.ShowDialog();
            this.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(dg_rol.CurrentRow.Cells["Rol_Id"].Value);

            if (MessageBox.Show("¿Realmente desea eliminar el rol seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RoleConnection.DeleteRole(id);
                RoleConnection.LoadDGV(dg_rol);
            }  
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_add_name.Text.Trim()))
            {
                RoleDAO role = new RoleDAO();

                role.Name = txt_add_name.Text.Trim();
                role.State = chk_available.Checked;

                RoleConnection.SaveRole(role);

                Int32 id = RoleConnection.GetRoleId(txt_add_name.Text.Trim());
                role.Id = id;

                if (MessageBox.Show("¿Desea agregarle funcionalidades ahora?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    FormAMRole form = new FormAMRole(role, true, false);
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("El rol se ha guardado correctamente.");
                    txt_add_name.Text = "";
                    chk_available.Checked = false;
                    groupBoxAdd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar el nombre del nuevo rol.");
            }

            RoleConnection.LoadDGV(dg_rol);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_search_name.Text.Trim()))
            {
                string word = txt_search_name.Text.Trim();
                RoleConnection.SearchRole(dg_rol, word);

            }
            else
            {
                MessageBox.Show("Ingrese un rol a buscar por favor.");
            }
        }

        private void btn_reestablish_Click(object sender, EventArgs e)
        {
            RoleConnection.LoadDGV(dg_rol);
            txt_search_name.Text = "";
        }

    }

}
