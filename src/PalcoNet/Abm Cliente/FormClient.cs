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

namespace PalcoNet.Abm_Cliente
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            dgv_list.DataSource = ClientConnection.ListExistingClients(null, null, null, null).Tables[0];
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_email.Text = "";
            txt_number_doc.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (this.ExistsValueEntered()) 
            {
                dgv_list.DataSource = ClientConnection.ListExistingClients(txt_name.Text
                                                                       , txt_surname.Text
                                                                       , txt_email.Text
                                                                       , txt_number_doc.Text).Tables[0];
            } 
            else 
            {
                MessageBox.Show("Debe completar al menos un filtro.");
            }
        }

        private bool ExistsValueEntered()
        {
            return txt_name.Text != "" || txt_surname.Text != "" || txt_email.Text != "" || txt_number_doc.Text != "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmarBaja())
            {
                string userId = dgv_list.CurrentRow.Cells[0].Value.ToString();
                ClientConnection.DeleteClient(userId);

                MessageBox.Show("El cliente ha sido dado de baja correctamente.");

                dgv_list.DataSource = ClientConnection.ListExistingClients(null, null, null, null).Tables[0];
            }
        }

        private bool ConfirmarBaja()
        {
            DialogResult result = MessageBox.Show("Realmente desea eliminar al cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAMClient form = new FormAMClient(this, true, null);
            this.Hide();
            form.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userId = dgv_list.CurrentRow.Cells[0].Value.ToString();

            FormAMClient form = new FormAMClient(this, false, userId);
            this.Hide();
            form.ShowDialog();
        }

    }
}
