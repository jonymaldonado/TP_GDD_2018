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

namespace PalcoNet.Abm_Grado
{
    public partial class FormGrado : Form
    {
        public FormGrado()
        {
            InitializeComponent();
            this.LoadPriority();
        }

        private void LoadPriority()
        {
            cmb_priority.Items.Add("BAJA");
            cmb_priority.Items.Add("MEDIA");
            cmb_priority.Items.Add("ALTA");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAMGrado form = new FormAMGrado(this, true, 0);
            this.Hide();
            form.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(dgv_list.CurrentRow.Cells[0].Value);

            FormAMGrado form = new FormAMGrado(this, false, id);
            this.Hide();
            form.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmarBaja())
            {
                GradoDAO grado = new GradoDAO();

                grado.Id = Convert.ToInt32(dgv_list.CurrentRow.Cells[0].Value.ToString());
                GradoConnection.DeleteGrado(grado);
                MessageBox.Show("El Grado ha sido dado de baja correctamente.");

                dgv_list.DataSource = GradoConnection.ListExistingGrado(null).Tables[0];
            }
        }

        private bool ConfirmarBaja()
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el grado seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GradoDAO grado = new GradoDAO();

            grado.Prioridad = cmb_priority.GetItemText(cmb_priority);
            dgv_list.DataSource = GradoConnection.ListExistingGrado(grado).Tables[0];
        }
    }
}
