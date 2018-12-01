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
        private List<UbicationTypeDAO> ubicationsTypes = new List<UbicationTypeDAO>();
        private List<RubroDAO> rubros = new List<RubroDAO>();
        private List<PublicationStateDAO> publicationStates = new List<PublicationStateDAO>();
        private String user;
        private Int32 idEmpresa;
        private Int32 idGrado;

        public string grade
        {
            set { txt_grade.Text = value; } 
        }

        public string commision
        {
            set { txt_comision.Text = value; }
        }

        public Int32 IdGrado
        {
            set { this.idGrado = value; }
            get { return this.idGrado; }
        }   


        public GeneratePublication(String user, Int32 idEmpresa)
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.user = user;
            this.idEmpresa = idEmpresa;

            batchDates.Clear();
            lb_batch.DataSource = batchDates;
            dgv_list.DataSource = ubications;
            dgv_list.Columns["TipoDAO"].Visible = false;
            LoadUbicationTypes();
            LoadRubro();
            LoadState();
        }

        private void LoadUbicationTypes()
        {
            ubicationsTypes = UbicationConnection.GetUbicationTypes();

            foreach(UbicationTypeDAO ubicationType in ubicationsTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = ubicationType.desc;
                item.Value = ubicationType.id;

                cb_type.Items.Add(item);
                
            }
        
        }

        private void LoadRubro()
        {
            rubros = PublicationConnection.GetRubros();

            foreach (RubroDAO rubro in rubros)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = rubro.Descripcion;
                item.Value = rubro.Id;

                cb_rubro.Items.Add(item);
            }
        }

        private void LoadState()
        {
            publicationStates = PublicationConnection.GetPublicationStates();

            foreach (PublicationStateDAO state in publicationStates)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = state.Description;
                item.Value = state.StateID;

                cb_state.Items.Add(item);
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
                //txt_asientos.Clear();
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

            int filas = 0;
            int asientos = 0;
            bool campos_vacios = true;

            if (cb_no_number.Checked)
            {
                filas = 1;
                if (!string.IsNullOrEmpty(txt_asientos.Text) &&
                    !string.IsNullOrEmpty(txt_precio.Text) &&
                    !string.IsNullOrEmpty(cb_type.Text))
                    campos_vacios = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_asientos.Text) &&
                    !string.IsNullOrEmpty(txt_precio.Text) &&
                    !string.IsNullOrEmpty(cb_type.Text) &&
                    !string.IsNullOrEmpty(txt_filas.Text))
                {
                    campos_vacios = false;
                    filas = Convert.ToInt32(txt_filas.Text);
                }
            }

            if (campos_vacios)
                MessageBox.Show("Complete todos los campos de Ubicación", "Error");
            else
            {
                asientos = Convert.ToInt32(txt_asientos.Text);

                for (int i = 1; i <= filas; i++)
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
                            ubicacion.Fila = "0";
                            ubicacion.Asiento = 0;
                        }
                        ubicacion.TipoDAO = ubicationsTypes.ElementAt(cb_type.SelectedIndex);
                        ubicacion.Precio = Convert.ToInt32(txt_precio.Text);
                        ubications.Add(ubicacion);

                    }

                }
            }
        }

        private void btn_ubic_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                dgv_list.Rows.RemoveAt(row.Index);
            }
        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicationDAO publication = new PublicationDAO();
            RubroDAO rubro = new RubroDAO();

            if (checkMandatoryFields())
            {
                publication.Description = txt_description.Text;
                publication.PublicDate = dtp_date.Value;
                publication.CantLoc = ubications.Count;
                publication.Username = this.user;
                publication.GradeID = this.IdGrado;
                publication.Espectaculo_Direccion = txt_direction.Text;
                
                rubro = rubros.ElementAt(cb_rubro.SelectedIndex); 

                publication.StateID = publicationStates.ElementAt(cb_state.SelectedIndex).StateID;

                PublicationConnection.CreatePublications(publication, batchDates, ubications, idEmpresa, rubro);
                this.Close();
            }
        }

        private bool checkMandatoryFields()
        {
            //Campos de cabecera
            if(string.IsNullOrEmpty(txt_description.Text) ||
               string.IsNullOrEmpty(txt_direction.Text) ||
               string.IsNullOrEmpty(cb_state.Text) ||
               string.IsNullOrEmpty(cb_rubro.Text) ||
               string.IsNullOrEmpty(dtp_date.Text))
            {
                MessageBox.Show("Complete todos los campos de cabecera de la Publicación","Advertencia");
                return false;
            }

            if (string.IsNullOrEmpty(txt_grade.Text) &&
               string.IsNullOrEmpty(txt_comision.Text))
            {
                MessageBox.Show("Debe seleccionar un grado para la Publicación", "Advertencia");
                return false;
            }

            if (batchDates.Count == 0)
            {
                MessageBox.Show("Debe agregar almenos una fecha para el Espectáculo", "Advertencia");
                return false;
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();


            if (ubications.Count == 0)
            {
                sb.Append("No se cargaron ubicaciones a la publicación.");
                sb.Append(Environment.NewLine);
                sb.Append("Luego no podrá cargarlas");
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            
            }

            if (batchDates.Count() > 1)
            {
                sb.Append("Se generarán " + batchDates.Count + " publicacion/es");
                sb.Append(Environment.NewLine);
            }

            sb.Append("¿Desea confirmar los datos de la Publicación?" );

            DialogResult result = MessageBox.Show(sb.ToString(), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;

        }        
    }
}
