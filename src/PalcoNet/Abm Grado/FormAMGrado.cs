using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using MyLibrary;


namespace PalcoNet.Abm_Grado
{
    public partial class FormAMGrado : Form
    {
        Int32 id;
        bool isUpper = false;
        Form formPrevious;

        public FormAMGrado(FormGrado formGrado, bool isUpper, Int32 id)
        {
            InitializeComponent();
            this.isUpper = isUpper;
            this.formPrevious = formGrado;


            if (!isUpper) //Modificacion
            {
                this.id = id;
                //this.LoadFieldsOfGrado();
            }

        }

        private void LoadPriority()
        {
            cmb_priority.Items.Add("BAJA");
            cmb_priority.Items.Add("MEDIA");
            cmb_priority.Items.Add("ALTA");
        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isUpper)
                    this.CreateGrado();
                else
                    this.UpdateGrado();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());                
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrevious.Show();
            this.Close();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_comision.Text = "";
        }

        private void CreateGrado()
        {
            if (this.checkMandatoryFields())
            {
                GradoDAO grado = GetGradoDAO();

                GradoConnection.CreateGrado(grado);
                MessageBox.Show("El Grado ha sido creado correctamente.");

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
        }


        private void UpdateGrado()
        {
            if (this.checkMandatoryFields())
            {
                GradoDAO grado = GetGradoDAO();

                GradoConnection.UpdateGrado(grado, this.id);
                MessageBox.Show("La modificación del grado ha sido realizado correctamente.");
                formPrevious.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
        }

        private bool checkMandatoryFields()
        {
            return (!string.IsNullOrEmpty(txt_comision.Text));
        }

        private GradoDAO GetGradoDAO()
        {
            GradoDAO grado = new GradoDAO();

            grado.Comision = Convert.ToInt32(txt_comision.Text);
            grado.Prioridad = cmb_priority.GetItemText(cmb_priority);

            return grado;
        }

        private void LoadFieldsOfGrado()
        {
            SqlDataReader reader = GradoConnection.GetGradoForModify(this.id);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_comision.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    cmb_priority.SelectedIndex = cmb_priority.FindStringExact(reader.GetString(1));

                }
            }

            reader.Close();
        }

        private void txt_comision_KeyPress(object sender, KeyPressEventArgs e)
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


    }
}
