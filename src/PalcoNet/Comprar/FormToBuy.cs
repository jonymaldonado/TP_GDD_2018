using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MyLibrary;
using DAO;

namespace PalcoNet.Comprar
{
    public partial class FormToBuy : Form
    {
        public static string systemDate = ConfigurationManager.AppSettings["FechaSistema"];
        private const int pageSize = 10;
        private int totalRecords;
        public Int64 total = 0;
        private DataSet ds;
        private Int32 IdCliente;
        private static BindingList<UbicationDAO> ubications = new BindingList<UbicationDAO>();
        private static BindingList<UbicationDAO> ubicationsToBuy = new BindingList<UbicationDAO>();


        public FormToBuy(Int32 IdCliente)
        {
            InitializeComponent();
            //dtp_date_from.MinDate = DateTime.Parse(systemDate.ToString());
            //dtp_date_to.MinDate = DateTime.Parse(systemDate.ToString());

            this.IdCliente = IdCliente;
            ModifyScreen(); 
            LoadCombos();
        }

        private void ModifyScreen()
        {
            dgv_ubicaciones.DataSource = ubications;
            dgv_ubications_to_buy.DataSource = ubicationsToBuy;

            //Oculta los id de ubicaciones
            dgv_ubicaciones.Columns["UbicacionId"].Visible = false;
            dgv_ubicaciones.Columns["PubliID"].Visible = false;
            dgv_ubicaciones.Columns["EmpresaID"].Visible = false;
            dgv_ubicaciones.Columns["TipoDAO"].Visible = false;

            dgv_ubicaciones.Columns["Tipo"].DisplayIndex = 1;
            dgv_ubicaciones.Columns["Fila"].DisplayIndex = 2;
            dgv_ubicaciones.Columns["Asiento"].DisplayIndex = 3;
            dgv_ubicaciones.Columns["SinNumerar"].DisplayIndex = 4;
            dgv_ubicaciones.Columns["Precio"].DisplayIndex = 5;

            dgv_ubications_to_buy.Columns["UbicacionId"].Visible = false;
            dgv_ubications_to_buy.Columns["EmpresaID"].Visible = false;
            dgv_ubications_to_buy.Columns["TipoDAO"].Visible = false;

            dgv_ubications_to_buy.Columns["PubliID"].DisplayIndex = 1;
            dgv_ubications_to_buy.Columns["Tipo"].DisplayIndex = 2;
            dgv_ubications_to_buy.Columns["Fila"].DisplayIndex = 3;
            dgv_ubications_to_buy.Columns["Asiento"].DisplayIndex = 4;
            dgv_ubications_to_buy.Columns["SinNumerar"].DisplayIndex = 5;
            dgv_ubications_to_buy.Columns["Precio"].DisplayIndex = 6;

            txt_total.Text = total.ToString();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int) bindingSource1.Current;

            DataSet ds1 = this.ds;
            DataSet ds2 = new DataSet();
            ds2 = ds1.Clone();

            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            {
                ds2.Tables[0].ImportRow(ds1.Tables[0].Rows[i]);
            }

            dgv_list.DataSource = ds2.Tables[0];

        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }
            public int totalRecords { get; set; }

            public PageOffsetList(int totalRecors)
            {
                this.totalRecords = totalRecors;
            }

            public System.Collections.IList GetList()
            {
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < this.totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);

                return pageOffsets;
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_date_from_ValueChanged(object sender, EventArgs e)
        {
            dtp_date_to.MinDate = dtp_date_from.Value;
        }

        private void LoadCombos()
        {
            SqlDataReader reader = BuyConnection.GetCategories();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader.GetSqlString(1));
                    item.Value = reader.GetInt32(0); // reader.GetSqlInt32(0);
                    
                    cmb_1.Items.Add(item);
                    cmb_2.Items.Add(item);
                    cmb_3.Items.Add(item);
                }
            }

            reader.Close();

            cmb_1.SelectedIndex = 0;
            cmb_2.SelectedIndex = 0;
            cmb_3.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int grade1 = 0;
            int grade2 = 0;
            int grade3 = 0;

            ComboboxItem item = new ComboboxItem();
            item = (ComboboxItem)cmb_1.SelectedItem;
            grade1 = (int)item.Value;

            item = (ComboboxItem)cmb_2.SelectedItem;
            grade2 = (int)item.Value;

            item = (ComboboxItem)cmb_3.SelectedItem;
            grade3 = (int)item.Value;

            DataSet ds = BuyConnection.ListExistingPublications(dtp_date_from.Value.Date
                                                                       , dtp_date_to.Value.Date
                                                                       , DateTime.Parse(systemDate.ToString())
                                                                       , txt_desc.Text
                                                                       , grade1 //(cmb_1.Text != "") ? cmb_1.Text.Substring(0,1) : null
                                                                       , grade2 //(cmb_2.Text != "") ? cmb_2.Text.Substring(0,1) : null
                                                                       , grade3); //(cmb_3.Text != "") ? cmb_3.Text.Substring(0,1) : null);

            this.ds = ds;
            dgv_list.DataSource = this.ds.Tables[0];
            this.totalRecords = dgv_list.Rows.Count;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList(this.totalRecords);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Int32 PubliID = 0;

            if (dgv_list.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar solo una línea", "Advertencia");
            else
            {
                foreach (DataGridViewRow row in dgv_list.SelectedRows)
                {
                    PubliID = Convert.ToInt32(row.Cells["Publicacion_ID"].Value);
                }

                LoadUbications(PubliID);
                
            }
        }

        private void LoadUbications(Int32 PubliID)
        {
            SqlDataReader reader = UbicationConnection.GetUbicationsToBuy(PubliID);

            ubications.Clear();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    UbicationDAO ubicacion = new UbicationDAO();
                    UbicationTypeDAO tipo = new UbicationTypeDAO();

                    ubicacion.PubliID = reader.GetInt32(0);
                    ubicacion.UbicacionId = reader.GetInt32(1);
                    ubicacion.EmpresaID = reader.GetInt32(2);
                    ubicacion.Fila = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    ubicacion.Asiento = Convert.ToInt32(reader.GetDecimal(5));
                    ubicacion.SinNumerar = reader.GetBoolean(6);
                    ubicacion.Precio = Convert.ToInt32(reader.GetDecimal(7));
                    tipo.id = reader.GetInt32(8);
                    tipo.cod = Convert.ToInt32(reader.GetDecimal(9));
                    tipo.desc = reader.IsDBNull(3) ? "" : reader.GetString(3);

                    ubicacion.TipoDAO = tipo;

                    ubications.Add(ubicacion);
                }
            }

            reader.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ubicaciones.SelectedRows)
            {
                UbicationDAO ubicacion = new UbicationDAO();
                ubicacion = ubications.ElementAt(row.Index);

                if (ubicationsToBuy.SingleOrDefault(u => u.PubliID == ubicacion.PubliID && u.UbicacionId == ubicacion.UbicacionId) == null)
                {
                    ubicationsToBuy.Add(ubicacion);
                    total += ubicacion.Precio;
                    txt_total.Text = total.ToString();
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ubications_to_buy.SelectedRows)
            {
                UbicationDAO ubicacion = new UbicationDAO();
                ubicacion = ubicationsToBuy.ElementAt(row.Index);
                total -= ubicacion.Precio;
                txt_total.Text = total.ToString();
                ubicationsToBuy.RemoveAt(row.Index);

            }

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            
        }

    }
}
