﻿using System;
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
        public Historial_Cliente.FormClientHistory previusForm;

        public FormClient()
        {   
            InitializeComponent();
            btn_select.Visible = false;
            txt_number_doc.MaxLength = 10;
            
        }

        public FormClient(Historial_Cliente.FormClientHistory previusForm)
        {
            InitializeComponent();
            btn_select.Visible = true;
            this.previusForm = previusForm;
            txt_number_doc.MaxLength = 10;

            addToolStripMenuItem.Visible = false;
            deleteToolStripMenuItem.Visible = false;
            updateToolStripMenuItem.Visible = false;

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
            dgv_list.DataSource = ClientConnection.ListExistingClients(txt_name.Text
                                                                    , txt_surname.Text
                                                                    , txt_email.Text
                                                                    , txt_number_doc.Text).Tables[0];
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            string userId = dgv_list.CurrentRow.Cells[0].Value.ToString();
            ClientConnection.DeleteClient(userId);

            MessageBox.Show("El cliente ha sido dado de baja correctamente.");

            dgv_list.DataSource = ClientConnection.ListExistingClients(null, null, null, null).Tables[0];
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

        private void btn_select_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(dgv_list.CurrentRow.Cells[0].Value);
            this.previusForm.ClientId = ClientConnection.GetClientIdWithUserId(userId);

            this.Close();
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

        private void FormClient_Activated(object sender, EventArgs e)
        {
            dgv_list.DataSource = ClientConnection.ListExistingClients(null, null, null, null).Tables[0];
        }

    }
}
