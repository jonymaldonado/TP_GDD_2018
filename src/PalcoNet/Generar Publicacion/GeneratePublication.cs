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

namespace PalcoNet.Generar_Publicacion
{
    public partial class GeneratePublication : Form
    {
        private static BindingList<DateTime> batchDates = new BindingList<DateTime>();
        private static BindingList<UbicationDAO> ubications = new BindingList<UbicationDAO>();
        
        public GeneratePublication()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Time;

            batchDates.Clear();
            lb_batch.DataSource = batchDates;
            lb_ubic.DataSource = ubications;
            dgv_list.DataSource = ubications;
            LoadUbicationTypes();
        }

        private void LoadUbicationTypes()
        {
            List<UbicationTypeDAO> ubicationsTypes = UbicationConnection.GetUbicationTypes();

            foreach(UbicationTypeDAO ubicationType in ubicationsTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = ubicationType.desc;
                item.Value = ubicationType.id;

                cb_type.Items.Add(item);
                
            }
        
        }


        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_date_add_Click(object sender, EventArgs e)
        {
            if (batchDates.Count != 0)
                if (batchDates.Last() < dateTimePicker1.Value)
                    batchDates.Add(dateTimePicker1.Value);
                else
                    MessageBox.Show("La fecha/hora debe ser posterior a la última ingresada", "Atención");
            else
                batchDates.Add(dateTimePicker1.Value);
        }

        private void btn_date_remove_Click(object sender, EventArgs e)
        {

            if (lb_batch.SelectedIndex >= 0)
            {
                DateTime itemSelected = (DateTime)lb_batch.Items[lb_batch.SelectedIndex];
                batchDates.Remove(itemSelected);
            }
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            using (Abm_Grado.FormGrado FormGrado = new Abm_Grado.FormGrado(this))
            {
                FormGrado.ShowDialog();
            }
        }

        public string grade
        {
            set { txt_grade.Text = value; }
        }

        public string commision
        {
            set { txt_comision.Text = value; }
        }

        private void txt_numerico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cb_no_number_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_no_number.Checked)
            {
                txt_filas.Clear();
                txt_asientos.Clear();
                txt_filas.Enabled = false;
                //txt_asientos.Enabled = false;
                label11.Text = "Cantidad";
            }
            else
            {
                txt_filas.Enabled = true;
                label11.Text = "Asientos";
            }
        }

        private void btn_ubic_add_Click(object sender, EventArgs e)
        {
            int filas = Convert.ToInt32(txt_filas.Text);
            int asientos = Convert.ToInt32(txt_asientos.Text);

            if (cb_no_number.Checked)
                filas = 1;

            for (int i = 1; i <= filas; i++ )
            {

                for (int j = 1; j <= asientos; j++)
                {
                    UbicationDAO ubicacion = new UbicationDAO();

                    if (!cb_no_number.Checked)
                    {
                        ubicacion.Fila = i.ToString();
                        ubicacion.Asiento = j;

                    }
                    else
                    {
                        ubicacion.SinNumerar = true;
                    }
                    //ubicacion.type.id = cb_type.SelectedIndex;
                    //ubicacion.type.desc = cb_type.SelectedIndex.ToString();
                    ubicacion.Precio = Convert.ToInt32(txt_precio.Text);
                    ubications.Add(ubicacion);

                }

            }
            
        }
        
    }
}
