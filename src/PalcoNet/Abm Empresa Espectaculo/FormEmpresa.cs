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
using DAO;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
            dgv_list.DataSource = EmpresaConnection.ListExistingEmpresa(null).Tables[0];
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAMEmpresa form = new FormAMEmpresa(this, true, null);
            this.Hide();
            form.ShowDialog();
            
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ConfirmarBaja())
            {
                EmpresaDAO empresa = new EmpresaDAO() ;

                empresa.UserId = Convert.ToInt32(dgv_list.CurrentRow.Cells[0].Value.ToString());
                EmpresaConnection.DeleteEmpresa(empresa);
                MessageBox.Show("La Empresa ha sido dada de baja correctamente.");

                dgv_list.DataSource = EmpresaConnection.ListExistingEmpresa(null).Tables[0];
            }
        }

        private bool ConfirmarBaja()
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar la empresa seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_razon_social.Text = "";
            txt_cuit.Text = "";
            txt_email.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            EmpresaDAO empresa = new EmpresaDAO();

            empresa.RazonSocial = txt_razon_social.Text;
            empresa.Cuit = txt_cuit.Text;
            empresa.Email = txt_email.Text;
            dgv_list.DataSource = EmpresaConnection.ListExistingEmpresa(empresa).Tables[0];
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userId = dgv_list.CurrentRow.Cells[0].Value.ToString();

            FormAMEmpresa form = new FormAMEmpresa(this, false, userId);
            this.Hide();
            form.ShowDialog();
        }

    }
}
