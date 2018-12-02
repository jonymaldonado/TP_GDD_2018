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
        GradoDAO grado = new GradoDAO();
        Int32 id;
        bool isUpper = false;
        Form formPrevious;

        public FormAMGrado(FormGrado formGrado, bool isUpper, Int32 id)
        {
            InitializeComponent();
            this.isUpper = isUpper;
            this.formPrevious = formGrado;
            LoadPriority();

            if (!isUpper) //Modificacion
            {
                this.id = id;
                this.LoadFieldsOfGrado();
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
                grado = GetGradoDAO();
                //MessageBox.Show("grado "+grado.Comision+" des"+grado.Prioridad);
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
                grado = GetGradoDAO();
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

            grado.Comision = Convert.ToDecimal(txt_comision.Text) / 100;
            grado.Prioridad = cmb_priority.Text;

            return grado;
        }

        private void LoadFieldsOfGrado()
        {
            SqlDataReader reader = GradoConnection.GetGradoForModify(this.id);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Decimal value = reader.GetDecimal(0) * 100;
                    Int32 valueInt = Convert.ToInt32(value);
                    txt_comision.Text = valueInt.ToString();

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

        private void txt_comision_Validating(object sender, CancelEventArgs e)
        {
            Int32 value = 0;
            
            if(!String.IsNullOrEmpty(txt_comision.Text))
                value = Convert.ToInt32(txt_comision.Text);

            if (value < 0 || value > 100)
            {
                MessageBox.Show("El Porcentaje de comision debe estar entre 0 y 100");
                e.Cancel = true;
            }
            else
                e.Cancel = false;

        }




    }
}
