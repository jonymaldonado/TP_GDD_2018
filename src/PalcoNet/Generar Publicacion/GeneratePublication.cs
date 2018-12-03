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
using System.Data.SqlClient;
using System.Configuration;


namespace PalcoNet.Generar_Publicacion
{
    public partial class GeneratePublication : Form
    {
        //Campos para la edicion
        private PublicationDAO publication = new PublicationDAO();
        private PublicationStateDAO publicationState = new PublicationStateDAO();
        private GradoDAO gradeEdit = new GradoDAO();
        private RubroDAO rubro = new RubroDAO();
        private static BindingList<UbicationDAO> deletedUbications = new BindingList<UbicationDAO>();
        bool edit = false;
        
        private static BindingList<DateTime> batchDates = new BindingList<DateTime>();
        private static BindingList<UbicationDAO> ubications = new BindingList<UbicationDAO>();
        private List<UbicationTypeDAO> ubicationsTypes = new List<UbicationTypeDAO>();
        private List<RubroDAO> rubros = new List<RubroDAO>();
        private List<PublicationStateDAO> publicationStates = new List<PublicationStateDAO>();
        private String user;
        private Int32 idEmpresa;
        private Int32 idGrado;
        private Form previusForm;

        public string grade
        {
            set 
            { 
                txt_grade.Text = value;
                gradeEdit.Prioridad = value;           
            } 
        }

        public string commision
        {
            set 
            { 
                txt_comision.Text = value;
                gradeEdit.Comision = Convert.ToDecimal(value);
            }
        }

        public Int32 IdGrado
        {
            set { this.idGrado = value; gradeEdit.Id = value; }
            get { return this.idGrado; }
        }   

        public GeneratePublication(Form previusForm, String user, Int32 idEmpresa, Int32 idPubliEdit, bool edit)
        {
            InitializeComponent();

            //Setea globales
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";  
            this.user = user;
            this.idEmpresa = idEmpresa;
            this.edit = edit;
            this.previusForm = previusForm;

            //Carga combos
            LoadUbicationTypes();
            LoadRubro();

            //Limpia listas
            batchDates.Clear();
            ubications.Clear();

            //Carga los datos de la publicacion si se edita
            if (this.edit)
            {
                LoadPublication(idPubliEdit);
                LoadUbications(idPubliEdit);
            }
                        
            //Asigna las listas globales a las tablas de la pantalla
            lb_batch.DataSource = batchDates;
            dgv_list.DataSource = ubications;

            //Modifica la pantalla en base a los estados
            ModifyScreen();
        }

        private void ModifyScreen()
        {

            //Oculta los id de ubicaciones
            dgv_list.Columns["UbicacionId"].Visible = false;
            dgv_list.Columns["TipoDAO"].Visible = false;

            //Grisa campos no editables
            if (this.edit)
            {
                btn_date_add.Enabled = false;
                btn_date_remove.Enabled = false;
                lb_batch.Enabled = false;
            }

            //Carga el combo de estado
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

        private void LoadPublication(Int32 idPubliEdit)
        {
            SqlDataReader reader = PublicationConnection.GetPublicationForEdit(idPubliEdit);

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    //Publicacion
                    this.publication.PubliID = reader.GetInt32(0); 
                    this.publication.Description = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    this.publication.PublicDate = reader.GetDateTime(2);
                    this.publication.EspecDate = reader.GetDateTime(3);
                    this.publication.CantLoc = Convert.ToInt32(reader.GetDecimal(4));
                    this.publication.Username = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    this.publication.EspecID = reader.GetInt32(6);
                    this.publication.GradeID = reader.GetInt32(7);
                    this.publication.StateID = reader.GetInt32(8);

                    //Espectaculo
                    this.publication.Espectaculo_ID = reader.GetInt32(9);
                    this.publication.Espectaculo_Codigo = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);  
                    this.publication.Espectaculo_Descripcion = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    this.publication.Espectaculo_Direccion = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    this.publication.Espectaculo_Fecha = reader.GetDateTime(13);
                    this.publication.Espectaculo_Fecha_Vencimiento = reader.GetDateTime(14);
                    this.publication.Rubro_ID = reader.GetInt32(15);
                    this.publication.Empresa_ID = reader.GetInt32(16);
                    
                    //Grado
                    this.gradeEdit.Id = reader.GetInt32(17);
                    this.IdGrado = this.gradeEdit.Id;
                    this.gradeEdit.Comision = reader.GetDecimal(18);
                    this.gradeEdit.Prioridad = reader.IsDBNull(19) ? "" : reader.GetString(19);
                    
                    //Estado
                    this.publicationState.StateID = reader.GetInt32(20);
                    this.publicationState.Description = reader.IsDBNull(21) ? "" : reader.GetString(21);
                    this.publicationState.Editable = reader.GetBoolean(22);
                    
                    //Form
                    txt_description.Text = publication.Description;
                    dtp_date.Value = publication.PublicDate;
                    dateTimePicker1.Value = publication.EspecDate;
                    txt_direction.Text = publication.Espectaculo_Direccion;
                    cb_rubro.SelectedIndex = publication.Rubro_ID - 1;
                    //cb_state.SelectedIndex = publicationState.StateID - 1;

                    txt_grade.Text = gradeEdit.Prioridad;
                    txt_comision.Text = Convert.ToString(gradeEdit.Comision);

                }
            }

            reader.Close();
        }

        private void LoadUbications(Int32 idPubliEdit)
        {
            SqlDataReader reader = UbicationConnection.GetUbications(idPubliEdit);

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    UbicationDAO ubicacion = new UbicationDAO();
                    UbicationTypeDAO tipo = new UbicationTypeDAO();

                    ubicacion.UbicacionId = reader.GetInt32(1);
                    ubicacion.Fila = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    ubicacion.Asiento = Convert.ToInt32(reader.GetDecimal(3));
                    ubicacion.SinNumerar = reader.GetBoolean(4);
                    ubicacion.Precio = Convert.ToInt32(reader.GetDecimal(5));
                    tipo.id = reader.GetInt32(7);
                    tipo.cod = Convert.ToInt32(reader.GetDecimal(8));
                    tipo.desc = reader.IsDBNull(9) ? "" : reader.GetString(9);

                    ubicacion.TipoDAO = tipo;

                    ubications.Add(ubicacion);
                }
            }

            reader.Close();
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

                if (this.edit)
                {
                    if(publicationState.StateID == 1 && state.StateID != 3)
                        cb_state.Items.Add(item);
                    else if (publicationState.StateID == 2 && state.StateID != 1)
                    {
                        cb_state.Items.Add(item);
                        gb_grade.Enabled = false;
                        gb_ubications.Enabled = false;
                        gb_date.Enabled = false;
                        txt_description.Enabled = false;
                        dtp_date.Enabled = false;
                        txt_direction.Enabled = false;
                        cb_rubro.Enabled = false;
                    }
                }
                else if (state.StateID == 1)
                {
                    cb_state.Items.Add(item);
                    cb_state.Enabled = false;
                }
            }
            //Siempre el estado va a ser el primero del combo box. Si esta en estado publicado, borrador no se carga
            cb_state.SelectedIndex = 0;
            
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.previusForm.Show();
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
            {
                if (dateTimePicker1.Value < dtp_date.Value)
                    MessageBox.Show("La fecha/hora debe ser posterior a la fecha de publicación", "Atención");
                else
                    batchDates.Add(dateTimePicker1.Value);
            }
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
            //int filas = 0
            int asientos = 0;
            bool campos_vacios = true;

            if (cb_no_number.Checked)
            {

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
                    //filas = 1;
                }
            }

            if (campos_vacios)
                MessageBox.Show("Complete todos los campos de Ubicación", "Error");
            else
            {
                asientos = Convert.ToInt32(txt_asientos.Text);

                //for (int i = 1; i <= filas; i++)
                //{

                    for (int j = 1; j <= asientos; j++)
                    {
                        UbicationDAO ubicacion = new UbicationDAO();

                        if (!cb_no_number.Checked)
                        {
                            ubicacion.Fila = txt_filas.Text;
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

                //}
            }
        }

        private void btn_ubic_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                UbicationDAO ubicacion = new UbicationDAO();

                ubicacion = ubications.ElementAt(row.Index);
                if(ubicacion.UbicacionId != 0)
                {
                    deletedUbications.Add(ubicacion);
                }
                ubications.RemoveAt(row.Index);
            }
        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkMandatoryFields())
            {
                if (this.edit)
                    EditPublication();
                else
                    CreatePublication();
            }
        }

        private void LoadDynproFields()
        {
            
            publication.Description = txt_description.Text;
            publication.PublicDate = dtp_date.Value;
            publication.EspecDate = dateTimePicker1.Value;
            publication.CantLoc = ubications.Count;
            publication.Username = this.user;
            publication.GradeID = this.IdGrado;
            publication.Espectaculo_Direccion = txt_direction.Text;

            rubro = rubros.ElementAt(cb_rubro.SelectedIndex);
            
            ComboboxItem item = new ComboboxItem();
            item = (ComboboxItem)cb_state.SelectedItem;
            publication.StateID = (int)item.Value;            
        
        }

        private void CreatePublication()
        {
            LoadDynproFields();
            
            PublicationConnection.CreatePublications(publication, batchDates, ubications, idEmpresa, rubro);
            this.Close();

        }

        private void EditPublication()
        {
            LoadDynproFields();
           
            if (PublicationConnection.CheckPublicationExits(publication, rubro))
                MessageBox.Show("Ya existe una publicación igual en la misma Fecha/Hora, por favor verifique los datos", "Advertencia");
            else
            {
                PublicationConnection.EditPublication(publication, ubications, deletedUbications, rubro);
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

            if (dtp_date.Value < Convert.ToDateTime(ConfigurationManager.AppSettings["FechaSistema"]))
            {
                MessageBox.Show("La fecha de publicacion debe ser mayor a la fecha del sistema", "Advertencia");
                return false;
            }

            if(this.edit)
                if(dtp_date.Value > dateTimePicker1.Value)
                {
                    MessageBox.Show("La fecha del espectáculo debe ser mayor a la fecha de publicacion", "Advertencia");
                    return false;
                }

            if (string.IsNullOrEmpty(txt_grade.Text) &&
               string.IsNullOrEmpty(txt_comision.Text))
            {
                MessageBox.Show("Debe seleccionar un grado para la Publicación", "Advertencia");
                return false;
            }

            if (!this.edit)
            {
                if (batchDates.Count == 0)
                {
                    MessageBox.Show("Debe agregar almenos una fecha para el Espectáculo", "Advertencia");
                    return false;
                }
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (ubications.Count == 0)
            {
                sb.Append("No se cargaron ubicaciones a la publicación.");
                sb.Append(Environment.NewLine);
                //sb.Append("Luego no podrá cargarlas");
                //sb.Append(Environment.NewLine);
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
