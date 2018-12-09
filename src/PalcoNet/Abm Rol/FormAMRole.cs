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
    public partial class FormAMRole : Form
    {
        private static BindingList<FunctionDAO> addedFunctions = new BindingList<FunctionDAO>();
        private static BindingList<FunctionDAO> removedFunctions = new BindingList<FunctionDAO>();

        private RoleDAO role;

        public FormAMRole()
        {
            InitializeComponent();
        }

        public FormAMRole(RoleDAO oneRole, bool isSignUp, Boolean available)
        {
            InitializeComponent();

            addedFunctions.Clear();
            removedFunctions.Clear();

            role = oneRole;

            txt_name.Text = role.Name;
            txt_name.Enabled = false;
            
        
            if (isSignUp)
            {
                chk_enabled.Visible = false;

                List<FunctionDAO> functions = FunctionConnection.GetFunctions();

                foreach (FunctionDAO item in functions)
                {
                    removedFunctions.Add(item);
                }

                lst_functions_not_added.DataSource = removedFunctions;
                lst_functions_not_added.DisplayMember = "Nombre";

                lst_functions_added.DataSource = addedFunctions;
                lst_functions_added.DisplayMember = "Nombre";
            }
            else
            {
                if (available) chk_enabled.Checked = true;
                else chk_enabled.Checked = false;


                List<FunctionDAO> fadd = FunctionConnection.GetFunctionsForRole(role.Id);

                foreach (FunctionDAO item in fadd)
                {
                    addedFunctions.Add(item);
                }

                lst_functions_added.DataSource = addedFunctions;
                lst_functions_added.DisplayMember = "Nombre";

                List<FunctionDAO> fNotadd = FunctionConnection.GetFunctionsNotAssignedForRole(role.Id);

                foreach (FunctionDAO item in fNotadd)
                {
                    removedFunctions.Add(item);
                }
            
                lst_functions_not_added.DataSource = removedFunctions;
                lst_functions_not_added.DisplayMember = "Nombre";
            } 
        }

         private void acceptToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Boolean enabled = chk_enabled.Checked;

             String newName = txt_name.Text.Trim();

             if (string.IsNullOrEmpty(newName))
             {
                 MessageBox.Show("Debe ingresar el nombre del rol.");
                 return;
             }

             RoleConnection.UpdateName(role.Id, newName, enabled);

             foreach (FunctionDAO function in addedFunctions)
             {
                 RoleConnection.AddFunction(role, function);
             }

             foreach (FunctionDAO function in removedFunctions)
             {
                  RoleConnection.DeleteFunction(role, function);
             }

             MessageBox.Show("La modificación del nombre y/o estado del rol la verá una vez hecho click en Reestablecer.");

             this.Close();
         }

         private void returnToolStripMenuItem_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btn_change_name_Click(object sender, EventArgs e)
         {
             txt_name.Enabled = true;
         }

         private void btn_add_Click(object sender, EventArgs e)
         {
             if (lst_functions_not_added.SelectedIndex >= 0 )
             {

                 FunctionDAO itemSelected = (FunctionDAO)lst_functions_not_added.Items[lst_functions_not_added.SelectedIndex];
                 addedFunctions.Add(itemSelected);
                 removedFunctions.Remove(itemSelected);

                 //RoleConnection.AddFunction(role, itemSelected);
             }
         }

         private void btn_delete_Click(object sender, EventArgs e)
         {
             if (lst_functions_added.SelectedIndex >= 0)
             {
                 FunctionDAO itemSelected = (FunctionDAO)lst_functions_added.Items[lst_functions_added.SelectedIndex];
                 removedFunctions.Add(itemSelected);
                 addedFunctions.Remove(itemSelected);

                 //RoleConnection.DeleteFunction(role, itemSelected);
             }
         }
    }
}
