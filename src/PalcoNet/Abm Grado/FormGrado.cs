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
        public Generar_Publicacion.GeneratePublication FormGenerate;
        
        public FormGrado()
        {
            InitializeComponent();
            this.LoadPriority();
            this.btn_select.Visible = false;
        }

        public FormGrado(Generar_Publicacion.GeneratePublication Form)
        {
            InitializeComponent();
            this.LoadPriority();
            this.FormGenerate = Form;

            this.addToolStripMenuItem.Visible = false;
            this.deleteToolStripMenuItem.Visible = false;
            this.updateToolStripMenuItem.Visible = false;
            this.btn_select.Enabled = true;
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
                grado.Prioridad = cmb_priority.Text;
                GradoConnection.DeleteGrado(grado);
                MessageBox.Show("El Grado ha sido dado de baja correctamente.");

                dgv_list.DataSource = GradoConnection.ListExistingGrado(grado).Tables[0];
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

            grado.Prioridad = cmb_priority.Text;
            dgv_list.DataSource = GradoConnection.ListExistingGrado(grado).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_list.RowCount == 0) {
                MessageBox.Show("Antes debe buscar un grado para poder seleccionarlo.");
                return;
            }

            int selectedrowindex = dgv_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_list.Rows[selectedrowindex];  

            
            this.FormGenerate.grade = Convert.ToString(selectedRow.Cells["Grado_Publicacion_Prioridad"].Value);
            this.FormGenerate.commision = Convert.ToString(selectedRow.Cells["Grado_Publicacion_Comision"].Value);
            this.FormGenerate.IdGrado = Convert.ToInt32(selectedRow.Cells["Grado_Publicacion_ID"].Value);

            this.Close();
        }
    }
}
